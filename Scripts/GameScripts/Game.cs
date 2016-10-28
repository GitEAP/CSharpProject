using System;
public class Game
{

    public Game()
    {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
        Cave.StartMessage = "You have entered a cave.";
    }
    //Runs at the start of the game
    public void Start()
    {
        Console.WriteLine("Please type in your name.");
        name = Console.ReadLine();
        Console.WriteLine("Your player name is: " + name);
        while(Program.canPlay) {
            System.Threading.Thread.Sleep(5000);
            Walk();
        }
    }
    
    private void Walk() {
        Random randomNum = new Random();
        Cave.Enter();
        Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
    }

    //Game Levels
    private LevelBase Cave = new LevelBase();

    //Game PowerUps
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();


    //Game Weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();

    public string name;
    private int score;

}

/*
After prompt the game for a name we:
Enter a cave
Find Health.
Meet a dragon. (need an enemy class)
Pick weapon.
Battle Dragon. (Battle class)
If we wins: get health and ammo
If we dragon: lose Health.
*/
