using Ejercicios.Net.InformeGas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Net.InformeGas.Logica
{
    public class Informe
    {


        public void PrepararData()
        {
            List<ComponentesModels> listaComponentes = new List<ComponentesModels>()
            {
                new ComponentesModels()
                {
                    Componente="Aceite Finos",
                    Normal=10,
                    Extra=5,
                    Super=35
                },
                new ComponentesModels()
                {
                    Componente="Alquitrán",
                    Normal=15,
                    Extra=4,
                    Super=31
                },
                new ComponentesModels()
                {
                    Componente="Grasas Residuales",
                    Normal=18,
                    Extra=2,
                    Super=30
                }
            };

            List<RefineriaModels> listaRefineria = new List<RefineriaModels>()
            {
                new RefineriaModels()
                {
                    Refineria="A",
                    Normal=3000,
                    Extra=7000,
                    Super=2000
                },
                new RefineriaModels()
                {
                    Refineria="B",
                    Normal=4000,
                    Extra=500,
                    Super=600
                }
            };

            List<ComponentesModels> totalAnual = Totales_Anuales(listaRefineria, listaComponentes);


            List<RefineriaModels> maximoAlquitran = Maximo_Alquitran(listaRefineria, listaComponentes);
            Totales_Refinerias(listaRefineria, listaComponentes);
        }


        private List<ComponentesModels> Totales_Anuales(List<RefineriaModels> refinerias, List<ComponentesModels> componentes)
        {
            List<ComponentesModels> listaComponentes = new List<ComponentesModels>();
            RefineriaModels refi = new RefineriaModels()
            {
                Refineria = "Suma total",
                Extra = refinerias.Sum(x => x.Extra),
                Normal = refinerias.Sum(x => x.Normal),
                Super = refinerias.Sum(x => x.Super),
            };

            ComponentesModels compoAceiteFino = componentes.FirstOrDefault(x => x.Componente == "Aceite Finos");
            ComponentesModels compoAlquitran = componentes.FirstOrDefault(x => x.Componente == "Alquitrán");
            ComponentesModels compoGrasasResidual = componentes.FirstOrDefault(x => x.Componente == "Grasas Residuales");

            //listaComponentes.Add(new ComponentesModels()
            //{
            //    Componente = compoAceiteFino.Componente,
            //    Normal = compoAceiteFino.Normal * refi.Normal,
            //    Extra = compoAceiteFino.Extra * refi.Extra,
            //    Super = compoAceiteFino.Super * refi.Super,
            //});
            //listaComponentes.Add(new ComponentesModels()
            //{
            //    Componente = compoAlquitran.Componente,
            //    Normal = compoAlquitran.Normal * refi.Normal,
            //    Extra = compoAlquitran.Extra * refi.Extra,
            //    Super = compoAlquitran.Super * refi.Super,
            //});
            //listaComponentes.Add(new ComponentesModels()
            //{
            //    Componente = compoGrasasResidual.Componente,
            //    Normal = compoGrasasResidual.Normal * refi.Normal,
            //    Extra = compoGrasasResidual.Extra * refi.Extra,
            //    Super = compoGrasasResidual.Super * refi.Super,
            //});

            listaComponentes.AddRange(new List<ComponentesModels>()
            {
                new ComponentesModels()
                {
                    Componente = compoAceiteFino.Componente,
                    Normal = compoAceiteFino.Normal * refi.Normal,
                    Extra = compoAceiteFino.Extra * refi.Extra,
                    Super = compoAceiteFino.Super * refi.Super,
                },
                new ComponentesModels()
                {
                    Componente = compoAlquitran.Componente,
                    Normal = compoAlquitran.Normal * refi.Normal,
                    Extra = compoAlquitran.Extra * refi.Extra,
                    Super = compoAlquitran.Super * refi.Super,
                },
                new ComponentesModels()
                {
                    Componente = compoGrasasResidual.Componente,
                    Normal = compoGrasasResidual.Normal * refi.Normal,
                    Extra = compoGrasasResidual.Extra * refi.Extra,
                    Super = compoGrasasResidual.Super * refi.Super,
                }
            });

            return listaComponentes;
        }

        private List<RefineriaModels> Maximo_Alquitran(List<RefineriaModels> refinerias, List<ComponentesModels> componentes)
        {
            List<RefineriaModels> listaRefinerias = new List<RefineriaModels>();
            ComponentesModels compoAlquitran = componentes.FirstOrDefault(x => x.Componente == "Alquitrán");

            Console.WriteLine("");
            foreach (var item in refinerias)
            {
                int extra = item.Extra * compoAlquitran.Extra;
                int super = item.Super * compoAlquitran.Super;
                int normal = item.Normal * compoAlquitran.Normal;

                listaRefinerias.Add(new RefineriaModels()
                {
                    Extra = extra,
                    Super = super,
                    Normal = normal,
                    Refineria = item.Refineria
                });

                if (extra > super && extra > normal)
                    Console.WriteLine($" Refineria {item.Refineria} máximo alquitrán:  Extra: {extra}");


                if (super > extra && super > normal)
                    Console.WriteLine($" Refineria {item.Refineria} máximo alquitrán:  Super: {super}");

                if (normal > extra && normal > super)
                    Console.WriteLine($" Refineria {item.Refineria} máximo alquitrán:  Normal: {normal}");
            }

            //listaRefinerias = refinerias.Select(x => new RefineriaModels()
            //{
            //    Extra = x.Extra * compoAlquitran.Extra,
            //    Super = x.Super * compoAlquitran.Super,
            //    Normal = x.Normal * compoAlquitran.Normal,
            //    Refineria = x.Refineria
            //}).ToList();

            return listaRefinerias;
        }

        private List<ComponentesRefineriaModels> Totales_Refinerias(List<RefineriaModels> refinerias, List<ComponentesModels> componentes)
        {
            List<ComponentesRefineriaModels> componentesRefinerias = new List<ComponentesRefineriaModels>();

            Console.WriteLine("");
            foreach (var item in refinerias)
            {
                Console.WriteLine($"Refineria: {item.Refineria}");

                foreach (var compo in componentes)
                {
                    Console.WriteLine($"Total Componente: {compo.Componente} - Normal: {compo.Normal * item.Normal} Super: {compo.Super * item.Super} Extra: {compo.Extra * item.Extra}");
                    
                    ComponentesRefineriaModels refineriaModels = new ComponentesRefineriaModels()
                    {
                        Refineria = item.Refineria,
                        Componente = compo.Componente,
                        Normal = compo.Normal * item.Normal,
                        Super = compo.Super * item.Super,
                        Extra = compo.Extra * item.Extra,
                    };
                    componentesRefinerias.Add(refineriaModels); 
                }
                Console.WriteLine("");
            }

            return componentesRefinerias;
        }
    }
}
