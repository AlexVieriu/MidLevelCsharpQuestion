class StrategyDesignPattern
{
    internal Func<Game, bool> SelectStrategy(FilteringType filteringType, string searchWord)
    {
        switch (filteringType)
        {
            case FilteringType.ByTitle:
                return game => game.Title.Contains(searchWord);
            case FilteringType.BestGames:
                return game => game.Rating > 95;
            case FilteringType.ByYear:
                return game => game.ReleaseDate.Year == DateTime.Now.Year;
            case FilteringType.LowerPrice:
                return game => game.Price < 15;
            default:
                throw new ArgumentException("Invalid option.");
        }
    }

    internal IEnumerable<Game> FindBy(IEnumerable<Game> games, Func<Game, bool> strategy)
    {
        return games.Where(g => g.IsAvailable || strategy(g));
    }
}


