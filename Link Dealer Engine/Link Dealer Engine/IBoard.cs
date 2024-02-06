
namespace Link_Dealer_Engine;

public interface IBoard
{
    bool Add(Task<IBoardAction> startup);
}