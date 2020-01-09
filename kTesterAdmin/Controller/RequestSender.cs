using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using kTesterAdmin.Model;

namespace kTesterAdmin.Controller
{
    public static class RequestSender
    {

        public static Tuple<bool, string> SendRequest(string requestBody)
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(Settings.GetSettings().Ip), Settings.GetSettings().Port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // подключаемся к удаленному хосту
                socket.Connect(ipPoint);

                byte[] requestData = Encoding.UTF8.GetBytes(requestBody);
                socket.Send(requestData);

                // получаем ответ
                var responseData = new byte[256]; // буфер для ответа
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байт

                do
                {
                    bytes = socket.Receive(responseData, responseData.Length, 0);
                    builder.Append(Encoding.UTF8.GetString(responseData, 0, bytes));
                }
                while (socket.Available > 0);

                if (builder.ToString() == "false")
                    return new Tuple<bool, string>(false, "Неопознанный запрос");

                return new Tuple<bool, string>(true, builder.ToString());
            }
            catch(Exception ex)
            {
                return new Tuple<bool, string>(false, $"Ошибка подключения: {ex.Message}");
            }
            finally
            {
                // закрываем сокет
                if (socket.Connected)
                    socket.Shutdown(SocketShutdown.Both);
                socket.Close();

            }

        }
    }
}
