using System.Collections.Generic;
using System.Linq;
using SS.Interview.BettingPlatform.MarketGeneration.Models;

namespace SS.Interview.BettingPlatform.SportServices
{
    public static class TennisFilterService
    {
        public static Market[] GetMarkets(ISet<Market> tennisMarkets)
        {
            var markets = new Market[tennisMarkets.Count];

            for (var i = 0; i < tennisMarkets.Count; i++)
            {
                markets[i] = tennisMarkets.Skip(i).Take(1).First();
            }

            return markets;
        }
    }
}
