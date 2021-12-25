using PizzaHutEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaHutRepository.Interfaces
{

    public interface ICartRepository : IRepository<Cart>
    {
        public Cart GetCart(Guid CartId);
        public int DeleteItem(Guid cartId, int itemId);
        public int UpdateQuantity(Guid cartId, int itemId, int Quantity);
        public int UpdateCart(Guid cartId, int userId);
    }

}
