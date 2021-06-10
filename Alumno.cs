using System;
using System.Collections.Generic;

namespace PR2Alumnos
{
    class Alumno
    {
       public string nombre;

       public string apellidoPaterno;

       public string apellidoMaterno;

       public int matricula;

       public Alumno(string nombre, string apellidoPaterno, string apellidoMaterno, int matricula)
       {
           this.nombre = nombre;
           this.apellidoPaterno = apellidoPaterno;
           this.apellidoMaterno = apellidoMaterno;
           this.matricula = matricula;
       }
    }
}
