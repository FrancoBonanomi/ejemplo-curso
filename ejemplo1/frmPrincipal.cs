using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class frmPrincipal : Form
    {
        //le agrego un comentario al archivo
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if(item.GetType()==typeof (Form1))
                {
                    MessageBox.Show("YA EXISTE ESTA VENTANA ABIERTA, TERMINE DE TRABAJAR ALLI");
                    return;
                }
            }
            
            Form1 ventana = new Form1();
            // ventana.Show();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
