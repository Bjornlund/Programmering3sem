namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.PressPause();
            game.PressStart();
            game.PressPause();
            game.PressStart();

            Console.ReadKey();
        }
    }
}
