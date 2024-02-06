namespace Link_Dealer_Engine;

public class Game
{
    private readonly TurnManager _TurnManager;
    private readonly Dealer _Dealer;
    private readonly IActionManager _ActionManager;
    
    private bool _StillPlaying = true;
    public Game(GameDependencies gameDependencies)
    {
        _TurnManager = gameDependencies.TurnManager;
        _Dealer = gameDependencies.Dealer;
        _ActionManager = gameDependencies.ActionManager;
    }
    
    public async void Start()
    {
        var startup = _Dealer.Startup();
        await _ActionManager.Add(startup);
        
        while (_StillPlaying)
        {
            _TurnManager.StartTurn();
            
            
            _TurnManager.NextTurn();
            
        }
    }

}

public class TurnManager
{
    public void NextTurn()
    {
    }

    public void StartTurn()
    {
        //make request to client
    }
}