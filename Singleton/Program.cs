namespace Singleton
{

    //Singleton: Gamesettings
    //Client: program


    internal class Program
    {
        static void Main(string[] args)
        {

            GameSettings settings1 = GameSettings.Instance;
            GameSettings settings2 = GameSettings.Instance;

            settings1.Difficulty = "Hard";
            settings2.SoundEnabled = false;


            //Viser det samme, da det er værdier for samme instans(singleton) der påvirkes
            settings1.Print();
            settings2.Print();

            Console.ReadKey();
        }
    }
}
