namespace ObjectPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BulletPool pool = new BulletPool(2);

            Bullet b1 = pool.Get();
            b1.Fire();

            Bullet b2 = pool.Get();
            b2.Fire();

            Bullet b3 = pool.Get(); // pool tom → new Bullet()
            b3.Fire();

            pool.Return(b1);
            pool.Return(b2);

            Bullet b4 = pool.Get(); // genbrug
            b4.Fire();

            Console.ReadKey();
        }
    }
}
