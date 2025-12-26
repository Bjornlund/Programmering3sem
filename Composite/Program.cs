namespace Composite
{

    //leaf: Buttons, Labels
    //Composite: Panel, af buttons
    //Component: Interface

    internal class Program //client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //leaf
            Button startButton = new Button("Start");
            Button exitButton = new Button("Exit");
            Button continueButton = new Button("Continue");
            Label title  = new Label("Main Menu");

            //Composite
            Panel mainMenu = new Panel();
            Panel subMenu = new Panel();
            //Tilføjer component til composite
            mainMenu.Add(title);
            mainMenu.Add(subMenu); 
            //Tilføjer leaf til composite
            mainMenu.Add(startButton);
            mainMenu.Add(exitButton);
            mainMenu.Add(continueButton);

            //Tegn det hele, her tegnes både leaf og composite = behandles ens
            mainMenu.Draw();

            Console.ReadKey();


        }
    }
}
