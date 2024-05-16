using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaskPlanner
{
    public partial class Inicio : Form
    {
        private List<tipo_tarea> tRecientes;
        private tipo_tareaConsulta tTareaConsultas;
        public Inicio()
        {
            InitializeComponent();
            tRecientes = new List<tipo_tarea>();
            tTareaConsultas = new tipo_tareaConsulta ();
            cargarTareas();
          
        }

        private void cargarTareas(string filtro = "")
        {

            TareasRecientes tr = new TareasRecientes();
            tr.dgvTareas.Rows.Clear();
            tr.dgvTareas.Refresh();
            tRecientes.Clear();
            tRecientes = tTareaConsultas.getTareas(filtro);

            for (int i = 0; i < tRecientes.Count(); i++)
            {
                tr.dgvTareas.RowTemplate.Height = 50;
                tr.dgvTareas.Rows.Add(
                    tRecientes[i].id,
                    tRecientes[i].titulo_tarea,
                    tRecientes[i].informacion,
                    tRecientes[i].fecha
                    );
            }
         

        }

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aYUDAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           BotonInicio_Click(null,e);
        }
        //BTNSalir
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //meotodo para visualizar en el panel
        private void AbrirFormhijo(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            
        }
        //Btninsertar
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //lamada del metodo
            AbrirFormhijo(new Insertar());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            //llamada del metodo
            AbrirFormhijo(new TareasRecientes());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new Ayuda());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new Recordatorios());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new Informacion());
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
           // AbrirFormhijo(new Registrar());
            AbrirFormhijo(new Login());
                }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
