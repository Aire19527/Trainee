using Ejercicios.Net.AgruparEstudiantes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Net.AgruparEstudiantes.Logica
{
    public class Agrupacion
    {
        List<EstudianteModels> listaEstudiante = new List<EstudianteModels>();

        string gradoSuperior = "11B";
        string gradoInferior = "5A";
        string grado = "1C";

        public Agrupacion()
        {
            PreparadarDatos();
        }

        private void PreparadarDatos()
        {
            Random rnd = new Random();
            //int cantidadEstudiante = rnd.Next(10, 200);
            int cantidadEstudiante = rnd.Next(5, 10);
            Console.WriteLine(cantidadEstudiante);
            Console.WriteLine("");
            for (int i = 1; i <= cantidadEstudiante; i++)
            {
                EstudianteModels estudiante = new EstudianteModels()
                {
                    Nombre = $"Estudiante {i}",
                    Edad = rnd.Next(5, 20),
                };


                int gd = rnd.Next(1, 11);
                if (gd > 8)
                    estudiante.Grado = gradoSuperior;
                if (gd > 3 && gd <= 8)
                    estudiante.Grado = gradoInferior;
                if (gd <= 3)
                    estudiante.Grado = grado;

                listaEstudiante.Add(estudiante);
            }
        }

        public void Consultar()
        {
            //Agrupar por grados y saber la cantidad de estudiantes
            //Agrupar por Edad

            var agrupacion = from p in listaEstudiante
                             group p by p.Grado into grupo
                             select grupo;

            foreach (var item in agrupacion)
            {
                Console.WriteLine("**Agrupacion Grado**");
                Console.WriteLine("Grado: " + item.Key);
                Console.WriteLine("Cantidad: " + item.Count());
                Console.WriteLine("****");
                foreach (var gp in item)
                {
                    Console.WriteLine("Nombre: " + gp.Nombre);
                    Console.WriteLine("Edad: " + gp.Edad);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }

            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");
            var agrupacion_2 = listaEstudiante.GroupBy(g => g.Edad);
            foreach (var item in agrupacion_2)
            {
                Console.WriteLine("**Agrupacion Edad**");
                Console.WriteLine("EDAD: " + item.Key);
                Console.WriteLine("Cantidad: " + item.Count());
                Console.WriteLine("****");
                foreach (var gp in item)
                {
                    Console.WriteLine("Nombre: " + gp.Nombre);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }

        }
    }
}
