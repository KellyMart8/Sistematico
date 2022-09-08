using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPromedioNotas
{
    public partial class fmrPromedioNotas : Form
    {
        ListViewItem Item;
        public fmrPromedioNotas()
        {
            InitializeComponent();
        }

        private void fmrPromedioNotas_Load(object sender, EventArgs e)
        {
            
        }
        //Recopilando datos
        private void CapturandoDatos()
        {
            PromedioNotas.Estudiante = txtEstudiante.Text;
            PromedioNotas.nota1 = int.Parse(txtNota1.Text);
            PromedioNotas.nota2 = int.Parse(txtNota2.Text);
            PromedioNotas.nota3 = int.Parse(txtNota3.Text);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ListViewItem fila = new ListViewItem(txtEstudiante.Text); 
            fila.SubItems.Add(txtNota1.Text.ToString());
            fila.SubItems.Add(txtNota2.Text.ToString());
            fila.SubItems.Add(txtNota3.Text.ToString());
            fila.SubItems.Add(PromedioNotas.ObtenerPromedio().ToString());
            listView1.Items.Add(fila);
            LimpiarControles();

        }

        private void LimpiarControles()
        {
            txtEstudiante.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
