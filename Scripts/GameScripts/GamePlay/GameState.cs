public class GameState {
    public enum GameStates {
        Start,
        Play,
        Walk,
        Fight,
        Help,
        End   
    }
    
    public static GameStates currentGameState = GameStates.Start;
}