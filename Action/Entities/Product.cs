namespace Action{
    class Product{
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string Name,double Price){
            this.Name=Name;
            this.Price=Price;
        }
        public override string ToString(){
            return Name + ", " + Price.ToString("F2");
        }
    }
}