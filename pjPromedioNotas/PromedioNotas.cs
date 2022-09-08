using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    public static class PromedioNotas
    {
        public static string Estudiante { get; set; } 
        public static int Calificaciones { get; set; }
        public static int nota1 { get; set; }   
        public static int nota2 { get; set; }   
        public static int nota3 { get; set; }   

        public static double ObtenerPromedio()
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
