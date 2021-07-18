using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;

namespace Capa_Presentacion
{
    public partial class Actualizar_Aulas_Edificio : Form
    {
        E_Edificio obj_visitas = new E_Edificio();
        E_Secciones _Secciones = new E_Secciones();
        N_Visitas visitas = new N_Visitas();
        public Actualizar_Aulas_Edificio()
        {
            InitializeComponent();
        }

        public void Cargar_Cbx_Edificio()
        {
            //Metodo listar cbx edificio
            cbxedificio.ValueMember = "ID_EDIFICIO";
            cbxedificio.DisplayMember = "NUMERO_DE_EDIFICIO";
            cbxedificio.DataSource = visitas.listar_cbx_edificio();
        }

        public void Cargar_Cbx_Seccion(int id_Edificio)
        {
            //Metodo listar cbx seccion
            cbxarea.ValueMember = " ID_SECCIONES";
            cbxarea.DisplayMember = "NOMBRE";
            cbxarea.DataSource = visitas.listar_cbx_Seccion(id_Edificio);
        }

        private void Actualizar_Aulas_Edificio_Load(object sender, EventArgs e)
        {
            mostrardatos();
            cargar();
            Cargar_Cbx_Edificio();
        }


        //Cargar cajas
        public void cargar()
        {
            visitas.Cargar_cbx_Areas(cbxarea);
        }
        //Registrando edificio
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            cbxarea.Items.Clear();
            
            try
            {
                obj_visitas.Numero_edificio = Convert.ToInt32(cbxedificio.Text);
                obj_visitas.Seccion = cbxarea.Text.ToUpper();

                visitas.Registrando_Edificio(obj_visitas);
                MessageBox.Show("Se agrego un nuevo edificio");
                mostrardatos();
                cbxarea.Items.Clear();
                limpiar_cajas();
                Cargar_Cbx_Edificio();
                cargar();
                
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Registrando area
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
                
            try
            {
                _Secciones.Numero_Edificio = Convert.ToInt32(cbxedificio.Text);
                _Secciones.Nombre_Seccion = cbxarea.Text.ToUpper();

                visitas.Registrar_Areas(_Secciones);
                MessageBox.Show("Se agrego una nueva area");
                mostrardatos();
                cbxarea.Items.Clear();
                limpiar_cajas();
                cargar();
                

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Actulizando edificio
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                
                _Secciones.Numero_Edificio = Convert.ToInt32(cbxedificio.Text);
                _Secciones.Nombre_Seccion = cbxarea.Text;
                _Secciones.Nueva_Area = textBox1.Text;

                visitas.Actualizar_Edificio(_Secciones);
                MessageBox.Show("Se actualizo el area");
                mostrardatos();
                cbxarea.Items.Clear();
                limpiar_cajas();
                cargar();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
                
         
        } 
        //limpiar cajas

        public void limpiar_cajas()
        {
            cbxarea.Text = "";
            cbxedificio.Text = "";
            textBox1.Text = "";
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registrar_Visitas().Show();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Consultar_Visitas().Show();
        }

        //Metodo mostrar datos en dgv
        public void mostrardatos()
        {
            dtgvisitas.DataSource = visitas.Listar_Secciones();
        }
    }
}
