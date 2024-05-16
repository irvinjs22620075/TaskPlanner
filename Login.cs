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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void botonIniciarsesion_Click(object sender, EventArgs e)
        {
            string usuario = Texto1Usuario.Text;
            string password = Texto2Contraseña.Text;

            try
            {
                Control ctrl = new Control();
                string respuesta = ctrl.ctrlLogin(usuario, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                /* else
                 {
                     Principal frm = new Principal();
                     frm.Visible = true;
                     this.Visible = false;
                 }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
        //METODO PARA ABRIR EN EL PANEL
      /* private void AbrirFormhijo(Form formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }*/
       
        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            Registrar re = new Registrar();
            re.Show();
            //AbrirFormhijo(new Registrar());
           //this.Close();
        }
    }
    
}
