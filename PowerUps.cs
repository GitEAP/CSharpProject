using System;

public class PowerUps {
    public int power = 10;
    public float duration = 2;
    public void RunPowerUp() {
        Console.WriteLine("PowerUps Ran");
    }
    public void RechargePowerUp(int _power) {
        power += _power;
        Console.WriteLine("Recharge PowerUps to " + power);
    }
}