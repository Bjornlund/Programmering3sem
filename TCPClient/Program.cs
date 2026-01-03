using System.Net.Sockets;
using System.Text;

namespace TCPClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartClient();
        }

        static void StartClient()
        {
            TcpClient client = new TcpClient();
            client.Connect("localhost", 12000); //127.0.0.1 er også localhost

            Console.WriteLine("Connected to server on port 12000");

            using StreamReader reader = new StreamReader(client.GetStream());
            using StreamWriter writer = new StreamWriter(client.GetStream()) // ikke trådsikker, derfor har hver klient egen streamwriter //alternativ: byte[] data = Encoding.UTF8.GetBytes(message + "\n"); client.GetStream().Write(data, 0, data.Length);
            {
                AutoFlush = true
            };

            while (true)
            {
                //bruger input
                string message = Console.ReadLine();

                if (message == null)
                    break;

                //Send besked til server
                writer.WriteLine(message);

                //venter svar fra server
                string response = reader.ReadLine();
                Console.WriteLine("Server: " + response);

                if (message.ToLower() == "quit")
                    break;
            }

            client.Close();
            Console.WriteLine("Disconnected freom server");

        }


    }
}
