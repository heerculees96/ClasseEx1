using System;
using System.Globalization;
namespace ClasseEx1
{
    internal class Produto
    {   
       
        public string Nome;
       
        public double Preco;
       
        public int Quantidade;

        public double ValorTotalNoEstoque()
        {
            return Preco * Quantidade;
        }
     
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }  
 //
        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade 
                + " unidades, Total: $ " 
                + ValorTotalNoEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
