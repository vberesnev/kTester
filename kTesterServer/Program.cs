using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace kTesterServer
{
    class Program
    {
        static int port = 8005;

        static void Main(string[] args)
        {
            IPEndPoint ipPort = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket handler = null;

            try
            {
                listenSocket.Bind(ipPort);
                listenSocket.Listen(50);

                Console.WriteLine("Сервер запущен. Ожидание подключений...");
                ServerLog.Log("Сервер запущен");

                while (true)
                {
                    handler = listenSocket.Accept();

                    StringBuilder data = new StringBuilder();
                    int bytes = 0;
                    byte[] buffer = new byte[256];

                    do
                    {
                        bytes = handler.Receive(buffer);
                        data.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
                    }
                    while (handler.Available > 0);
                    Console.WriteLine(data.ToString());

                    RequestParser request = new RequestParser(data.ToString());

                    // отправляем ответ
                    var response = Encoding.UTF8.GetBytes(request.GetResponse());
                    handler.Send(response);   
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка сервера. Смотри логи...");
                ServerLog.Log($"ОШИБКА: {ex.Message}");
            }
            finally
            {
                // закрываем сокет
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
        }
    }
}
