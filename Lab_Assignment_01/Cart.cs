using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_Assignment_01
{
    public class Cart
    {
        public Cart(int Id)
        {
            this.Id = Id;
        }
        private int Id{get;set;}
        public int NumberOfProducts {get;set;} 
        
        public IList<Products> Products {get;set;}

        public float Price {get;set;}
        public float Total {get;set;}
    }
}