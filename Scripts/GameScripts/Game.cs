using System;
public class Game
{
    public static bool canPlay = true;

    public Game()
    {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
        Cave.StartMessage = "You have entered a cave.";
        UnderWater.objects = new string[] { "Sea weed", "Coral", "Fish", "Shark" };
    }
    private string gameState = "Start";
    private GameState.GameStates toEnum;
    public void Play()
    {

        switch (toEnum)
        {
            case GameState.GameStates.Start:
                Console.WriteLine("Please type in your name.");
                name = Console.ReadLine();
                Console.WriteLine("Your player name is: " + name);
                Console.WriteLine("Play commands: Play, End, Help");
                gameState = Console.ReadLine();
                if (Enum.TryParse(gameState, out toEnum))
                {
                    Play();
                }
                break;
            case GameState.GameStates.Died:
                Console.WriteLine("You Died");
                GameState.currentGameState = GameState.GameStates.End;
                Environment.Exit(0);
                break;
            case GameState.GameStates.End:
                Console.WriteLine("Game Over");
                Environment.Exit(0);
                break;
            case GameState.GameStates.Help:
                Console.WriteLine("What do your need help for. If you can't play this game, you have issues.");
                Play();
                break;
            case GameState.GameStates.Play:
                while (Game.canPlay)
                {
                    Cave.Enter();
                    Random randomNum = new Random();
                    Cave.Encounter(randomNum.Next(0, Cave.objects.Length), "walked");
                    GameTimer();
                    Play();
                }
                break;
            default:
                Console.WriteLine("Not a valid command");
                Play();
                break;
        }

    }

    public static void GameTimer()
    {
        System.Threading.Thread.Sleep(5000);
    }

    //Game Levels
    private LevelBase Cave = new CaveLevel();
    public static LevelBase UnderWater = new LevelBase();

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
