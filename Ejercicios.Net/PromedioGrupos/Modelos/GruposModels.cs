using System.Collections.Generic;

namespace Ejercicios.Net.PromedioGrupos.Modelos
{
    public class GruposModels
    {
        public GruposModels()
        {
            Estudiantes = new List<EstudiantesModels>();
        }

        public int IdGrupo { get; set; }
        public string Grupo { get; set;}

        public List<EstudiantesModels> Estudiantes { get; set; }
    }
}
