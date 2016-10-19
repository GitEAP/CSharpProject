using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static PowerUps Health;
        public static PowerUps Ammo = new PowerUps();//dotnet build
        public static void Main(string[] args)
        {
            Health = new PowerUps();
            Health.duration = 10;
            Health.RunPowerUp();
            Console.WriteLine(Health.duration);
            Ammo.RunPowerUp();

            Health.RechargePowerUp(20);
            Ammo.RechargePowerUp(300);
        }
    }
}
