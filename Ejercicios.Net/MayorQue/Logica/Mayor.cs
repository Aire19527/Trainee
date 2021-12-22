
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.Net.MayorQue.Logica
{

    public class Mayor
    {
        List<int> valores = new List<int>();

        public Mayor()
        {
            PrepararData();
        }

        private void PrepararData()
        {
            Random rand = new Random();
            int op = rand.Next(2, 100);
            Console.WriteLine(op);
            for (int i = 1; i <= op; i++)
            {
                valores.Add(rand.Next(1, 1000));
            }
        }

        public void MayorQue()
        {
            Console.WriteLine("Digita un numero");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (var item in valores)
            {
                if (number > item)
                    count++;
            }

            Console.WriteLine("Numeros Mayores: " + count);
        }
    }
}
