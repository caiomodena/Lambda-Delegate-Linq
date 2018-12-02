using System;
using System.Collections.Generic;
namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            lista.Add(new Produto("TV",1000));   
            lista.Add(new Produto("Notebook",1000.43));   
            lista.Add(new Produto("Tablet",2700));

            lista.Sort(comparaProdutos);

            foreach(Produto prod in lista){
                System.Console.WriteLine(prod); 
            }   
        }
        static int comparaProdutos(Produto p1,Produto p2){
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        }
    }
}
