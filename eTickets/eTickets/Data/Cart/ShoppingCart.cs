using System.Collections.Generic;
using System.Linq;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Cart
{
    public class ShoppingCart
    {
        private readonly AppDbContext _context;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _context.ShoppingCartItems
                .Where(x => x.ShoppingCartId == ShoppingCartId)
                .Include(x => x.Movie)
                .ToList());
        }

        public double GetShoppingCartTotal() => _context.ShoppingCartItems
            .Where(x => 
                x.ShoppingCartId == ShoppingCartId)
            .Select(x => 
                x.Movie.Price * x.Amount)
            .Sum();
    }
}