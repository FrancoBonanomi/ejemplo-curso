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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //cboColorFavorito.Items.Add("Rojo");
            //cboColorFavorito.Items.Add("Verde");
            //cboColorFavorito.Items.Add("Azul");

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Azul");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            p1.Nombre = txtNombre.Text;
            p1.FechaNacimiento= dtpFechaNacimiento.Value;
            //operador ternario
            p1.Chocolate = ckbChocolate.Checked ? "le gusta el chocolate" : "odia el chocolate";
           
            if (rdbWizard.Checked)
                p1.Tipo = "Wizard";
            else if (rdbMuggle.Checked)
                p1.Tipo = "Muggle";
            else
                p1.Tipo = "Squibs";

            p1.ColorFavorito = cboColorFavorito.SelectedItem.ToString();
            p1.NumeroFavorito = numNumeroFavorito.Value.ToString();

           

            MessageBox.Show(p1.Saludar());

        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario
            string chocolate = ckbChocolate.Checked ? "le gusta el chocolate" : "odia el chocolate";
            string tipo;
            if (rdbWizard.Checked)
                tipo = "Wizard";
            else if (rdbMuggle.Checked)
                tipo = "Muggle";
            else
                tipo = "Squibs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();
            lwElementos.Items.Clear();
            lwElementos.Items.Add(nombre);
            lwElementos.Items.Add(fecha.ToString());
            lwElementos.Items.Add(chocolate);
            lwElementos.Items.Add(tipo);
            lwElementos.Items.Add(colorFavorito);
            lwElementos.Items.Add(numeroFavorito);
        }
    }
}
