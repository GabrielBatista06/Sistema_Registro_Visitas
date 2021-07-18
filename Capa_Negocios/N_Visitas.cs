using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_datos;
using System.Data;
using System.Windows.Forms;

namespace Capa_Negocio
{
    public class N_Visitas
    {

        D_Visitas visitas = new D_Visitas();

        //Verificar Usuario
        public string login(string usuario, string pass)
        {
            return visitas.Verificar_Usuario(usuario, pass);
        }

        //Registrando Visita
        public void Registrar_Visita(E_Visitas _visitas)
        {
            visitas.Registrar_Visita(_visitas);
        }
        //Listar visitas 
        public List<E_Visitas> Mostrar_Visitas()
        {
             return visitas.Mostrar_Visitas();
        }
        //Listar visitas para busqueda
        public List<E_Visitas> Listar_Visitas(int buscar)
        {
            return visitas.ListarVisitas(buscar);
        }
        //Listar cbx edificio
        public DataTable listar_cbx_edificio()
        {
            return visitas.Cargar_cbx_Edificio();
        }
        //Listar cbx area
        public DataTable listar_cbx_Seccion(int id_Edificio)
        {
            return visitas.Cargar_cbx_Seccion(id_Edificio);
        }
        //Registrar usuario
        public void Registrar_Usuario(E_Usuario _Usuario)
        {
            visitas.Registrar_Usuario(_Usuario);

        }

        //Registrar Areas
        public void Registrar_Areas(E_Secciones secciones)
        {
            visitas.Registrar_Areas(secciones);
        }

        //Actualizar edificio
        public void Actualizar_Edificio(E_Secciones e_Secciones)
        {
            visitas.Editar_Edificio(e_Secciones);
        }
        //Listar usuario
        public List<E_Usuario> Listar_Usuarios()
        {
            return visitas.Listar_Usuarios();
        }
        
        //Listar Secciones
        public List<E_Seccion> Listar_Secciones()
        {
            return visitas.Listar_Seciones();
        }

        //Registrando edificio

        public void Registrando_Edificio(E_Edificio _Edificio)
        {
            visitas.Registrar_Edificio(_Edificio);
        }
        //Cargando todas las areas a cbx
        public void Cargar_cbx_Areas(ComboBox comboBox)
        {
            visitas.Llenar_Combobox_Area(comboBox);
        }
        //CARGAR CBX ID_VISITAS
        public void Cargar_cbx_Id_Visitas(ComboBox comboBox)
        {
            visitas.Llenar_Combobox_Id_Visitas(comboBox);
        }
        //mostrar foto

        public void Mostrar_Imagen(PictureBox picture , string descripcion)
        {
            visitas.verImagen(picture, descripcion);
        }

    }
}
