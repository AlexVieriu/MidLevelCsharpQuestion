public class NO_StrategyDesignPattern
{
    internal IEnumerable<Game> FindBy(FilteringType searchOptions, string searchWord, IEnumerable<Game> games = null)
    {
        switch (searchOptions)
        {
            case FilteringType.ByTitle:
                return FindByTitle(games, searchWord);
            case FilteringType.BestGames:
                return FindByBestGames(games);                
            case FilteringType.ByYear:
                return FindByGamesByYear(games);
            case FilteringType.LowerPrice:
                return FindByLowerPrice(games);                
            default:
                throw new ArgumentException("Invalid option.");
        }
    }

    internal IEnumerable<Game> FindByTitle(IEnumerable<Game> games, string searchWord)
    {
        return games.Where(g => g.IsAvailable && g.Title == searchWord);
    }
    internal IEnumerable<Game> FindByBestGames(IEnumerable<Game> games)
    {
        return games.Where(g => g.IsAvailable && g.Rating > 95);
    }
    internal IEnumerable<Game> FindByGamesByYear(IEnumerable<Game> games)
    {
        return games.Where(g => g.IsAvailable && g.ReleaseDate.Year == DateTime.Now.Year);
    }
    internal IEnumerable<Game> FindByLowerPrice(IEnumerable<Game> games)
    {
        return games.Where(g => g.IsAvailable && g.Price < 10m);
    }
}



