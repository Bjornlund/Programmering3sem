namespace Builder
{
    internal class Program
    {
        //Obs ingen brug af director
        //Klienten fungerer som Director. Fluent Builder gør en separat Director overflødig.
        static void Main(string[] args)
        {
            Character knight = new Character.Builder()
                .SetName("Knight")
                .SetHealth(150)
                .SetArmor(50)
                .SetWeapon("Sword")
                .Build();

            Character mage = new Character.Builder()
                .SetName("Mage")
                .SetHealth(80)
                .SetWeapon("Staff")
                .EnableMagic()
                .Build();

            knight.Print();
            mage.Print();

            Console.ReadKey();
        }
    }
}
