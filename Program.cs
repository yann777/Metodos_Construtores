using System;
using EX2.classes;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Codigo = 51; 
            produto.Nome = "Coca-Cola"; 
            produto.Descricao = "Refrigerante sabor Cola";
            
            Console.WriteLine($"Código do produto: {produto.Codigo} - Nome do Produto: {produto.Nome} - Descrição do produto: {produto.Descricao}");

            Produto produto2 = new Produto(0001);
            Console.WriteLine($"Código do Produto: {produto2.Codigo}");

            Produto produto3 = new Produto(0001,"Tomate","Tomate cereja 200g",5000);

            Console.WriteLine($"Código do produto: {produto3.Codigo} - Nome do produto: {produto3.Nome} - Descrição do produto: {produto3.Descricao} - Estoque do produto: {produto3.Estoque}");

                
            
        }
    }
}
