using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServer
{
    //TCP 1 tråd per klient
    //Tager imod alle klienter på port 12000
    //Echo string med suffix "From server"
    //Stanard TCP

    internal class Program
    {
        static void Main(string[] args)
        {
            StartServer();
        }

        static void StartServer()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 12000); //Kan kun tilgås fra egen maskine(sikkert, stabilt), ellers IPAddress.Any fra alle maskiner
            server.Start();

            Console.WriteLine("Server started on port 12000");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                new Thread(() => HandleClient(client)).Start();
            }

            
        }

        static void HandleClient(TcpClient client)
        {
            //tildeker klient id
            Guid clientID = Guid.NewGuid();
            Console.WriteLine($"Client {clientID} connected");

            using StreamReader reader = new StreamReader(client.GetStream());
            using StreamWriter writer = new StreamWriter(client.GetStream())
            {
                AutoFlush = true
            };

            try
            {
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Received message from {clientID}: {message}");
                    writer.WriteLine(message + " -From server");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception ocurrured for client {clientID}:{ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Client disconnected: {clientID}");
                client.Dispose();
            }
        }
    }
}
