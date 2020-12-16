using System;
using System.Collections.Generic;
using AulaListaDeObjetos.Classes;

namespace AulaListaDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(21, "Aplle Watch", 4.887f));
            produtos.Add(new Produto(45, "Xiomi", 2.299f));
            produtos.Add(new Produto(3, "Samsung S10", 3.445f));
            produtos.Add(new Produto(123, "Motorola E6s", 899f));
            produtos.Add(new Produto(7, "ZENFONE, Asus", 3.245f));

            foreach (Produto visualizar in produtos)
            {
                Console.WriteLine($"Código do produto: {visualizar.Codigo}, Nome do produto: {visualizar.Nome}, Preço do produto: {visualizar.Preco}");
                
            }
            
            Produto pro = new Produto();
            pro.Nome = "Positivo";
            pro.Preco = 2.229f;
            pro.Codigo = 0001;

            produtos.Add(pro);

            foreach (Produto item in produtos)
            {
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Codigo);
            }

            produtos.RemoveAll(x => x.Nome == "Xiomi");

            Console.WriteLine("Por falta de estoque, o celular Xiomi foi removido da nossa loja");

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome}");
            }


        }
    }
}
