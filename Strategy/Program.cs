namespace Strategy
{
    //Strategy: IAttackStrategy
    //ConcreteStrategy: Melee, Ranged

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(new MeleeAttack());
            player.Attack();

            Console.WriteLine("player picks up bow");
            player.SetStrategy(new RangedAttack());
            player.Attack();

            Console.ReadKey();


        }
    }
}
