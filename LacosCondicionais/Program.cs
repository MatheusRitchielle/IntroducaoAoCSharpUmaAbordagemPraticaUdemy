using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laços condicionais => Execução mediante determinada condição/situação satisfeita
            // Laço If. else if e else
            int hora = 18;
            if (hora <= 15)
                Console.WriteLine("A hora é menos que 15h!");
            else if (hora <= 17)
                Console.WriteLine("A hora é menor ou igual a 17!");
            else //garante a execução do bloco de código seguinte a ele
            {
                if (hora == 18)
                    Console.WriteLine("São 18hs!");
                else
                    Console.WriteLine("Já passou das 18hs!");
            }

            //switch
            //Geralmente uma expressão avalida é uma constante
            switch(hora)
            {
                case 15: //teste condicional é exato
                    Console.WriteLine("São 15h!");
                    break;
                case 18:
                    Console.WriteLine("São 18h!");
                    break;
            }

            PrimeiroSemeste mes = PrimeiroSemeste.Feve;
            switch(mes)
            {
                case PrimeiroSemeste.Janeiro:
                    Console.WriteLine("Estamos em Janeiro!");
                    break;
                case PrimeiroSemeste.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro!");
                    break;
                case PrimeiroSemeste.Marco:
                    Console.WriteLine("Estamos em Março!");
                    break;
                case PrimeiroSemeste.Abril:
                    Console.WriteLine("Estamos em Abril!");
                    break;
                case PrimeiroSemeste.Maio:
                    Console.WriteLine("Estamos em Maio!");
                    break;
                case PrimeiroSemeste.Junho:
                    Console.WriteLine("Estamos em Junho!");
                    break;
                default://Será executado se nenhum dos outros for satisfeito.
                    Console.WriteLine("Não é um mês do primero semestre!");
                        break;

            }
        }
    }

    public enum PrimeiroSemeste
    {
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho
    }
}
