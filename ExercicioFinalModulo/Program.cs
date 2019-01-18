using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExercicioFinalModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Caminho do arquivo: ");
            string path = System.Console.ReadLine();

            List<Product> list = new List<Product>();

            using(StreamReader sr = File.OpenText(path)){
                while(!sr.EndOfStream()){
                    string[] fields = sr.ReadLine().Split(',');
                    string name=fields[0];
                    double price = double.Parse(fields[1]);
                    list.Add(new Product(name,price));


                }
            }
            var avg = list.Select(p=>p.Price).DefaultIfEmpty(0.0).Average();
            System.Console.WriteLine("Average price: "+avg.ToString());

            var names=list.Where(p => p.Price<avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach(string name in names){
                System.Console.WriteLine(name);
            }
        }
    }
}
