using Basket.API.Entities;

namespace Basket.API.Repositories
{
    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string userName);
        Task<ShoppingCart> UpdatetBasket(ShoppingCart basket);
        Task DeleteBasket(string userName);

    }
}
