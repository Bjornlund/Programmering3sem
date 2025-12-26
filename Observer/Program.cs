namespace Observer
{

    //Simpelt observer pattern med ét interface der tager et parametre -> i praksis ville man nok bruge events eller ét generisk observer interface + player-event
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            HealthPoint healthPoint = new HealthPoint();
            CombatLog log = new CombatLog();

            player.Attach(log);
            player.Attach(healthPoint);

            player.TakeDamage(10);
            player.TakeDamage(25);
            player.Heal(300);

        }
    }
}
