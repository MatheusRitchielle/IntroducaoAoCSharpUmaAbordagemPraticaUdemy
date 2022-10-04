using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosInterativos
{
    class Program
    {
        static void Main(string[] args)
        {
            //laços interativos => estruturas que repetem um bloco de código por um determinado numero de vezes
            //Laço for
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor de i é " + i);
            }

            //While 
            int contador = 3;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            // Do .. While
            //Execução garantida pelo menos uma vez(Executa o bloco primeiro e depois faz o teste da condição)
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while ( j < 100);

            // Foreach
            // Percorre todos os elementos do conjunto
            int[] conjunto = { 1, 2, 3, 7};
            foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse elemento conjunto tem valor " + numero + "! Somando esse valor a 10 temos " + (numero + 10));
            
            }

        }
    }
}
