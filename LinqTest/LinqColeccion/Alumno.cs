using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public double Promedio { get; set; }
        public int IdCarrera { get; set; }

        public void getDatosAlumno(List<Carrera> carreras)
        {
            Carrera carrera = carreras.FirstOrDefault(c => c.IdCarrera == IdCarrera);
            if (carrera != null)
            {
                Console.WriteLine("Alumno {0} con matricula {1} y promedio {2} en la carrera {3} con ID {4}", Nombre, Matricula, Promedio, carrera.Nombre, IdCarrera);
            }
            else
            {
                Console.WriteLine("Alumno con carrera no encontrada.");
            }
        }
    }
}
