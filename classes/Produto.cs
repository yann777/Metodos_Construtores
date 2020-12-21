using System;

namespace EX2.classes
{
    public class Produto
    {
        public int Codigo{get;set;}
        public string Nome{get;set;}
        public string Descricao{get;set;}
        public int Estoque{get;set;}

        public Produto(){
            Console.WriteLine("Metodo construtor foi executado");
        }
        public Produto(int valor){
            Codigo = valor;
            Console.WriteLine($"Código inserido foi {Codigo}");
        }
        public Produto(int valor,string nome,string descricao,int estoque){
            Codigo = valor
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;
        }
    }
}