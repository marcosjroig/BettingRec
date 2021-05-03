using System;
using SS.Interview.BettingPlatform.Factory;
using SS.Interview.BettingPlatform.MarketGeneration.Generators;
using SS.Interview.BettingPlatform.MarketGeneration.Models;
using SS.Interview.BettingPlatform.Requests;

namespace SS.Interview.BettingPlatform.Managers
{
    public class MarketManager
    {
        private readonly FootballMarketGenerator _footballGenerator;
        private readonly TennisMarketGenerator _tennisGenerator;
        public MarketManager(TennisMarketGenerator tennisMarketGenerator, FootballMarketGenerator footballMarketGenerator)
        {
            _footballGenerator = footballMarketGenerator;
            _tennisGenerator = tennisMarketGenerator;
        }
        public Market[] Get(MarketRequest request)
        {
            switch (request.Sport)
            {
                case "FOOTBALL":
                    var footballGeneratorService = SportServiceFactory.GetFootballService(_footballGenerator, request.Fixture);
                    return footballGeneratorService.GetMarkets();
                case "tennis":
                    var tennisGeneratorService = SportServiceFactory.GetTennisService(_tennisGenerator, request.Fixture);
                    return tennisGeneratorService.GetMarkets();
                default:
                    throw new Exception();
            }
        }
    }
}