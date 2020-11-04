using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Delegados.WindowsForm.Starter
{
    public partial class frmDatosAlumno : frmAltaAlumno
    {
        public frmDatosAlumno()
        {
            InitializeComponent();
        }

        public void ActualizarAlumno(Alumno alumno,EventArgs e)
        {
            this.txtApellido.Text = alumno.Apellido;
            this.txtNombre.Text = alumno.Nombre;
            this.txtDni.Text = alumno.Dni.ToString();
            this.txtFoto.Text = alumno.FotoAlumno;
            this.pictureBox1.Image = Image.FromFile(alumno.FotoAlumno); 
        }
    }

}
