﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int[,] matriz = new int[5, 5];
            //int[] vecval = Enumerable.Repeat(0, 5).ToArray();
            //int[] veccant = Enumerable.Repeat(0, 5).ToArray();
            int cat, dep, j, i, hs;
            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine("Para la categoria {0}", i);
                //cadena = Console.ReadLine();
                //cat = Convert.ToInt32(cadena);
                for (j = 1; j <= 4; j++)
                {
                    Console.WriteLine("Para el departamento {0}", j);
                   // cadena = Console.ReadLine();
                   // dep = Convert.ToInt32(cadena);
                    Console.WriteLine("ingrese el nro de hs trabajadas");
                    cadena = Console.ReadLine();
                    hs = Convert.ToInt32(cadena);
                    matriz[i, j] = matriz[i, j] + hs;
                }
            }
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= 4; j++)
                {
                    Console.WriteLine("categoria {0} depto {1} horas {2}\n", i, j, matriz[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
