namespace Command
{

    //Command bruges til undo/redo
    //Mange forskellige handlinger
    //Menu/knap commands
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Client client = new Client();
            client.Run();

            Console.WriteLine("\nTryk på en tast for at afslutte");
            Console.ReadKey();
        }
    }
}
