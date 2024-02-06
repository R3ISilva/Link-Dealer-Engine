namespace Link_Dealer_Engine;

public interface IActionManager
{
    public Task<bool> Add(Task<IBoardAction> action);
}