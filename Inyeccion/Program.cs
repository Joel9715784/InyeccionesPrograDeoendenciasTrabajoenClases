using System;
using Interfaces;
using Negocio;
using Entidades;
namespace InyecciondeDependenciasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPersistencia persistencia = null; 
           


            Secretaria secretaria = new Secretaria(persistencia);
            Estudiante estudiante = new Estudiante("Joel", "Kathe");
            Curso curso = new Curso("Programacion Visual");

            secretaria.Matricular(estudiante, curso);


        }
    }
}
