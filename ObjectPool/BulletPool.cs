using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    //kontrollerer livscyklus
    //skjuler oprettelse
    //genbruger objekter

    internal class BulletPool
    {
        private readonly Queue<Bullet> availableBullet = new Queue<Bullet>();

        public BulletPool(int initialSize)
        {
            for (int i = 0; i < initialSize; i++)
            {
                availableBullet.Enqueue(new Bullet());
            }
        }

        public Bullet Get()
        {
            if(availableBullet.Count > 0)
                 return availableBullet.Dequeue();

            Console.WriteLine("Pool empty - creating new bullet");
            return new Bullet();
        }

        public void Return(Bullet bullet)
        {
            bullet.Reset();
            availableBullet.Enqueue(bullet);
        }
    }
}
