
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Net.MayorQue.Logica
{
    //URL Enunciado Ejercicio: http://progra.usm.cl/apunte/ejercicios/2/mayores-que.html
    public class Mayor
    {
        List<int> valores = new List<int>();

        #region Builder
        public Mayor()
        {
            PrepararData();
        }
        #endregion

        #region Methods
        private void PrepararData()
        {
            Random rand = new Random();
            int op = rand.Next(2, 100);
            Console.WriteLine($"Cantidad de Ciclos {op}");
            Console.WriteLine("");
            for (int i = 1; i <= op; i++)
            {
                int number = rand.Next(1, 1000);
                valores.Add(number);
                Console.WriteLine($"Numero: {number}");
            }
        }

        public void MayorQue()
        {
            Console.WriteLine("Digita un numero");
            int number = Convert.ToInt32(Console.ReadLine());

            //Forma #1
            int count = 0;

            foreach (var item in valores)
            {
                if (item > number)
                    count++;
            }

            Console.WriteLine("Numeros Mayores: " + count);


            //Forma #2
            int count_2 = valores.Where(x => x > number).Count();
            Console.WriteLine("Segunda Forma Numeros Mayores: " + count);

        }
        #endregion
    }
}
