using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_Assignment_01
{
    public static class DataContext
    {
        public static IList<Products> Products = new List<Products>();
       

        public static Dictionary<Guid, Cart> Carts = new Dictionary<Guid, Cart>();
        public static IList<Payment> Payments = new List<Payment>();
    }
}