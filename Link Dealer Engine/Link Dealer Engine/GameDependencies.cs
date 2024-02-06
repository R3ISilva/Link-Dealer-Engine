using System.ComponentModel.DataAnnotations;

namespace Link_Dealer_Engine;

public class GameDependencies
{
    [Required] public TurnManager TurnManager { get; set; }
    [Required] public Dealer Dealer { get; set; }
    [Required] public IActionManager ActionManager { get; set; }
}