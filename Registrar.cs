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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void BotonRegistrarse_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Nombre = textoNombre.Text;
            usuario.Password = TextoContraseña.Text;
            usuario.ConPassword = textoconfirma.Text;

            try
            {

                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Login login = new Login();
            //login.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           // TextBox tt = new TextBox();
            //tt.MaxLength = 8;
            //tt.textBox2_TextChanged = "*";
        }
    }
}  

