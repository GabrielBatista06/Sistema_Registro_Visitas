using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.VISITAS' Puede moverla o quitarla según sea necesario.
            this.VISITASTableAdapter.Fill(this.DataSet1.VISITAS);

            this.reportViewer1.RefreshReport();
        }


    }
}
