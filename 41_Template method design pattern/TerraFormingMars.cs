using static System.Console;

class TerraFormingMars : BoardGame
{
    protected override bool PlayTurn()
    {
        WriteLine("Raising oxygen level, placing oceans, etc.");
        return Random.Next(5) >= 4;
    }
    protected override void SelectWinner() => WriteLine("Winner is the one with most point's at the game's end");

    protected override void SetupBoard() => WriteLine("Choosing from two available maps");
}
