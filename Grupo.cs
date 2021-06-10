using System;
using System.Collections.Generic;

namespace PR2Alumnos
{
    class Grupo
    {
       public int semestre;

        public Carrera carrera;
       public string Nombre { 
           get {
                return this.semestre + " " + this.carrera.nombre; 
           } 
        }
        public List<Alumno> alumnos = new List<Alumno>();

        public Grupo(int semestre, Carrera carrera)
        {
            this.semestre = semestre;
            this.carrera = carrera;
            
        }

        public Alumno ConsultarAlumnoPorMatricula(int matricula)
        {
            for (int i = 0; i < this.alumnos.Count; i++)
            {
                if (matricula == this.alumnos[i].matricula)
                {
                    return alumnos[i];
                }
            }

            return null;
        }
    }
}
