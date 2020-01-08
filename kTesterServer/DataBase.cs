using System;
using System.Collections.Generic;
using System.Text;
using kTesterLib.Service;
using System.Data.SqlClient;

namespace kTesterServer
{
    public static class DataBase
    {
        static string connectionString = @"Data Source=VB\SQLEXPRESS;Initial Catalog=kTester;Integrated Security=True";

        static Dictionary<string, string> storageProcedures = new Dictionary<string, string>()
        {
            { "AUTH", "sp_GetUser" }
        };

        public static User GetUser(User user, string serverParametr)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Открываем подключение
                connection.Open();
                //хранимая процедура поиска пользователя в таблице Users
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
                ServerLog.Log($"ОШИБКА авторизации пользователя {user.Login} с паролем {user.Password}");
                return null;
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }
        }
    }
}
