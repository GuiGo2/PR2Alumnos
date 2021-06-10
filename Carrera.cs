using System;
using System.Collections.Generic;

namespace PR2Alumnos
{
    class Carrera
    {
        public string nombre;
      public Dictionary<int, Grupo> grupoPorSemestre = new Dictionary<int, Grupo>();

      public Carrera(string nombre)
      {
          this.nombre = nombre;
      }

      public List<Alumno> ConsultarAlumnosInscritos()
      {
          List<Alumno> alumnosInscritos = new List<Alumno>();
          foreach (var grupo in grupoPorSemestre.Values)
          {
             // alumnosInscritos.AddRange(grupo.alumnos);
             for (int i = 0; i < grupo.alumnos.Count; i++)
             {
                // grupo.alumnos[i]
                alumnosInscritos.Add(grupo.alumnos[i]);
             }
          }
          return alumnosInscritos;
      } 

      public void MostrarInformacion()
      {
          // Ingenieria en Multimedia
          // 2 Multimedia - 10 alumnos
          // 4 Multimedia - 7 alumnos
          // 6 Multimedia - 7 alumnos
          // 8 Multimeida - 5 alumnos

          Console.WriteLine(this.nombre);
          foreach (var grupo in grupoPorSemestre.Values)
          {
              Console.WriteLine(grupo.Nombre + " - " + grupo.alumnos.Count + " alumnos");
          }
      }
    }
}
