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

namespace Capa_Presentacion
{
    public partial class Registrar_Usuario : Form
    {
        E_Usuario obj_visitas = new E_Usuario();
        N_Visitas visitas = new N_Visitas();
        public Registrar_Usuario()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomTextbox1_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
        }

        private void bunifuCustomTextbox1_Click_1(object sender, EventArgs e)
        {
            txtapellido.Text = "";
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            cbxusuario.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
        }

        private void txtpass1_Click(object sender, EventArgs e)
        {
            
            txtpass1.Text = "";
        }

        private void txtpass2_Click(object sender, EventArgs e)
        {
            
            txtpass2.Text = "";
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtnombre.Text == "NOMBRE")
                {
                    MessageBox.Show("Digite Nombres para Continuar para Continuar", "Registro_Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnombre.Focus();
                }
                else if (txtapellido.Text == "APELLIDO")
                {
                    MessageBox.Show("Digite Apellidos para Continuar para Continuar", "Registro_Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtapellido.Focus();
                }
                else if (cbxusuario.Text == "TIPO DE USUARIO")
                {
                    MessageBox.Show("Elija el tipo de usuario para Continuar", "Registro_Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbxusuario.Focus();
                }
                else if (txtusuario.Text == "USER")
                {
                    MessageBox.Show("Ingrese un nombre de usuario para Continuar", "Registro_Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtusuario.Focus();
                }

                else if (txtpass1.Text == "PASSWORD")
                {
                    MessageBox.Show("Ingrese una contraseña para Continuar", "Registro_Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtpass1.Focus();
                }               
                else if (txtpass2.Text == "VERIFICAR PASSWORD")
                {
                    MessageBox.Show("Verificar contraseñas para Continuar ", "Registro_Usuariopara Continuar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtpass1.Focus();
                }
                else if (txtpass1.Text != txtpass2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden ", "Registro_Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtpass2.Focus();
                }

                else
                {
                    obj_visitas.Nombre = txtnombre.Text.ToUpper();
                    obj_visitas.Apellido = txtapellido.Text.ToUpper();
                    obj_visitas.Fecha_Nacimiento = dtpfecha.Value;
                    obj_visitas.Tipo_Usuario = cbxusuario.Text.ToUpper();
                    obj_visitas.Usuario = txtusuario.Text.ToUpper();
                    obj_visitas.Pass = txtpass1.Text.ToUpper();
                    visitas.Registrar_Usuario(obj_visitas);

                    MessageBox.Show("Se guardo el registro");
                    mostrardatos();
                    limpiar();

                }
            }

            catch (Exception )
            {

                MessageBox.Show("Ya existe un usuario con contraseña y/o nombre usuario igual" );
            }

           
        }

        private void txtpass1_TextChanged(object sender, EventArgs e)
        {
            txtpass1.UseSystemPasswordChar = true;
        }

        private void txtpass2_TextChanged(object sender, EventArgs e)
        {
            txtpass2.UseSystemPasswordChar = true;
        }
        //Metodo limpiar cajas
        public void limpiar()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtusuario.Text = "";
            txtpass1.Text = "";
            txtpass2.Text = "";
            txtnombre.Focus();
        }
        //Metodo mostrar usuarios
        public void mostrardatos()
        {
            dtgusuario.DataSource = visitas.Listar_Usuarios();
        }

        private void Registrar_Usuario_Load(object sender, EventArgs e)
        {
            mostrardatos();
            ocultar();
        }
        public void ocultar()
        {
            dtgusuario.Columns[0].Visible = false;
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registrar_Visitas().Show();
        }
    }
}
