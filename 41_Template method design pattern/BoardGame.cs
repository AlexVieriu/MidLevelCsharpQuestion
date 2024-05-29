public abstract class BoardGame
{
    protected Random Random = new Random();
    public void Play()
    {
        SetupBoard();
        bool isFinished = false;

        while (!isFinished)
            isFinished = PlayTurn();

        SelectWinner();
    }

    protected abstract void SetupBoard();
    protected abstract bool PlayTurn();
    protected abstract void SelectWinner();
}
