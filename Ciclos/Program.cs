﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo while
            //int valor = 15;

            //while (valor < 10)
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //}
            #endregion

            #region Ciclo do while

            //int valor = 15;

            //do
            //{
            //    Console.WriteLine("O valor é  " + valor);
            //    valor++;
            //} while (valor < 10);

            #endregion

            #region Ciclo For
            //for (int i = 0, j = 10; i < 10; i++)
            //{
            //    Console.WriteLine("I = " + i + " | j = " + j);
            //}
            #endregion

            string[] nomes = { "Luana", "Giovanna", "Gigi" , "Leleo"};

            foreach(string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }


            Console.ReadKey(); 
        }
    }
}
