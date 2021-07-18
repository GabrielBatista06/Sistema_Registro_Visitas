using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;
using Capa_Entidades.Cache;



namespace Capa_Presentacion
{
    public partial class Login : Form
    {   
        
        N_Visitas visitas = new N_Visitas();
        
        public Login()
        {
            InitializeComponent();
        }
        // Verificar Usuario
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            string resultado = visitas.login(txtusuario.Text, txtcontraseña.Text);
            //Aplicar Seguridad y Privilegios de usuario
            UserCache.tipo_usuario = resultado;
            

            if (resultado == "ADMINISTRADOR")
            {
                //Progressbar
                pgblogin.Visible = true;
                pgblogin.Minimum = 1;
                pgblogin.Maximum = 10000;
                pgblogin.Step = 8;
                for (int i = 0; i < 10000; i++)
                {
                    pgblogin.PerformStep();
                }
                this.Hide();
                new Registrar_Visitas().Show();
            }else if (resultado == "GENERAL")
            {
                pgblogin.Visible = true;
                pgblogin.Minimum = 1;
                pgblogin.Maximum = 10000;
                pgblogin.Step = 8;
                for (int i = 0; i < 10000; i++)
                {
                    pgblogin.PerformStep();
                }
                this.Hide();
                new Registrar_Visitas().Show();

            }
            else
            {
                pgblogin.Visible = true;
                pgblogin.Minimum = 1;
                pgblogin.Maximum = 10000;
                pgblogin.Step = 8;
                for (int i = 0; i < 10000; i++)
                {
                    pgblogin.PerformStep();
                }
                MessageBox.Show("Usuario y/o contraseña incorrecta");
                pgblogin.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
        }

        private void txtcontraseña_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text = "";
        }

        private void txtcontraseña_TextChanged_1(object sender, EventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = true; 
        }

    }
}
