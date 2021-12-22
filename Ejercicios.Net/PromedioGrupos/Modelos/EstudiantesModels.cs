using System.Collections.Generic;

namespace Ejercicios.Net.PromedioGrupos.Modelos
{
    public class EstudiantesModels
    {
        public EstudiantesModels()
        {
            Materias = new List<MateriaModels>();
        }

        public int IdEstudiante { get; set; }
        public string Estudiante { get; set; }
        public double NotaGeneral { get; set; }
        public List<MateriaModels> Materias { get; set; }
    }
}
