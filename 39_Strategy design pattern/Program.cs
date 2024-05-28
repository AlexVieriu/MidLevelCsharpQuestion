var games = new List<Game>()
{
    new Game("Stardew Valley", 19.99m, 98, new DateTime(2016, 2, 26), true),
    new Game("Spiritfarer", 25m, 85, new DateTime(2020, 8, 18), false),
    new Game("Heroes III", 10m, 100, new DateTime(2000, 7, 7), true)
};

var searchOptions = FilteringType.BestGames;
var searchWord = "Red";

// Example 1
var myClass = new MyClass();
IEnumerable<Game> filteredGames1 = myClass.FindBy(searchOptions, searchWord, games);

foreach (var game in filteredGames1)
{
    Console.WriteLine(game);
}


// Example 2 - Strategy design pattern
Console.WriteLine("\n - - - Example 2 - - -");
var SDP = new StrategyDesignPattern();
var strategy = SDP.SelectStrategy(searchOptions, searchWord);
var filteredGames2 = SDP.FindBy(games, strategy);

foreach (var game in filteredGames2)
{
    Console.WriteLine(game);
}

Console.ReadKey();