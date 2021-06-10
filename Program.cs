using System;
using System.Collections.Generic;

namespace PR2Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
           Carrera multimedia = new Carrera("Ingenieria en Multimedia");
           Carrera artes = new Carrera("Licenciuatura en Artes Visuales");

           Grupo segundoMultimedia = new Grupo(2, multimedia);
           Grupo cuartoMultimedia = new Grupo(4, multimedia);
           Grupo sextoMultimedia = new Grupo(6, multimedia);
           Grupo octavoMultimedia = new Grupo(8, multimedia);

           //opcion 1
           segundoMultimedia.alumnos.Add(new Alumno("Benjamin", "Estevane","Rosas", 6434));
           segundoMultimedia.alumnos.Add(new Alumno("Jorge", "Chavez","Ramos", 6438));

           cuartoMultimedia.alumnos.Add(new Alumno("Ramon", "Ramirez","loera", 6564));
           cuartoMultimedia.alumnos.Add(new Alumno("Ricardo", "Lopez","granados", 6568));

           sextoMultimedia.alumnos.Add(new Alumno("ana", "Parce","Garza", 6894));
           sextoMultimedia.alumnos.Add(new Alumno("Manuele", "Gomez","Maines", 6898));

           octavoMultimedia.alumnos.Add(new Alumno("Victor", "Paramo","rodriguez", 6784));
           octavoMultimedia.alumnos.Add(new Alumno("Juaquin", "Guzman","rosales", 6788));

            multimedia.grupoPorSemestre.Add(2, segundoMultimedia);
            multimedia.grupoPorSemestre.Add(4, cuartoMultimedia);
            multimedia.grupoPorSemestre.Add(6, sextoMultimedia);
            multimedia.grupoPorSemestre.Add(8, octavoMultimedia);


            // opcion 2

            multimedia.MostrarInformacion();
            Console.WriteLine("----");
            artes.MostrarInformacion();
        }
    }
}
