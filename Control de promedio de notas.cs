using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromNot
{
    public partial class Control_de_promedio_de_notas : Form
    {
        public Control_de_promedio_de_notas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Promedio objPro = new Promedio();

            objPro.nombre = txtNombre.Text;
            objPro.nota1 = int.Parse(txtNota1.Text);
            objPro.nota2 = int.Parse(txtNota2.Text);
            objPro.nota3 = int.Parse(txtNota3.Text);
            objPro.nota4 = int.Parse(txtNota4.Text);

            lblNotaBaja.Text = objPro.notabaja().ToString("0.00");
            lblPromedio.Text = objPro.promedio().ToString("0.00");
            lblCondicion.Text = objPro.condicion();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de salir?",
            "Promedio", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }       
    }
}
