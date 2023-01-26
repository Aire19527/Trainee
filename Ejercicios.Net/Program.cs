using Ejercicios.Net.AgruparEstudiantes.Logica;
using Ejercicios.Net.AlzaDolar.Logica;
using Ejercicios.Net.Barman.Logica;
using Ejercicios.Net.InformeGas.Logica;
using Ejercicios.Net.MayorQue.Logica;
using Ejercicios.Net.Modelos;
using Ejercicios.Net.PromedioGrupos.Logica;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicios.Net
{



    class Program
    {
        static void Main(string[] args)
        {


            //Agrupacion objAgrupacion=new Agrupacion();
            //objAgrupacion.Consultar();

            //BarmanLogica barman = new BarmanLogica();
            //barman.CalcularPrecios();

            Mayor mayor = new Mayor();
            mayor.MayorQue();
        }



        #region Old

        static void Promedio()
        {
            //long prueba = 1225455874758457848754745847458;
            int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
            int promedio = 0;
            //=      : asignación
            // ==    :comparación
            // ===   :exactamente igual

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Por favor escriba la :" + i);

                if (i == 1)
                {
                    nota1 = Convert.ToInt32(Console.ReadLine());
                }
                else if (i == 2)
                {
                    nota2 = Convert.ToInt32(Console.ReadLine());
                }
                else if (i == 3)
                {
                    nota3 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    nota4 = Convert.ToInt32(Console.ReadLine());
                }
            }
            promedio = nota1 + nota2 + nota3 + nota4;

            Console.WriteLine($"Suma total: {promedio}");

            promedio = promedio / 4;
            Console.WriteLine($"Promedio de notas: {promedio}");

        }

        static void PromedioV2()
        {
            List<int> listaNotas = new List<int>();
            double promedio = 0;
            int count = 0;
            int key = 1;

            while (key == 1)
            {
                //count = count + 1;                
                count++;
                Console.WriteLine($"Por favor escriba la : {count} nota");

                //int nota = Convert.ToInt32(Console.ReadLine());
                //listaNotas.Add(nota);
                listaNotas.Add(Convert.ToInt32(Console.ReadLine()));

                if (count == 4)
                {
                    key = 2;
                }
            }
            promedio = listaNotas.Average();
            Console.WriteLine($"Promedio total: {promedio}");
        }

        static void Edad()
        {
            int dia, mes, anio, edad;
            Console.WriteLine("EDAD");
            Console.WriteLine("Por favor digite el día de nacimiento");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite el mes de nacimiento");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite el año de nacimiento");
            anio = Convert.ToInt32(Console.ReadLine());

            DateTime fecha = new DateTime(anio, mes, dia);


            DateTime fechaActual = DateTime.Now;
            Console.WriteLine("Fecha Actual: " + fechaActual);
            var resultado = fechaActual - fecha;
            var resultadoV2 = fechaActual.Year - fecha.Year;

            double res = (resultado.Days / 365);
            Console.WriteLine("Edad: " + Math.Round(res, 0));
            Console.WriteLine("Edad V2: " + resultadoV2);
        }

        static void NumeroMayor()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 99; i++)
            {
                Random rnd = new Random();
                numeros.Add(rnd.Next(0, 1000));
            }

            int mayor = numeros.Max();
            Console.WriteLine("Numero mayor: " + mayor);
            Console.WriteLine("");
            Console.WriteLine("");

            //Comprobamos si num es un número par o no
            if ((mayor % 2) == 0)
            {
                Console.WriteLine("Es un número par");
            }
            else
            {
                Console.WriteLine("Es un número impar");
            }
        }
        #endregion

    }
}
