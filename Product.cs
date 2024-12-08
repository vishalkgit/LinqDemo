using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Product
    {
        public int Id;

        public string Name;

        public int Price;

        public string CompanyName;

        public override string ToString()
        {
            return($"id is :{Id}, Name is{Name},Price is {Price},CompanyName is {CompanyName}");
        }
    }
}
