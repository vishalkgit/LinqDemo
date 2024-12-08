using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=799,CompanyName="Dell"},
                new Product{Id=2,Name="Mouse",Price=699,CompanyName="Lenovo"},
                new Product{Id=3,Name="Laptop",Price=34799,CompanyName="Dell"},
                new Product{Id=4,Name="Laptop",Price=45799,CompanyName="Sony"},
                new Product{Id=5,Name="Laptop",Price=38799,CompanyName="Lenovo"},
                new Product{Id=6,Name="Keyboard",Price=599,CompanyName="Dell"},
                new Product{Id=7,Name="Keyboard",Price=999,CompanyName="Microsoft"},
                new Product{Id=8,Name="RAM 4GB",Price=2799,CompanyName="Corsair"},
                new Product{Id=9,Name="Speaker",Price=10799,CompanyName="Sony"},
                new Product{Id=10,Name="USB Mouse",Price=1299,CompanyName="Microsoft"},
            };

            //1. Display all products using LINQ query
            //var result= from p in products
            //      select p;


            //foreach(Product item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Display products whose price is greater than 1500
            //var result = from p in products
            //           where p.Price > 1500
            //       orderby p.Price
            //       select p;

            //foreach (Product item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3. Display products whose price is in between 10000 to 40000

            //var result = from p in products
            //             where p.Price > 10000 && p.Price<=40000
            //             orderby p.Price
            //             select p;

            //foreach (Product item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4. Display products of Dell company

            //var result=from p in products
            //           where p.CompanyName.StartsWith("Dell")
            //           select p;


            //foreach (Product item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //5. Display all company laptops

            //var result=from p in products
            //           where p.Name.StartsWith("Laptop")
            //           select p;

            //foreach (Product item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //6. Display products whose company name start with ‘M’

            //var result = from p in products
            //             where p.CompanyName.StartsWith("M")
            //             select p;

            //foreach (Product item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //7. Display all company mouse whose price is less than 1000

            //var result=from p in products
            //           where p.Price<1000 && p.Name=="Mouse"
            //           orderby p.CompanyName
            //           select p;

            //foreach (Product item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //8. Display all products descending order by their price

           
                       
                       

        }
    }
}
