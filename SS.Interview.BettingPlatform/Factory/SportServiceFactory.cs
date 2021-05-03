using SS.Interview.BettingPlatform.MarketGeneration.Generators;
using SS.Interview.BettingPlatform.SportServices;

namespace SS.Interview.BettingPlatform.Factory
{
    public static class SportServiceFactory
    {
        public static FootballGeneratorService GetFootballService(FootballMarketGenerator footballMarketGenerator, string fixture)
        {
            return new FootballGeneratorService(footballMarketGenerator, fixture);
        }

        public static TennisGeneratorService GetTennisService(TennisMarketGenerator tennisMarketGenerator, string fixture)
        {
            return new TennisGeneratorService(tennisMarketGenerator, fixture);
        }
    }
}
