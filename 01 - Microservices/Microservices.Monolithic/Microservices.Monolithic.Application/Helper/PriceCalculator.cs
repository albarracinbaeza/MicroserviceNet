using Microservices.Monolithic.Application.Models;

namespace Microservices.Monolithic.Application.Helper
{
    public static class PriceCalculator
    {
        public static int GetPrice(Order order)
        {
            return order.Weight < 10 ? 6 : 10;
        }
    }
}
