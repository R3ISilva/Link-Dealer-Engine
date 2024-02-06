namespace Link_Dealer_Engine;

public class BoardAndGit : IActionManager
{
    private readonly IBoard _Board;
    private readonly IGit _Git;

    public BoardAndGit(IBoard board, IGit git)
    {
        _Board = board;
        _Git = git;
    }

    public async Task<bool> Add(Task<IBoardAction> action)
    {
        return _Git.Add(action) && _Board.Add(action);
    }
}