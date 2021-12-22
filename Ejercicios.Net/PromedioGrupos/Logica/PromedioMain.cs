using Ejercicios.Net.PromedioGrupos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Net.PromedioGrupos.Logica
{
    public class PromedioMain
    {
        private string nombreInstitucion;
        private List<GruposModels> grupos { get; set; }
        private List<EstudiantesModels> estudiantes { get; set; }
        private List<MateriaModels> materias { get; set; }
        private List<CalificacionesModels> califiaciones = new List<CalificacionesModels>();



        public void Main()
        {
            //Console.WriteLine("Por favor digita el nombre de la institución");
            //nombreInstitucion = Console.ReadLine();

            Console.WriteLine($"¿Cuantos grupos tiene la institución {nombreInstitucion}?");
            int cantidadGrupos = Convert.ToInt32(Console.ReadLine());
            if (cantidadGrupos == 0)
            {
                while (cantidadGrupos == 0)
                {
                    Console.WriteLine($"¿Cuantos grupos tiene la institución {nombreInstitucion}?");
                    cantidadGrupos = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine($"¿Cuantos estudiantes tiene cada grupo?");
            int cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"¿Cuantas materias tiene cada estudiante?");
            int cantidadMaterias = Convert.ToInt32(Console.ReadLine());


            LlenarGrupos(cantidadGrupos);
            LlenarEstudiantes(cantidadEstudiantes);
            LlenarMaterias(cantidadMaterias);
            Agrupar();
            Calificar();
            Promedio();
        }

        private void LlenarGrupos(int cantidad)
        {
            grupos = new List<GruposModels>();
            for (int i = 1; i <= cantidad; i++)
            {
                GruposModels objGrupo = new GruposModels()
                {
                    IdGrupo = i,
                    Grupo = $"Grupo {i}",
                };
                grupos.Add(objGrupo);
            }
        }

        private void LlenarEstudiantes(int cantidad)
        {
            estudiantes = new List<EstudiantesModels>();
            for (int i = 1; i <= cantidad; i++)
            {
                EstudiantesModels objEstudiate = new EstudiantesModels()
                {
                    IdEstudiante = i,
                    Estudiante = $"Estudiantes {i}",
                };

                estudiantes.Add(objEstudiate);
            }
        }

        private void LlenarMaterias(int cantidad)
        {
            materias = new List<MateriaModels>();
            for (int i = 1; i <= cantidad; i++)
            {
                MateriaModels objMateria = new MateriaModels()
                {
                    IdMateria = i,
                    Materia = $"Materia {i}",
                };

                materias.Add(objMateria);
            }
        }

        private void Agrupar()
        {
            foreach (var estudiante in estudiantes)
            {
                estudiante.Materias.AddRange(materias);
            }


            foreach (var grupo in grupos)
            {
                grupo.Estudiantes.AddRange(estudiantes);
            }
        }

        private void Calificar()
        {
            Console.Clear();
            Console.WriteLine("Calificar a todos los grupos en cascada");

            foreach (var grupo in grupos)
            {
                Console.WriteLine("");
                Console.WriteLine($"Calificar el grupo: {grupo.Grupo}");
                foreach (var estudiante in grupo.Estudiantes)
                {
                    Console.WriteLine($"Estudiante: {estudiante.Estudiante}");
                    foreach (var materia in estudiante.Materias)
                    {
                        Console.WriteLine($"Materias: {materia.Materia}");
                        for (int i = 1; i <= 3; i++)
                        {
                            Console.WriteLine("Por favor diligenciar la nota: " + i);
                            Random rnd = new Random();   
                            double nota=rnd.Next(1,10);   
                            CalificacionesModels calificacion = new CalificacionesModels()
                            {
                                IdCalificacion = IdCalifacion(),
                                IdGrupo = grupo.IdGrupo,
                                IdEstudiante = estudiante.IdEstudiante,
                                IdMateria = materia.IdMateria,
                                Nota = nota
                            };
                            califiaciones.Add(calificacion);    
                            Console.WriteLine("Nota: "+nota);
                        }
                        Console.WriteLine("");
                    }
                }
            }
        }

        private int IdCalifacion()
        {
            int id = 1;
            try
            {
                id = califiaciones.Max(x => x.IdCalificacion)+1;
            }
            catch (Exception)
            {
                id = 1;
            }

            return id;  
        }
    
        private void Promedio()
        {
            Console.ReadKey();
            Console.Clear();


            List<double> promedioEstudiante;
            List<double> promedioGrupos;

            var groupGrupo = califiaciones.GroupBy(x => x.IdGrupo);
            foreach (var gp in groupGrupo)
            {
                promedioGrupos = new List<double>();
                var gpos=grupos.First(x=> x.IdGrupo.Equals(gp.Key));
                Console.WriteLine("Grupo: " + gpos.Grupo);

                var groupStudents = gp.GroupBy(x => x.IdEstudiante);
                foreach (var st in groupStudents)
                {
                    promedioEstudiante = new List<double>();
                    var studiant = estudiantes.First(x => x.IdEstudiante == st.Key);
                    Console.WriteLine("Estudiante: " + studiant.Estudiante);

                    
                    var materia=st.GroupBy(x=> x.IdMateria);
                    foreach (var mt in materia)
                    {
                        var mteria = materias.First(x => x.IdMateria == mt.Key);
                        Console.WriteLine("Materia: " + mteria.Materia);
                        double promedioMateria = mt.Select(x => x.Nota).Average();
                        promedioEstudiante.Add(promedioMateria);
                        Console.WriteLine("Promedio: " + promedioMateria);
                    }
                    promedioGrupos.Add(promedioEstudiante.Average());
                    Console.WriteLine("Promedio Estudiante: " + promedioEstudiante.Average());
                    Console.WriteLine("");
                }

                Console.WriteLine("Promedio Grupo: " + promedioGrupos.Average());
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    
    }
}
