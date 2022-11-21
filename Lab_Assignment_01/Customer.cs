using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_Assignment_01
{
    public class Customer
    {
        private Guid Id {get;set;}
        
        protected string Name{get;set;}
        protected string Address {get;set;}
        public string PhNo {get;set;}

        public void BuyProducts()
        {
            var Price = DataContext.Carts[Id].Price;
        }

        public void ViewProducts()
        {
            foreach(var product in DataContext.Products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.SubGroup);
                Console.WriteLine(product.Group);
            }
        }

        public void MakePayment()
        {
            throw new NotImplementedException();
        }

        public void AddToCart(Products products)
        {
           DataContext.Carts[Id].Products.Add(products);
        }

        public void DeleteFromCart(int productId)
        {
            var itemToRemove = DataContext.Carts[Id].Products.SingleOrDefault(x => x.Id == productId);
            DataContext.Carts[Id].Products.Remove(itemToRemove);
        }
    }
}