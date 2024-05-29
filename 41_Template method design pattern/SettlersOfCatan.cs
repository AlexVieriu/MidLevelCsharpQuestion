using static System.Console;

class SettlersOfCatan : BoardGame
{
    protected override bool PlayTurn()
    {
        WriteLine("Building, trading, etc.");
        return Random.Next(5) >= 4;
    }
    protected override void SelectWinner() => WriteLine("Winner is the one who first got 12 points");

    protected override void SetupBoard() => WriteLine("Randomly placing hexagonal title.");
}