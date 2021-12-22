using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Net.AlzaDolar.Logica
{
    public class Alza
    {

        public void CalcularAlza()
        {
            int dia = 0;
            //List<double> precios = new List<double>();
            double[] precios;
            List<double> residuos = new List<double>();

            Console.WriteLine("Digita el número de días");
            dia = Convert.ToInt32(Console.ReadLine());
            precios = new double[dia];

            for (int i = 0; i < dia; i++)
            {
                Console.WriteLine($"Precio del día: {i + 1}");
                precios[i] = Convert.ToDouble(Console.ReadLine());
                //precios.Add(Convert.ToDouble(Console.ReadLine()));
            }

            dia = dia - 1;
            for (int i = 0; i <= dia; i++)
            {
                if (i != dia)
                {
                    double operacion = precios[i + 1] - precios[i];
                    residuos.Add(operacion);
                }
            }

            double resultado = residuos.Max();
            if (resultado == 0)
            {
                Console.WriteLine("No hubo alza");
            }
            else
            {
                if (resultado > 0)
                    Console.WriteLine("El alza mayor fue de: " + resultado);
                else
                    Console.WriteLine($"El alza mayor fue de:  {resultado * -1}");

            }


            //foreach (var item in precios)
            //{

            //}



        }


    }
}
