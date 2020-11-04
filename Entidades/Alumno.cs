using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string apellido;
        private int dni;
        private string fotoAlumno;
        private string nombre;

        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string FotoAlumno { get => fotoAlumno; set => fotoAlumno = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Alumno(string nombre, string apellido, int dni ,string ruta)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fotoAlumno = ruta;
        }

    }
}
