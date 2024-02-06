using Link_Dealer_Engine;

var gameRules = new GameDependencies();

Game game = new(gameRules);

game.Start();
ActionsLogger.Log("Game started");


