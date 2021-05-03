using SS.Interview.BettingPlatform.MarketGeneration.Generators;
using SS.Interview.BettingPlatform.MarketGeneration.Models;

namespace SS.Interview.BettingPlatform.SportServices
{
    public class FootballGeneratorService: ISportGeneratorService
    {
        private readonly FootballMarketGenerator _footballMarketGenerator;
        private readonly string _fixture;
        public FootballGeneratorService(FootballMarketGenerator footballMarketGenerator, string fixture)
        {
            _footballMarketGenerator = footballMarketGenerator;
            _fixture = fixture;
        }
        public Market[] GetMarkets()
        {
           return _footballMarketGenerator.GetMarkets(_fixture);
        }
    }
}
