using System;
using System.Collections.Generic;
using System.Globalization;

namespace Fixacao.Lista.Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.Write("Quantos funcionarios serao registrados? ");
            //    int x = int.Parse(Console.ReadLine());

            //    List<Funcionairos> list = new List<Funcionairos>();// instancio a lista chamando a classe funcionairos

            //    for ( int i = 1; i <= x  ; i++)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine($"funcionarios #{i}");
            //        Console.Write("Id: ");
            //        int id = int.Parse(Console.ReadLine());
            //        Console.Write("nome: ");
            //        string nome = Console.ReadLine();
            //        Console.Write("salario:");
            //        double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //        list.Add(new Funcionairos(id,nome,salario)); // adiciono os dados a lista funcionario conforme construtor
            //    }

            //    Console.WriteLine();
            //    Console.Write("Entre com o ID do funcionario que ira receber o aumento: ");
            //    int procuraId = int.Parse(Console.ReadLine());

            //    Funcionairos emp = list.Find(x => x.Id == procuraId); // chamo a classe/ funcionario para encontrar o elemento da lista

            //    if(emp != null)
            //    {
            //        Console.Write("Entre com a porcentagem: ");
            //        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        emp.AumentoSalario(porcentagem);// chamo o metodo de aumento
            //    }
            //    else
            //    {
            //        Console.WriteLine("Esse id não existe! ");
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Lista de funcionarios atualizada:");

            //    foreach ( Funcionairos obj in list) // percorro a lista e mostro ela atualizada
            //    {
            //        Console.WriteLine("==> "+ obj);
            //    }

            //------------------------------------------------------------------------

            //MATRIZ

            //Console.Write("Entre com o valor n da matriz: ");
            //int n = int.Parse(Console.ReadLine());

            //int[,] matriz = new int[n, n];

            //for (int i = 0; i < n; i++)
            //{
            //    string[] valor = Console.ReadLine().Split(' ');// guardo os valores em split (1' '2' '3)
            //    for (int j = 0; j < n; j++)
            //    {
            //        matriz[i, j] = int.Parse(valor[j]); // converto o split string para int 
            //    }
            //}

            //Console.WriteLine("Diagonal principal: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(matriz[i, i] + " ");  // procuro os valores nas linhas i,i
            //}
            //Console.WriteLine();

            //int negativo = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if(matriz[i,j] < 0) // comando para descubrir os valores negativos da matriz
            //        {
            //            negativo++;

            //        }
            //    }
            //}
            //Console.WriteLine("numeros negativo: "+ negativo );

            //---------------------------------------------------------------------------

            // Matriz

            //Console.WriteLine("Entre com o valor de m e n na matriz");
            //string[] linha = Console.ReadLine().Split(' ');
            //int m = int.Parse(linha[0]);
            //int n = int.Parse(linha[1]);

            //int[,] matriz = new int[m, n];

            //for(int i = 0; i < m; i++)
            //{
            //    string[] valor = Console.ReadLine().Split(' ');
            //    for(int j = 0; j < n; j++)
            //    {
            //        matriz[i, j] = int.Parse(valor[j]);
            //    }
            //}

            //Console.Write("Entre com o numero que esta na matriz: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if(matriz[i,j] == x)
            //        {
            //            Console.WriteLine("Posiçao: "+ i + ","+ j);

            //            if (j > 0)
            //            {
            //                Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
            //            }
            //            if (i > 0)
            //            {
            //                Console.WriteLine("Cima: " + matriz[i - 1, j]);
            //            }
            //            if (j < n - 1)
            //            {
            //                Console.WriteLine("Direita: " + matriz[i, j + 1]);
            //            }
            //            if (i < m - 1)
            //            {
            //                Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
            //            }
            //        }
            //    }
            //}
        }
    }
}
