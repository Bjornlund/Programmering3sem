namespace LazyLoadingT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spil starter");

            Player player = new Player();

            Console.WriteLine("Player oprettet");
            Console.WriteLine("Inventory er endnu ikke brugt");

            Console.WriteLine("\nTrykker ENTER for at åbne inventory");
            Console.ReadKey();

            player.Inventory.Show();

            Console.WriteLine("\nTrykker ENTER for at åbne inventory igen");
            Console.ReadKey();

            player.Inventory.Show();

            Console.ReadKey();

        }
    }
}
