namespace Comparison{
    class Produto{
        public string Nome{get;set;}
        public double Preco{get;set;}
        public Produto(string Nome,double Preco){
            this.Nome=Nome;
            this.Preco=Preco;
        }
        public override string ToString(){
            return Nome+", "+Preco;
        }
    }
}