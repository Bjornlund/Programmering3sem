namespace ObserverEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Player player = new Player();
            HealthBar healthBar = new HealthBar();
            SoundSystem soundSystem = new SoundSystem();
            CombatLog log = new CombatLog();

            //Observers subscriber til event
            player.HealthChanged += healthBar.Update;
            player.HealthChanged += soundSystem.PlayHealthSound;
            player.HealthChanged += log.LogHealth;
            player.LevelChanged += log.LevelUp;
            //unsubscribe hvis det er noget der lever længere end objectet

            player.TakeDamage(20);
            player.LevelUp(15);
            Console.WriteLine("\n");
            Console.ReadKey();
            player.Heal(10);
        }
    }
}
