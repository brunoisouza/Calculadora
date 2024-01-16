using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*     
                Faça um script que solicite dois números e ao final mostre a soma, divisão, multiplicação;    
            */

            // Solicitar os dois números;
            Console.WriteLine("Informe o primeiro número:");
            decimal primeiroNumero = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            decimal segundoNumero = decimal.Parse(Console.ReadLine());

            // Efetuar os cálculos;
            decimal soma = primeiroNumero + segundoNumero;
            decimal subtracao = primeiroNumero - segundoNumero;
            decimal multiplicacao = primeiroNumero * segundoNumero;
            decimal divisao = primeiroNumero / segundoNumero;

            // Limpar a tela
            Console.Clear();

            // Mostrar os resultados;
            Console.WriteLine("A soma de " + primeiroNumero + " e " + segundoNumero + " é igual a: " + soma);
            Console.WriteLine("A subtração de " + primeiroNumero + " e " + segundoNumero + " é igual a: " + subtracao);
            Console.WriteLine("A multiplicação de " + primeiroNumero + " e " + segundoNumero + " é igual a: " + multiplicacao);
            Console.WriteLine("A divisão de " + primeiroNumero + " e " + segundoNumero + " é igual a: " + divisao);

            // Esperar o usuário finalizar o programa
            Console.ReadKey();

        }
    }
}
