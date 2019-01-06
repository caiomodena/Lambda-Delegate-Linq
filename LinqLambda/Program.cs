using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqLambda
{
    class Program
    {
        static void Print<T>(string message,IEnumerable<T> collection){
            System.Console.WriteLine(message);
            foreach(T obj in collection){
                System.Console.WriteLine(obj);
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category{Id = 1, Name="Tools", Tier=2};
            Category c2 = new Category{Id = 2, Name="Computers", Tier=1};
            Category c3 = new Category{Id = 3, Name="Eletronics", Tier=1};
            List<Product> products = new List<Product>(){
                new Product(){Id=1,Name="Computer",Price=1100.0,Category=c2},
                new Product(){Id=2,Name="Hammer",Price=90.0,Category=c1},
                new Product(){Id=3,Name="TV",Price=1700.0,Category=c3},
                new Product(){Id=4,Name="Notebook",Price=1300.0,Category=c2},
                new Product(){Id=5,Name="Saw",Price=80.0,Category=c1},
                new Product(){Id=6,Name="Tablet",Price=700.0,Category=c2},
                new Product(){Id=7,Name="Camera",Price=700.0,Category=c3},
                new Product(){Id=8,Name="Printer",Price=350.0,Category=c3},
                new Product(){Id=9,Name="Macbook",Price=1800.0,Category=c2},
                new Product(){Id=10,Name="Sound Bar",Price=700.0,Category=c3},
                new Product(){Id=11,Name="Level",Price=700.0,Category=c1}
            };

            var r1=products.Where(p => p.Category.Tier==1 && p.Price<900);
            Print("Tier 1 and Price<900:",r1);

            var r2=products.Where(p => p.Category.Name=="Tools").Select(p => p.Name);
            Print("Names of products from tools",r2);

            var r3=products.Where(p => p.Name[0]=='C').Select(p => new{p.Name,p.Price,CategoryName = p.Category.Name});
            Print("Names started with 'C' and anonymous object",r3);

            var r4=products.Where(p => p.Category.Tier==1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 order by price then name",r4);

            var r5=r4.Skip(2).Take(4);
            Print("Tier 1 order by price then name skip 2 take 4",r5);

            var r6 = products.Where(p => p.Id==3).SingleOrDefault();
            System.Console.WriteLine("Single or default test1: "+r6);

            var r7=products.Max(p => p.Price);
            System.Console.WriteLine("Max price: "+r7);

            var r8=products.Min(p => p.Price);
            System.Console.WriteLine("Min price: "+r8);

            var r9=products.Where(p=> p.Category.Id==1).Sum(p => p.Price);
            System.Console.WriteLine("Category 1 sum prices: "+r9);
            
            var r10=products.Where(p=> p.Category.Id==1).Average(p => p.Price);
            System.Console.WriteLine("Category 1 average prices: "+r10);

            var r11=products.Where(p=>p.Category.Id==5).Select(p=>p.Price).DefaultIfEmpty(0.0).Average();
            System.Console.WriteLine("Category 5 average prices: "+r11);

            var r12 = products.Where(p => p.Category.Id==1).Select(p => p.Price).Aggregate((x,y)=> x+y);
            System.Console.WriteLine("Category 1 aggregate sum: "+r12);

            var r13 = products.GroupBy(p => p.Category);
            foreach(IGrouping<Category,Product> group in r13){
                System.Console.WriteLine("Category " + group.Key.Name + ":");
                foreach(Product p in group){
                    System.Console.WriteLine(p);
                }
                System.Console.WriteLine();
            }




        }
    }
}
