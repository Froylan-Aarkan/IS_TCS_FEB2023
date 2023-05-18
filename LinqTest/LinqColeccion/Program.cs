// See https://aka.ms/new-console-template for more information

using LinqColeccion;
using System.Linq;
using System.Runtime.CompilerServices;

//int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine("A continuación te mostramos los numeros pares que existen en el arreglo:");

//Seleccionar numeros pares

//Sin LINQ
//List<int> numerosPares = new List<int>();
//foreach(int numero in numeros)
//{
//    if(numero % 2 == 0)
//    {
//        numerosPares.Add(numero);
//    }
//}

//Con LINQ
//IEnumerable<int> numerosPares = from numero in numeros where numero % 2 != 0 select numero;

////Imprimir numeros pares

//foreach(int numero in numerosPares)
//{
//    Console.WriteLine("- " + numero);
//}

//Ejemplo Control Alumnos Objetos
ControlAlumnos controlAlumnos = new ControlAlumnos();
controlAlumnos.getAlumnosPorCarrera(2);