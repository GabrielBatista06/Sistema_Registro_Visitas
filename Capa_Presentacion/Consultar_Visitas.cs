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
    public partial class Consultar_Visitas : Form
    {
       
        E_Visitas obj_visitas = new E_Visitas();
        N_Visitas visitas = new N_Visitas();
        public Consultar_Visitas()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Consultar_Visitas_Load(object sender, EventArgs e)
        {
           
            
            Cargar_Cbx_Edificio();
        }

        public void Buscar_Mostrar(int buscar)
        {
            //Mostramos los datos en nuestro dgv
            dtgvisitas.DataSource = visitas.Listar_Visitas(buscar);
        }
        public void ocultar()
        {
            dtgvisitas.Columns[0].Visible = false;
            dtgvisitas.Columns[7].Visible = false;
        }


        public void Cargar_Cbx_Edificio()
        {
            //Metodo listar cbx edificio
            cbxedificio.ValueMember = "ID_EDIFICIO";
            cbxedificio.DisplayMember = "NUMERO_DE_EDIFICIO";
            cbxedificio.DataSource = visitas.listar_cbx_edificio();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Buscar_Mostrar(Convert.ToInt32(cbxedificio.Text));
            ocultar();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Mensaje de pregunta que si realmente desea cambiar de ventana
            MessageBoxButtons usuario = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Desea volver hay menu principal", "CONSULTAR_VISITAS", usuario, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)

                new Registrar_Visitas ().ShowDialog();
            else

                new Consultar_Visitas().ShowDialog();
        }
    }
}
