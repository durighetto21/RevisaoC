using RevisaoVStudio.Classes;
using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace RevisaoVStudio
{
    class Program
    {
        protected static int GetPercentile(Produto s)
        {
            double avg = s.CustoMedio.Average();
            return avg > 0 ? (int)avg : 0;
        }
        static void Main(string[] args)
        {
            Produto produtosObj = new Produto();
            Student estudantesObj = new Student();
            

            var produtosTop = produtosObj.Listar();
            var students = estudantesObj.ListarEstudantes();
            


            #region Exemplos GroupBy

            #region GroupBy Simples
            //var ProdCat = from prod in produtos
            //              group prod by prod.Categoria into GrupoCat
            //              select GrupoCat;

            //foreach  (var cat in ProdCat)
            //{
            //    Console.WriteLine($"Categoria: {cat.Key}");
            //    foreach (var item in cat)
            //    {
            //        Console.WriteLine($" Produto: {item.Nome}");
            //    }
            //} 
            #endregion

            #region Exemplo GroupBy let e atributo anônimo
            //var queryNumericRange = from produto in produtos
            //                        let percentile = GetPercentile(produto)
            //                        group new { produto.Nome, produto.Valor } by percentile into percentGroup
            //                        orderby percentGroup.Key
            //                        select percentGroup;

            //foreach (var grupoProduto in queryNumericRange)
            //{
            //    Console.WriteLine($"Key: {grupoProduto.Key}");
            //    foreach (var item in grupoProduto.OrderBy(x => x.Nome))
            //    {
            //        Console.WriteLine($"\t{item.Nome}, {item.Valor}");
            //    }
            //}
            #endregion

            #region Exemplo tipo anônimo na chave do GroupBy

            //var queryProdutos = from prod in produtos
            //                    group prod by new { Nome = prod.Nome[0], Valor = prod.Valor > 5, Categoria = prod.Categoria } into GroupProd
            //                    orderby GroupProd.Key.Nome
            //                    orderby GroupProd.Key.Categoria
            //                    select GroupProd;

            //foreach (var grupo in queryProdutos)
            //{
            //    string s = grupo.Key.Valor == true ? "Maior do que" : "Menor do que ";

            //    Console.WriteLine($"Produtos começados com a letra {grupo.Key.Nome} com valor {s} 5: ");
            //    foreach (var item in grupo)
            //    {
            //        Console.WriteLine($"\t{item.Nome}");
            //    }

            //}
            #endregion

            #endregion


            #region Exemplo Consulta Aninhada
            //Separar produtos por categoria e agrupar por letra inicial, ordenando os dados por ordem alfabética.

            //var queryCat = from produto in produtos
            //               group produto by produto.Categoria into Grupo1
            //               from Grupo2 in
            //                   (from prod in Grupo1
            //                    group prod by prod.Nome[0]
            //                    ).OrderBy(x => x.Key)
            //               group Grupo2 by Grupo1.Key;

            //foreach (var cat in queryCat.OrderBy(x => x.Key))
            //{
            //    Console.WriteLine($"Categoria: { cat.Key}");
            //    foreach (var letra in cat)
            //    {
            //        Console.WriteLine($"\tProdutos começados com a letra {letra.Key}:");
            //        foreach (var prod in letra)
            //        {
            //            Console.WriteLine($"\t\t {prod.Nome} , R${prod.Valor}");
            //        }

            //    }

            //} 
            #endregion


            #region Exemplo Subconsulta em Agrupamento
            //var queryGroupMax = from student in students
            //                    group student by student.Year into studentGroup
            //                    orderby studentGroup.Key
            //                   select new
            //                   {
            //                       Level = studentGroup.Key,
            //                       HighestScore =
            //                       (from student2 in studentGroup
            //                        select student2.ExamScores.Average()).Max()
            //                   };

            //int count = queryGroupMax.Count();
            //Console.WriteLine($"Number of groups = {count}");

            //foreach (var item in queryGroupMax)
            //{
            //    Console.WriteLine($"  {item.Level} Highest Score={item.HighestScore}");
            //}

            //// ---------------- Mesma consulta a cima escrita com lambda ----------------------------

            //var queryGroupMaxLambda = students
            //                          .GroupBy(student => student.Year)
            //                          .Select(GroupStudents => new
            //                          {
            //                              Level = GroupStudents.Key,
            //                              HighestScore = GroupStudents.Select(student2 => student2.ExamScores.Average()).Max()

            //                          });

            //int count = queryGroupMax.Count();
            //Console.WriteLine($"Number of groups = {count}");

            //foreach (var item in queryGroupMax)
            //{
            //    Console.WriteLine($"  {item.Level} Highest Score={item.HighestScore}");
            //} 
            #endregion




            Console.ReadKey();
        }
    }
}
