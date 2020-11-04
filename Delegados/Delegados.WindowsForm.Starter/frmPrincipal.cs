using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Delegados.WindowsForm.Starter
{
    public partial class frmPrincipal : Form
    {
        public DelegadoDeActualizacion ActualizarNombrePorDelegado;
        public DelegadoDeActualizacion ActualizarFotoPorDelegado;
        public DelegadoDeAlumno ActualizarAlumno;

        public frmPrincipal()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void TestDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados frm = new frmTestDelegados();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show(this);
        }

        private void TestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frm = new frmDatos();

            //INICIALIZO DELEGADO, PASO LA DIRECCION DE MEMORIA DEL METODO DEFINIDO EN FRMDATOS
            this.ActualizarNombrePorDelegado += new DelegadoDeActualizacion(frm.ActualizarNombre);
            this.ActualizarFotoPorDelegado += new DelegadoDeActualizacion(frm.ActualizarFoto);

            frm.Show(this);
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosAlumno frm = new frmDatosAlumno();
            frm.StartPosition = FormStartPosition.CenterScreen;

            this.ActualizarAlumno += new DelegadoDeAlumno(frm.ActualizarAlumno);

            frm.Show(this);
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlumno frm = new frmAltaAlumno();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show(this);
        }
    }
}
