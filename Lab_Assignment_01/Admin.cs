using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_Assignment_01
{
    public class Admin
    {
        private int Id {get;set;}
        private string Name{get;set;}
        

        public void ViewProducts()
        {
            var products = DataContext.Products;
            foreach(var product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.SubGroup);
                Console.WriteLine(product.Group);
            }
        }

        public void AddProducts(Products products)
        {
            DataContext.Products.Add(products);

            
        }


        public void DeleteProducts(int id)
        {
            DataContext.Products.RemoveAt(id);
        }


        public void ModifyProducts(int id, Products products)
        {
            DataContext.Products[id] = products;
        }

        public void MakeShipment()
        {
            throw new NotImplementedException();
        }

        public void ConfirmDelivery()
        {
            throw new NotImplementedException();
        }
    }
}