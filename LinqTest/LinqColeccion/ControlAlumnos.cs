using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();

        List<Alumno> alumnos = new List<Alumno>();

        public ControlAlumnos()
        {
            carreras.Add(new Carrera { IdCarrera = 1, Nombre = "Ingenieria de Software"});
            carreras.Add(new Carrera { IdCarrera = 2, Nombre = "Redes y Servicios de Computo" });

            alumnos.Add(new Alumno { IdAlumno = 1, Nombre = "Juan Perez Sanchez", Matricula = "S20015714", Promedio = 8.9, IdCarrera = 1 });
            alumnos.Add(new Alumno { IdAlumno = 2, Nombre = "Maria Rodriguez Martinez", Matricula = "S4324234", Promedio = 9.2, IdCarrera = 2 });
            alumnos.Add(new Alumno { IdAlumno = 3, Nombre = "Jose Trelles Jimenez", Matricula = "S211111", Promedio = 6.5, IdCarrera = 2 });
        }

        public void getAlumnosPorCarrera(int idCarrera)
        {
            IEnumerable<Alumno> resultado = from alumno in alumnos join carrera in carreras on alumno.IdCarrera equals carrera.IdCarrera where alumno.IdCarrera == idCarrera select alumno;

            foreach(Alumno alumno in  resultado)
            {
                alumno.getDatosAlumno(carreras);
            }
        }
    }
}
