using System;
using System.Collections.Generic;
using System.Text;
using kTesterLib.Service;
using System.Data.SqlClient;
using kTesterLib.Meta;
using System.Linq;
using System.Data;

namespace kTesterServer
{
    public static class DataBase
    {
        static string connectionString = @"Data Source=VB\SQLEXPRESS;Initial Catalog=kTester;Integrated Security=True";

        static Dictionary<string, string> storageProcedures = new Dictionary<string, string>()
        {
            { "USER_AUTH", "sp_UserAuth" },
            { "FAC_GET", "sp_FacultiesGet"},
            { "FAC_ADD", "sp_FacultyAdd"},
            { "FAC_DLT", "sp_FacultyDlt"},
            { "FAC_EDT", "sp_FacultyEdt"},
        };

        static Dictionary<string, string> existStorageProcedures = new Dictionary<string, string>()
        {
            { "FAC_EDT", "sp_FacultyExist"},
            { "FAC_ADD",  "sp_FacultyExist"}
        };

        #region Проверка на существование записи в таблице
        private static bool IsExist(Dictionary<string, string> searchParametrs, string serverParametr, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(existStorageProcedures[serverParametr], connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (KeyValuePair<string, string> parametr in searchParametrs)
            {
                SqlParameter sqlParametr = new SqlParameter() { ParameterName = parametr.Key, Value = parametr.Value };
                command.Parameters.Add(sqlParametr);
            }
            int result = (int)command.ExecuteScalar();
            return result > 0;
        }
        #endregion

        #region Авторизация пользователей
        public static User GetUser(User user, string serverParametr)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(storageProcedures[serverParametr], connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter loginP = new SqlParameter() { ParameterName = "@login", Value = user.Login };
                command.Parameters.Add(loginP);
                SqlParameter passwordP = new SqlParameter() { ParameterName = "@password", Value = user.Password };
                command.Parameters.Add(passwordP);

                var result = command.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        return new User((int)result[0], result[1].ToString(), result[2].ToString(), (int)result[3]);
                    }
                    return null;
                }
                else 
                {
                    ServerLog.Log($"Неудачная попытка авторизоваться пользователя {user.Login} с паролем {user.Password}. Введенные данные в базе отсутсвуют");
                    return user;
                }
            }
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА авторизации пользователя {user.Login} с паролем {user.Password}: {ex.Message}");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        internal static bool DefaultDeleteQuery(Dictionary<string, string> dict, string serverParametr)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(storageProcedures[serverParametr], connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (KeyValuePair<string, string> parametr in dict)
                {
                    SqlParameter sqlParametr = new SqlParameter() { ParameterName = parametr.Key, Value = parametr.Value };
                    command.Parameters.Add(sqlParametr);
                }

                var result = command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА удаления данных, словарь: {string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray())}, " +
                              $"хранимая процедура {storageProcedures[serverParametr]} {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        internal static bool? DefaultEditQuery(Dictionary<string, string> dict, string serverParametr)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                if (IsExist(dict, serverParametr, connection))
                    return null;

                SqlCommand command = new SqlCommand(storageProcedures[serverParametr], connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (KeyValuePair<string, string> parametr in dict)
                {
                    SqlParameter sqlParametr = new SqlParameter() { ParameterName = parametr.Key, Value = parametr.Value };
                    command.Parameters.Add(sqlParametr);
                }

                var result = command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА редактирования данных, словарь: {string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray())}, " +
                              $"хранимая процедура {storageProcedures[serverParametr]} {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        #region Запросы к таблице факультетов FACULTIES
        internal static List<object[]> DefaultSelectQuery(string serverParametr)
        {
            List<object[]> list = new List<object[]>();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(storageProcedures[serverParametr], connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var result = command.ExecuteReader();
                while (result.Read())
                {
                    object[] values = new Object[result.FieldCount]; 
                    int fieldCount = result.GetValues(values);
                    list.Add(values);
                }
                return list ;
            }
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА выборки данных, хранимая процедура {storageProcedures[serverParametr]} {ex.Message}");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        internal static int DefaultAddQuery(Dictionary<string, string> dict, string serverParametr)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                if (!IsExist(dict, serverParametr, connection))
                {
                    SqlCommand command = new SqlCommand(storageProcedures[serverParametr], connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    foreach (KeyValuePair<string, string> parametr in dict)
                    {
                        SqlParameter sqlParametr = new SqlParameter() { ParameterName = parametr.Key, Value = parametr.Value };
                        command.Parameters.Add(sqlParametr);
                    }

                    SqlParameter IdParametr = new SqlParameter
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int
                    };
                    IdParametr.Direction = ParameterDirection.Output;
                    command.Parameters.Add(IdParametr);

                    command.ExecuteNonQuery();
                    return (int)command.Parameters["@id"].Value;
                }
                return 0;
            }
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА добавления данных, словарь: {string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray())}, " +
                               $"хранимая процедура {storageProcedures[serverParametr]} {ex.Message}");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion


        
    }
}
