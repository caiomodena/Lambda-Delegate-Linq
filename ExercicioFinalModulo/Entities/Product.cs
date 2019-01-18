using System;
namespace ExercicioFinalModulo{
    class Product{
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string Name,double Price)
        {
            this.Name=Name;
            this.Price=Price;
        }
    }
}