using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class GameSettings
    {
        //Simpel udgave uden threadsaftety
        //public static GameSettings Instance { get; } = new GameSettings();

        //Her gemmes den oprettede instans i
        private static GameSettings gameSettingsInstance;

        //Lås for threadsafety - ellers kan man risikere at oprette flere instanser ved flere tråde?
        private static readonly object lockObject = new object();

        public string Difficulty {  get; set; }
        public bool SoundEnabled { get; set; }

        //private constructor
        private GameSettings() 
        {
            Difficulty = "Normal";
            SoundEnabled = true;
        }

        public static GameSettings Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (gameSettingsInstance == null)
                    {
                        gameSettingsInstance = new GameSettings();
                    }

                    return gameSettingsInstance;
                }
            }

        }

        public void Print()
        {
            Console.WriteLine($"Difficulty{Difficulty}, Sound {SoundEnabled}");
        }
    }
}
