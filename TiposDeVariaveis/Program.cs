using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = 20;
            var soma = numero1 + numero2; //Var define dinâmicamente o tipo da variávl
            Console.WriteLine("10 + 20 = " + soma);

            int copiaDeNumero1 = numero1;
            copiaDeNumero1 = 11;
            Console.WriteLine(numero1);
            Console.WriteLine(copiaDeNumero1);

            var quadrado1 = new Quadrado(); // cria um quadrado
            quadrado1.lado = 10; // quadrado1 terá valor de lado = 10 
            var quadrado2 = quadrado1; //Será que a cópia do quadrado foi completa? Ou será que copiamo apenas a referência?
            quadrado2.lado = 11;
            Console.WriteLine(quadrado1.lado); //Quadrado1 deveria ter o lado igual a 10
            Console.WriteLine(quadrado2.lado); //Quadrado2 deveria ter o lado igual a 11
        }

        class Quadrado //define uma classe chamada quadrado
        {
            public int lado; //define um atributo chamado lado, na classe Quadrado.
        }
    }
}
