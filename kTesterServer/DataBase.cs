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
            { "USER_GET", "sp_UserGet" },
            { "USER_DLT", "sp_UserDlt" },
            { "USER_ADD", "sp_UserAdd" },
            { "USER_EDT", "sp_UserEdt" },
            { "USER_PASS", "sp_UserPassUpd" },
            { "LOG_ADD", "sp_LogAdd" },
            { "FAC_GET", "sp_FacultiesGet"},
            { "FAC_ADD", "sp_FacultyAdd"},
            { "FAC_DLT", "sp_FacultyDlt"},
            { "FAC_EDT", "sp_FacultyEdt"},
            { "LOG_DAT", "sp_LogsByDate"},
            { "LOG_PRM", "sp_LogsByParams"},
            { "LOG_USR", "sp_LogsByUser"},
            { "LOG_TXT", "sp_LogsByText"},
            { "SGRP_GET", "sp_StudyGroupGet"},
            { "SGRP_DLT", "sp_StudyGroupDlt"},
            { "SGRP_PRM", "sp_StudyGroupByParams"},
            { "SGRP_ADD", "sp_StudyGroupAdd"},
            { "SGRP_EDT", "sp_StudyGroupEdt"},
            { "SBJ_GET", "sp_SubjectGet"},
            { "SBJ_ADD", "sp_SubjectAdd"},
            { "SBJ_DLT", "sp_SubjectDlt"},
            { "SBJ_EDT", "sp_SubjectEdt"},
            { "PRF_GET", "sp_ProfessorGet"},
            { "PRF_ADD", "sp_ProfessorAdd"},
            { "PRF_DLT", "sp_ProfessorDlt"},
            { "PRF_EDT", "sp_ProfessorEdt"},

        };

        static Dictionary<string, string> existStorageProcedures = new Dictionary<string, string>()
        {
            { "FAC_EDT", "sp_FacultyExist"},
            { "FAC_ADD",  "sp_FacultyExist"},
            { "USER_EDT", "sp_UserExist"},
            { "USER_ADD",  "sp_UserExist"},
            { "SGRP_ADD", "sp_StudyGroupExist"},
            { "SGRP_EDT", "sp_StudyGroupExist"},
            { "SBJ_ADD", "sp_SubjectExist"},
            { "SBJ_EDT", "sp_SubjectExist"},
            { "PRF_ADD", "sp_ProfessorExist"},
            { "PRF_EDT", "sp_ProfessorExist"},
        };

        internal static void CreateLog(User user,  string text)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(storageProcedures["LOG_ADD"], connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idP = new SqlParameter() { ParameterName = "@id", Value = user.Id };
                command.Parameters.Add(idP);
                SqlParameter textP = new SqlParameter() { ParameterName = "@text", Value = text };
                command.Parameters.Add(textP);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА логирования действий пользователя {user.Login}: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        #region Проверка на существование записи в таблице
        private static bool? IsExist(Dictionary<string, string> searchParametrs, string serverParametr, SqlConnection connection)
        {
            //Если словарь не содержит значения хранимой процедуры для проверки существования значения, считать, что проверка не нужна, возвращать false (элемент не содержится в таблице)
            try
            {
                if (!existStorageProcedures.ContainsKey(serverParametr))
                    return false;
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
            catch (Exception ex)
            {
                ServerLog.Log($"ОШИБКА проверки на существование объекта (хранимая процедура {existStorageProcedures[serverParametr]}): {ex.Message}");
                return null;
            }
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
                    return user;
                }
            }
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА авторизации пользователя {user.Login} с паролем {user.Password}: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                ServerLog.Log($"ОШИБКА {ex.Message}");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        
        #endregion

        internal static bool DefaultDeleteQuery(Dictionary<string, string> dict, string serverParametr, User user)
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
            catch (Exception ex)
            {
                ServerLog.Log($"ОШИБКА {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }


        internal static List<object[]> DefaultSelectQuery(string serverParametr, User user)
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
                return list;
            }
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА выборки данных, хранимая процедура {storageProcedures[serverParametr]} {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                ServerLog.Log($"ОШИБКА {ex.Message}");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        internal static List<object[]> ParamSelectQuery(Dictionary<string, string> dict, string serverParametr, User currentUser)
        {
            List<object[]> list = new List<object[]>();
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

                var result = command.ExecuteReader();
                while (result.Read())
                {
                    object[] values = new Object[result.FieldCount];
                    int fieldCount = result.GetValues(values);
                    list.Add(values);
                }
                return list;
            }
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА выборки данных, хранимая процедура {storageProcedures[serverParametr]} {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                ServerLog.Log($"ОШИБКА {ex.Message}");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        internal static int DefaultAddQuery(Dictionary<string, string> dict, string serverParametr, User user)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                bool? isExist = IsExist(dict, serverParametr, connection);
                if (isExist == null)
                    return -1;

                if (isExist == true)
                    return 0;

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
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА добавления данных, словарь: {string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray())}, " +
                               $"хранимая процедура {storageProcedures[serverParametr]} {ex.Message}");
                ServerLog.BaseLog(user, $"ОШИБКА добавления данных, словарь: {string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray())}, " +
                               $"хранимая процедура {storageProcedures[serverParametr]} {ex.Message}");
                return -1;
            }
            catch (Exception ex)
            {
                ServerLog.Log($"ОШИБКА {ex.Message}");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        internal static int DefaultEditQuery(Dictionary<string, string> dict, string serverParametr, User user)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                bool? isExist = IsExist(dict, serverParametr, connection);
                if (isExist == null)
                    return -1;

                if (isExist == true)
                    return 0;

                SqlCommand command = new SqlCommand(storageProcedures[serverParametr], connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (KeyValuePair<string, string> parametr in dict)
                {
                    SqlParameter sqlParametr = new SqlParameter() { ParameterName = parametr.Key, Value = parametr.Value };
                    command.Parameters.Add(sqlParametr);
                }

                var result = command.ExecuteNonQuery();
                int id = -1;
                Int32.TryParse(dict["@id"], out id);
                return id;
            }
            catch (SqlException ex)
            {
                ServerLog.Log($"ОШИБКА редактирования данных, словарь: {string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray())}, " +
                              $"хранимая процедура {storageProcedures[serverParametr]} {ex.Message}");
                return -1;
            }
            catch (Exception ex)
            {
                ServerLog.Log($"ОШИБКА {ex.Message}");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }



    }
}
