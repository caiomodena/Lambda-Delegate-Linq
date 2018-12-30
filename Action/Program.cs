using System;
using System.Collections.Generic;
namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv",900.00));
            list.Add(new Product("Mouse",50.00));
            list.Add(new Product("Tablet",350.50));
            list.Add(new Product("HD Case",80.90)); 

            Action<Product> act = updatePrice;

            list.ForEach(act);
            //ou list.ForEach(updatePrice);
            
            foreach(Product p in list){
                Console.WriteLine(p);
            }
                
        }
        static void updatePrice(Product p){
            p.Price+=p.Price*0.1;
        }
    }
}
