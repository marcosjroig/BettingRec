using SS.Interview.BettingPlatform.MarketGeneration.Models;

namespace SS.Interview.BettingPlatform.SportServices
{
    public interface ISportGeneratorService
    {
        Market[] GetMarkets();
    }
}
