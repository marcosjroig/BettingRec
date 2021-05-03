using SS.Interview.BettingPlatform.MarketGeneration.Generators;
using SS.Interview.BettingPlatform.MarketGeneration.Models;

namespace SS.Interview.BettingPlatform.SportServices
{
    public class TennisGeneratorService : ISportGeneratorService
    {
        private readonly TennisMarketGenerator _tennisMarketGenerator;
        private readonly string _fixture;
        public TennisGeneratorService(TennisMarketGenerator tennisMarketGenerator, string fixture)
        {
            _tennisMarketGenerator = tennisMarketGenerator;
            _fixture = fixture;
        }

        public Market[] GetMarkets()
        {
            var tennisMarkets = _tennisMarketGenerator.GetMarkets(_fixture);
            return TennisFilterService.GetMarkets(tennisMarkets);
        }
    }
}
