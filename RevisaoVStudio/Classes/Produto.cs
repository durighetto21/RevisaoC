using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoVStudio.Classes
{
    class Produto
    {
        private List<Produto> produtos;
        public string Nome { get; set; }
        public string Categoria { get; set; }

        public double Valor { get; set; }
        public List<int> CustoMedio;
        public Produto()
        {
            produtos = new List<Produto>();
        }

        public List<Produto> Listar()
        {
            produtos.Add(new Produto() { Nome = "Maça", Categoria = "Fruta", Valor = 10, CustoMedio = new List<int>{ 7, 8, 3, 10 } });
            produtos.Add(new Produto() { Nome = "Pera", Categoria = "Fruta", Valor = 10, CustoMedio = new List<int> { 1, 2, 3, 4 } });
            produtos.Add(new Produto() { Nome = "Caju", Categoria = "Fruta", Valor = 10, CustoMedio = new List<int> { 1, 2, 3, 4 } });
            produtos.Add(new Produto() { Nome = "Banana", Categoria = "Fruta", Valor = 10, CustoMedio = new List<int> { 1, 2, 3, 4 } });
            produtos.Add(new Produto() { Nome = "Melância", Categoria = "Fruta", Valor = 10, CustoMedio = new List<int> { 1, 2, 3, 4 } });
            produtos.Add(new Produto() { Nome = "Patinho", Categoria = "Carne", Valor = 10, CustoMedio = new List<int> { 1, 2, 3, 4 } });
            produtos.Add(new Produto() { Nome = "Alcatra", Categoria = "Carne", Valor = 10, CustoMedio = new List<int> { 1, 2, 3, 4 } });
            produtos.Add(new Produto() { Nome = "Picanha", Categoria = "Carne", Valor = 10, CustoMedio = new List<int> { 1, 2, 3, 4 } });
            produtos.Add(new Produto() { Nome = "Fraldinha", Categoria = "Carne", Valor = 10, CustoMedio = new List<int> { 1, 2, 3, 4 } });
            produtos.Add(new Produto() { Nome = "Acem", Categoria = "Carne", Valor = 10, CustoMedio = new List<int> { 1, 2, 3, 4 } });
            produtos.Add(new Produto() { Nome = "Arroz", Categoria = "Alimento", Valor = 5, CustoMedio = new List<int> { 1, 2, 3, 4 } });
            produtos.Add(new Produto() { Nome = "Feijão", Categoria = "Alimento", Valor = 5, CustoMedio = new List<int> { 1, 2, 3, 4 } });

            return produtos;
        }
    }
}
