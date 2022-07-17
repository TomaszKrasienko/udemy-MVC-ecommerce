using eTickets.Data.Cart;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eTickets.Models
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}