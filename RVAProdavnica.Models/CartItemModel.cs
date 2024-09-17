using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double Total
        {
            get { return Quantity * Price; }
        }

        public CartItem()
        {

        }

        public CartItem(ProductModel product)
        {
            ProductId = product.Id;
            ProductName = product.Name;
            Price = product.Price;
            Quantity = 1;
        }


    }
}
