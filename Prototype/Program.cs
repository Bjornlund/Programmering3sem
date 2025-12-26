namespace Prototype
{
    //Prototype: IEnemyPrototype
    //ConcretePrototype: Enemy
    //Client: Program
    //Shallow copies pga. det blot indebærer værdityper for enemy kopieres

    internal class Program
    {
        static void Main(string[] args)
        {
            //Prototype
            Enemy archerPrototype = new Enemy("Archer", 100, 10);

            //Kloner
            Enemy archer1 = (Enemy)archerPrototype.Clone();
            Enemy archer2 = (Enemy)archerPrototype.Clone();

            archer2.Health = 150; //Variation
            archer2.Type = "Warrior"; //Variation

            archerPrototype.Print(); //original
            archer1.Print();
            archer2.Print();

            Console.ReadKey();
        }
    }
}
