using DataApi.Model;

namespace DataApi.Core
{
    public class OrderBookingManager
    {
        public string Send(Trade trade)
        {
            // 1. Book the trade .. some business logic happens here

            // 2. Response : the booking result
            return trade.ToString();
        }
    }
}
