using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;
using System.Data;
using System.Windows.Forms;
using Capa_Entidades.Cache;
using System.IO;
using System.Data.Sql;

namespace Capa_datos
{
    public class D_Visitas
    
    {
      //--------------//
      
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;
       
        //------------------//
        public DataTable dt;
        /*Definiendo nuestra conexion a la base de datos*/
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //Verificando tipo de usuario
        public string Verificar_Usuario(string usuario, string pass)
        {

            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("SP_VALIDAR_USUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NOMBRE_DE_USUARIO", usuario);
                cmd.Parameters.AddWithValue("@CONTRASEÑA", pass);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    return reader.GetString(0);
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error" + e.Message);
            }

            finally
            {
                conexion.Close();
            }

            return null;
        }

        //Registrando Visitas

        public void Registrar_Visita(E_Visitas _Visitas)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_AGREGAR_VISITA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRES", _Visitas.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDOS", _Visitas.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", _Visitas.Carrera);
            cmd.Parameters.AddWithValue("@CORREO", _Visitas.Correo);
            cmd.Parameters.AddWithValue("@EDIFICIO", _Visitas.Edificio);
            cmd.Parameters.AddWithValue("@FECHA_Y_HORA_DE_ENTRADA", _Visitas.Hora_Fecha_Entrada);
            cmd.Parameters.AddWithValue("@FECHA_Y_HORA_DE_SALIDA ", _Visitas.Hora_Fecha_Salida);
            cmd.Parameters.AddWithValue("@FOTO", _Visitas.Foto);
            cmd.Parameters.AddWithValue("@MOTIVO_DE_VISITA", _Visitas.Motivo);
            cmd.Parameters.AddWithValue("@AULA_DIRIGE ", _Visitas.Dirige);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //LISTAR VISITAS

        public List<E_Visitas> ListarVisitas(int buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_VISITAS_POR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@EDIFICIO", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Visitas> Listar = new List<E_Visitas>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Visitas
                {


                    Id = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Carrera = LeerFilas.GetString(3),
                    Correo = LeerFilas.GetString(4),
                    Edificio = LeerFilas.GetInt32(5),
                    Dirige = LeerFilas.GetString(6),
                    Motivo = LeerFilas.GetString(7),
                    Hora_Fecha_Entrada = LeerFilas.GetDateTime(8),
                    Hora_Fecha_Salida = LeerFilas.GetDateTime(9),
                   
                }) ; 
            }

            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }
        //Mostrar visitas
        public List<E_Visitas> Mostrar_Visitas()
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_LISTAR_VISITAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            LeerFilas = cmd.ExecuteReader();

            List<E_Visitas> Listar = new List<E_Visitas>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Visitas
                {
                    Id = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Carrera = LeerFilas.GetString(3),
                    Correo = LeerFilas.GetString(4),
                    Edificio = LeerFilas.GetInt32(5),
                    Dirige = LeerFilas.GetString(6),
                    Motivo = LeerFilas.GetString(7),
                    Hora_Fecha_Entrada = LeerFilas.GetDateTime(8),
                    Hora_Fecha_Salida = LeerFilas.GetDateTime(9),
                   

                }) ; 
            }

            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        //Cargar cbx edificio

        public DataTable Cargar_cbx_Edificio()
        {
            try
            {
                dt = new DataTable();
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_CARGAR_CBX_EDIFICIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                reader.Fill(dt);

            
            }
            catch (Exception error)
            {

                MessageBox.Show("No se pudo listar el cbx edificio" + error.Message);

            }
            finally
            {
                conexion.Close();
            }
            return dt;
        }
        //Cargar cbx area
        public DataTable Cargar_cbx_Seccion(int id_Edificio)
        {
            try
            {
                dt = new DataTable();
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_CARGAR_CBX_AULA", conexion);
                cmd.Parameters.AddWithValue("@ID_EDIFICIO", id_Edificio);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                reader.Fill(dt);

            }
            catch (Exception error)
            {

                MessageBox.Show("No se pudo listar el cbx edificio" + error.Message);

            }
            finally
            {
                conexion.Close();
            }
            return dt;
        }

        //Registra usuario
        public void Registrar_Usuario(E_Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_USUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRES", usuario.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDOS", usuario.Usuario);
            cmd.Parameters.AddWithValue("@FECHA_DE_NACIMIENTO", usuario.Fecha_Nacimiento);
            cmd.Parameters.AddWithValue("@TIPO_DE_USUARIO", usuario.Tipo_Usuario);
            cmd.Parameters.AddWithValue("@NOMBRE_DE_USUARIO", usuario.Usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", usuario.Pass);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        //Listar usuario
        public List<E_Usuario> Listar_Usuarios()
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_LISTAR_USUARIOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            LeerFilas = cmd.ExecuteReader();

            List<E_Usuario> Listar = new List<E_Usuario>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Usuario
                {
                    Id = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Fecha_Nacimiento = LeerFilas.GetDateTime(3),
                    Tipo_Usuario = LeerFilas.GetString(4),
                    Usuario = LeerFilas.GetString(5),
                    Pass = LeerFilas.GetString(6),

                });
            }

            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }
        //Listar secciones
        public List<E_Seccion> Listar_Seciones()
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_CARGAR_SECCIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            LeerFilas = cmd.ExecuteReader();

            List<E_Seccion> Listar = new List<E_Seccion>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Seccion
                {
                    Id__Seccion = LeerFilas.GetInt32(0),
                    Nombre_Area = LeerFilas.GetString(1),
                    Numeros_Edificio = LeerFilas.GetInt32(2),

                });
            }

            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        //Agregando edificio
        public void Registrar_Edificio(E_Edificio edificio)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@NUMERO_DE_EDIFICIO", edificio.Numero_edificio);
            cmd.Parameters.AddWithValue("@NOMBRE_SECCION ", edificio.Seccion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //Agregando areas
        public void Registrar_Areas(E_Secciones secciones)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_AGREGAR_SECCION", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@NUMERO_DE_EDIFICIO", secciones.Numero_Edificio);
            cmd.Parameters.AddWithValue("@NOMBRE_SECCION ", secciones.Nombre_Seccion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //Actulizando edificio
        public void Editar_Edificio(E_Secciones edificio)
        {

            SqlCommand cmd = new SqlCommand("SP_MODIFICAR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NUMERO_DE_EDIFICIO", edificio.Numero_Edificio);
            cmd.Parameters.AddWithValue("@NOMBRE_SECCION_VIEJO", edificio.Nombre_Seccion);
            cmd.Parameters.AddWithValue("@NOMBRE_SECCION_NUEVO", edificio.Nueva_Area);
            
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        //Cargar todas las areas a cbx
        public void Llenar_Combobox_Area(ComboBox cmb)
        {
            conexion.Close();
      
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_CARGAR_AREAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            leer = cmd.ExecuteReader();

            while (leer.Read())
            {
                cmb.Items.Add(leer["NOMBRE"].ToString());
            }
            conexion.Close();
            leer.Close();

        }

        //CARGAR CBX ID_VISITAS
        public void Llenar_Combobox_Id_Visitas(ComboBox cmb)
        {

            try
            {
                conexion.Close();

                SqlDataReader leer;
                SqlCommand cmd = new SqlCommand("SP_CARGAR_ID", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                leer = cmd.ExecuteReader();

                while (leer.Read())
                {
                    cmb.Items.Add(leer["NOMBRES"].ToString());
                }
                conexion.Close();
                leer.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show("No se pudo cargar el CBX Id_Visitas" + error.Message);
            }
     

        }


        //Mostrar imagen
        public void verImagen(PictureBox pbFoto, string descripcion)
        {
            try
            {
                da = new SqlDataAdapter("Select FOTO from VISITAS where NOMBRES = '" + descripcion + "'", conexion);
                ds = new DataSet();
                da.Fill(ds, "VISITAS");
                byte[] datos = new byte[0];
                dr = ds.Tables["VISITAS"].Rows[0];
                datos = (byte[])dr["FOTO"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
            }
        }


    }
}
