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
    public partial class frmTestDelegados : Form
    {
        private string path;

        public frmTestDelegados()
        {
            InitializeComponent();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            frmPrincipal padre = (frmPrincipal)this.Owner;

            //INVOCO AL DELEGADO DEFINIDO EN FRMPRINCIPAL
            padre.ActualizarNombrePorDelegado(this.TxtNombre.Text);
            padre.ActualizarFotoPorDelegado(this.path);
        }

        private void ConfigurarOpenSaveFileDialog()
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.DefaultExt = ".jpg";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Seleccione una foto…";
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.path = openFileDialog1.FileName;
            }
        }
    }
}
