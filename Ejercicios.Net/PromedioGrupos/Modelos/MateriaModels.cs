using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.Net.PromedioGrupos.Modelos
{
    public class MateriaModels
    {
        public MateriaModels()
        {
            Califaciones = new List<double>();
        }
        public int IdMateria { get; set; }
        public string Materia { get; set; }
        public double NotaGeneral { get; set; }
        public List<double> Califaciones { get; set; }
    }
}
