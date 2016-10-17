using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static PowerUps Health;
        public static PowerUps Ammo;
        public static void Main(string[] args)
        {
            Health.RunPowerUp();
            Ammo.RunPowerUp();
        }
    }
}
