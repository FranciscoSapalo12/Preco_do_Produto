using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preço_do_produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enunciado  ================================================================
            /*1.
             * 4 - Faça um programa que receba um valor que é o valor pago, um segundo
             * valor que é o preço do produto e retorne o troco a ser dado
             */
            //Estrutura de Dados =========================================================
            double vPago, preco, troco;

            //ALGORITIMO =================================================================

            Console.WriteLine("Qual o preço do produto?");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor pago?");
            vPago = double.Parse(Console.ReadLine());

            troco = vPago - preco;


            if (troco > 0)
                Console.WriteLine("O troco é: " + troco);
            else if (troco < 0)
                Console.WriteLine("Ainda falta pagar:" + Math.Abs(troco));
            else//troco == 0
                Console.WriteLine("Não há troco");
            Console.ReadLine();
        }
    }
}
