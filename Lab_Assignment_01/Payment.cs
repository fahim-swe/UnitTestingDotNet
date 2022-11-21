using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Lab_Assignment_01
{
    public class Payment
    {
        protected Guid CustomerId {get;set;}
        public string Name {get;set;}
        public string CardType {get;set;}
        public string CardNo {get;set;}
    }
}