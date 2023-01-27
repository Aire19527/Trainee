using Ejercicios.Net.Barman.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Net.Barman.Logica
{
    //URL Enunciado Ejercicio: http://progra.usm.cl/apunte/ejercicios/3/barman.html

    public class BarmanLogica
    {
        //private List<BaldesModels> listaBaldes = new List<BaldesModels>();
        #region Attributes
        private List<BaldesModels> listaBaldes;
        private List<PreciosModels> listaPrecios;

        //int precioVino = 5;
        //int precioGinebra = 45;
        //int precioJugoLimon = 10;
        #endregion


        #region Builder
        public BarmanLogica()
        {
            PrepararBebidas();
        }
        #endregion

        #region Methods
        private void PrepararBebidas()
        {
            listaBaldes = new List<BaldesModels>();

            listaBaldes.Add(new BaldesModels()
            {
                Balde = "A",
                Vino = 20,
                Ginebra = 30,
                JugoLimon = 50
            });

            listaBaldes.Add(new BaldesModels()
            {
                Balde = "B",
                Vino = 30,
                Ginebra = 20,
                JugoLimon = 60
            });

            listaBaldes.Add(new BaldesModels()
            {
                Balde = "C",
                Vino = 30,
                Ginebra = 30,
                JugoLimon = 32
            });

            listaPrecios = new List<PreciosModels>()
            {
                new PreciosModels()
                {
                    Liquido="Vino",
                    Precio=5
                },
                new PreciosModels()
                {
                    Liquido="Ginebra",
                    Precio=45
                },
                new PreciosModels()
                {
                    Liquido="JugoLimon",
                    Precio=10
                }
            };
        }

        public void CalcularPrecios()
        {
            int precioVino = listaPrecios.FirstOrDefault(x => x.Liquido.ToLower() == "vino").Precio;
            int precioGinebra = listaPrecios.FirstOrDefault(x => x.Liquido.ToLower() == "ginebra").Precio;
            int precioJugoLimon = listaPrecios.FirstOrDefault(x => x.Liquido.ToLower() == "jugolimon").Precio;


            //BaldesModels baldesA= listaBaldes.First(x=>x.Balde=="A");
            BaldesModels baldesA = listaBaldes.FirstOrDefault(x => x.Balde == "A");
            int precioBaldeA = 0;
            precioBaldeA = (baldesA.Vino * precioVino);
            precioBaldeA = precioBaldeA + (baldesA.Ginebra * precioGinebra);
            precioBaldeA = precioBaldeA + (baldesA.JugoLimon * precioJugoLimon);
            Console.WriteLine($"Precio Balde A {precioBaldeA}");

            BaldesModels baldesB = listaBaldes.FirstOrDefault(x => x.Balde == "B");
            int precioBaldeB = 0;
            precioBaldeB = (baldesB.Vino * precioVino);
            precioBaldeB = precioBaldeB + (baldesB.Ginebra * precioGinebra);
            precioBaldeB = precioBaldeB + (baldesB.JugoLimon * precioJugoLimon);
            Console.WriteLine($"Precio Balde B {precioBaldeB}");

            BaldesModels baldesC = listaBaldes.FirstOrDefault(x => x.Balde == "C");
            int precioBaldeC = 0;
            precioBaldeC = (baldesC.Vino * precioVino);
            precioBaldeC = precioBaldeC + (baldesC.Ginebra * precioGinebra);
            precioBaldeC = precioBaldeC + (baldesC.JugoLimon * precioJugoLimon);
            Console.WriteLine($"Precio Balde C {precioBaldeC}");

            Console.WriteLine("");
            Console.WriteLine($"El precio total de 10 baldes A es: {precioBaldeA * 10}");
            Console.WriteLine($"El precio total de 4 baldes B es: {precioBaldeB * 4}");
            Console.WriteLine($"El precio total de 5 baldes C es: {precioBaldeC * 5}");

        }

        #endregion
    }
}
