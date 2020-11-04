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
    public partial class frmAltaAlumno : Form
    {

        public frmAltaAlumno()
        {
            InitializeComponent();
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFoto.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal padre = (frmPrincipal)this.Owner;

            try
            {
                padre.ActualizarAlumno(new Alumno(txtNombre.Text,txtApellido.Text,int.Parse(txtDni.Text),txtFoto.Text),e);
            }
            catch(Exception)
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
