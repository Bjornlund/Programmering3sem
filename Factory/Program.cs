namespace Factory
{
    //Product: Enemy
    //ConcreteProduct: Archer, mage
    //Factory: EnemyFactory

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IEnemy enemy1 = EnemyFactory.CreateEnemy("Archer");
            IEnemy enemy2 = EnemyFactory.CreateEnemy("Mage");

            enemy1.Attack();
            enemy2.Attack();

            Console.ReadKey();
        }
    }
}
