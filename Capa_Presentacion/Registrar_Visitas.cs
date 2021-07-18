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
using System.IO;
using Capa_Entidades.Cache;


namespace Capa_Presentacion
{
    public partial class Registrar_Visitas : Form
    {

        string edificio;
        int id;

        E_Usuario e_Usuario = new E_Usuario();
        E_Visitas obj_visitas = new E_Visitas();
        N_Visitas visitas = new N_Visitas();
        public Registrar_Visitas()
        {
            InitializeComponent();
        }

        private void Registrar_Visitas_Load(object sender, EventArgs e)
        {
            //Aplicar Seguridad y Privilegios de usuario
            if (UserCache.tipo_usuario == Positions.GENERAL)
            {
                actualizar.Enabled = false;
            }
            txtsaludo.Text = UserCache.tipo_usuario;

            //Llamamos nuestro metodo mostrardatos y ocultar en el evento_Load
            mostrardatos();
            ocultar();
            Cargar_Cbx_Edificio();
            Cargar_Nombre();
            cbxfoto.SelectedIndex = 0;
            
        }           

        private void ptbsalir_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void ptbminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Metodo para limpiar los campos
        private void limpiarcaja()
        {         
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtcarrera.Text = "";
            txtcorreo.Text = "";
            txtmotivo.Text = "";
            cbxedificio.Text = "ELIJA EDIFICIO";
            cbxarea.Text = "ELIJA AREA";

            txtnombre.Focus();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // Obtenemos la imagen
            OpenFileDialog examinar = new OpenFileDialog();
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            txtexaminar.Text= examinar.FileName;
            ptbfoto.Image = Image.FromFile(examinar.FileName);
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {  
                //Validando los campos que sean obligatorios esten completos
                
                if (txtnombre.Text == "")
                {
                    MessageBox.Show("Digite Nombres para Continuar", "Registro_Visita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnombre.Focus();
                }
                else if (txtapellido.Text == "")
                {
                    MessageBox.Show("Digite Apellidos para Continuar", "Registro_Visita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtapellido.Focus();
                }
                else if (cbxedificio.Text == "ELIJA EDIFICIO")
                {
                    MessageBox.Show("Elija el edificio hacia donde se dirige", "Registro_Visita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbxedificio.Focus();
                }
                else if (cbxarea.Text == "ELIJA AREA")
                {
                    MessageBox.Show("Elija el area hacia donde se dirige", "Registro_Visita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbxarea.Focus();
                }  
                
                else if(txtexaminar.Text == "")                
                {
                    MessageBox.Show("Cargue una fotografia para Continuar", "Registro_Visita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnexaminar.Focus();
                }
                
                else
                {                
                    
                    FileStream stream = new FileStream(txtexaminar.Text, FileMode.Open, FileAccess.Read);
                    //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
                    BinaryReader br = new BinaryReader(stream);
                    FileInfo fi = new FileInfo(txtexaminar.Text);

                    //Se inicializa un arreglo de Bytes del tamaño de la imagen
                    byte[] binData = new byte[stream.Length];
                    //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                    //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
                    stream.Read(binData, 0, Convert.ToInt32(stream.Length));

                    ////Se muetra la imagen obtenida desde el flujo de datos
                    ptbfoto.Image = Image.FromStream(stream);

                    obj_visitas.Nombre = txtnombre.Text.ToUpper();
                    obj_visitas.Apellido = txtapellido.Text.ToUpper();
                    obj_visitas.Carrera = txtcarrera.Text.ToUpper();
                    obj_visitas.Correo = txtcorreo.Text.ToUpper();
                    obj_visitas.Edificio =Convert.ToInt32(cbxedificio.Text);
                    obj_visitas.Hora_Fecha_Entrada = dtpentrada.Value;
                    obj_visitas.Hora_Fecha_Salida = dtpsalida.Value;
                    obj_visitas.Foto = binData;
                    obj_visitas.Motivo = txtmotivo.Text.ToUpper();
                    obj_visitas.Dirige = cbxarea.Text;

                    visitas.Registrar_Visita(obj_visitas);

                    MessageBox.Show("Se registro la visita");
                    mostrardatos();
                    limpiarcaja();
                    cbxfoto.Items.Clear();
                    Cargar_Nombre();
                }

            }

            catch (Exception error)
            {
                MessageBox.Show("No se pudo registrar la visita" + error.Message);
            }
        }
        //Metodo mostrar datos en dgv
        public void mostrardatos ()
        {
            dtgvisitas.DataSource = visitas.Mostrar_Visitas();
        }
        //Metodo ocultar columnas 
        public void ocultar()
        {
            dtgvisitas.Columns[0].Visible = false;
            dtgvisitas.Columns[7].Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            new Reportes().Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        { 
            this.Hide();
            //Mensaje de pregunta que si realmente desea cambiar de usuario
            MessageBoxButtons usuario = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Desea cambiar de usuario", "Registro_Visita", usuario, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)

                new Login().ShowDialog();
            else
                
                new Registrar_Visitas().ShowDialog();
                     
        }

        public void Cargar_Cbx_Edificio()
        {
            //Metodo listar cbx edificio
            cbxedificio.ValueMember = "NUMERO_DE_EDIFICIO";
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

        private void cbxedificio_SelectedIndexChanged(object sender, EventArgs e)
        {   //Evento para pasar el valor hay cbx Area
            edificio = cbxedificio.SelectedValue.ToString();
            id = Convert.ToInt32(edificio);
            Cargar_Cbx_Seccion(id);
        }

        private void edificio_area_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Actualizar_Aulas_Edificio().Show();
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registrar_Usuario().Show();
        }

        private void cbxfoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            visitas.Mostrar_Imagen(ptbfoto, cbxfoto.SelectedItem.ToString());
        }

        public void Cargar_Nombre()
        {
            visitas.Cargar_cbx_Id_Visitas(cbxfoto);
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Consultar_Visitas().Show();
        }
    }
}
