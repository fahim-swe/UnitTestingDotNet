using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_Assignment_01;
using Xunit;

namespace UnitTesting
{
    public class AdminTest
    {

      
        
        [Fact]
        public void AddProductTesting()
        {
            var Admin = new Admin();

            var product = new Products{
                Id = 1,
                Name = "Cycle",
                Group = "abc",
                SubGroup = "abcd"
            };

            int size1 = DataContext.Payments.Count();

            Admin.AddProducts(product);

            int size2 = DataContext.Payments.Count();

            Assert.Equal(size2-size1, DataContext.Products.Count()); 

        }
    }
}