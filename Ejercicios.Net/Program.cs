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
            //Console.WriteLine("**********");
            //Console.WriteLine("Por favor escriba su nombre:");
            //string nombre=Console.ReadLine();
            //Console.WriteLine("Hola, "+ nombre);
            //Console.WriteLine($"Hola, {nombre}");

            //Promedio();
            //PromedioV2();

            //Edad();
            //NumeroMayor();

            //PromedioMain objPromedio = new PromedioMain();
            //objPromedio.Main();


            //Alza objAlza = new Alza();
            //objAlza.CalcularAlza();

            //BarmanLogica objBarman = new BarmanLogica();
            //objBarman.CalcularPrecios();

            //Informe objInforme=new  Informe();
            //objInforme.PrepararData();


            //Mayor objMayor = new Mayor();
            //objMayor.MayorQue();

            //string[] juegos = { "Carcassonne", "Bang", "Jungle Speed", "Los colonos de Catán", "Black stories", "Munchkin", "Zombies" };

            //IEnumerable<string> consulta = from j in juegos
            //                               where j.StartsWith("J")
            //                               orderby j ascending
            //                               select j;

            //IEnumerable<string> consulta_2 = juegos.Where(x => x.StartsWith("J")).OrderByDescending(x => x.ToString());

            //foreach (string elemento in consulta)
            //    Console.WriteLine(elemento);

            //foreach (string elemento in consulta_2)
            //    Console.WriteLine(elemento);

            //List<Juego> juegos = new List<Juego>()
            //{
            //    new Juego { Id=1, Nombre="Carcassonne", MinJugadores=2, MaxJugadores=8 },
            //    new Juego { Id=2, Nombre="Los colonos de Catán", MinJugadores=2, MaxJugadores=8 },
            //    new Juego { Id=3, Nombre="Jungle Speed", MinJugadores=1, MaxJugadores=4 },
            //    new Juego { Id=4, Nombre="Black Stories", MinJugadores=2, MaxJugadores=100 },
            //    new Juego { Id=5, Nombre="Munchkin", MinJugadores=3, MaxJugadores=10 }
            //};

            //List<Juego> consul = juegos.Where(x => x.MaxJugadores > 4).OrderBy(x => x.Nombre).ToList();

            //IEnumerable<Juego> consulta = from j in juegos
            //                              where j.MaxJugadores > 4
            //                              orderby j.Nombre ascending
            //                              select j;
            //foreach (var item in consul)
            //{
            //    Console.WriteLine(item.Nombre);
            //    Console.WriteLine(item.MaxJugadores);
            //    Console.WriteLine("");

            //}

            //foreach (var item in consulta)
            //{
            //    Console.WriteLine(item.Nombre);
            //    Console.WriteLine(item.MaxJugadores);
            //    Console.WriteLine("");

            //}



            Agrupacion objAgrupacion=new Agrupacion();
            objAgrupacion.Consultar();
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
