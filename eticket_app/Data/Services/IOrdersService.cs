using eticket_app.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eticket_app.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string uerRole);
    }
}
