using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Visitas
    {   //Visitas------>
        private int id;
        private string nombre;
        private string apellido;
        private string carrera;
        private string correo;
        private int edificio;
        private DateTime hora_Fecha_Entrada;
        private DateTime hora_Fecha_Salida;
        private byte[] foto;
        private string motivo;
        private string dirige;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime Hora_Fecha_Entrada { get => hora_Fecha_Entrada; set => hora_Fecha_Entrada = value; }
        public DateTime Hora_Fecha_Salida { get => hora_Fecha_Salida; set => hora_Fecha_Salida = value; }
        public byte[] Foto { get => foto; set => foto = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Dirige { get => dirige; set => dirige = value; }
        public int Edificio { get => edificio; set => edificio = value; }
    }

    public class E_Edificio
    {
        //Cargar cbx edificio
        private int id_edificio;
        private int numero_edificio;
        private string seccion;

        public int Id_edificio { get => id_edificio; set => id_edificio = value; }
        public int Numero_edificio { get => numero_edificio; set => numero_edificio = value; }
        public string Seccion { get => seccion; set => seccion = value; }
    }
        //Cargar cbx Secciones
    public class E_Secciones
    {
        private int id_Seccion;
        private string nombre_Seccion;
        private int id_Edificio;
        private int numero_Edificio;
        private string nueva_Area;

        public int Id_Seccion { get => id_Seccion; set => id_Seccion = value; }
        public string Nombre_Seccion { get => nombre_Seccion; set => nombre_Seccion = value; }
        public int Id_Edificio { get => id_Edificio; set => id_Edificio = value; }
        public int Numero_Edificio { get => numero_Edificio; set => numero_Edificio = value; }
        public string Nueva_Area { get => nueva_Area; set => nueva_Area = value; }
    }

    //Listar Secciones

    public class E_Seccion
    {
        private int id__Seccion;
        private string nombre_Area;
        private int numeros_Edificio;

        public int Id__Seccion { get => id__Seccion; set => id__Seccion = value; }
        public string Nombre_Area { get => nombre_Area; set => nombre_Area = value; }
        public int Numeros_Edificio { get => numeros_Edificio; set => numeros_Edificio = value; }
    }

    //Registrar usuario

    public class E_Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private DateTime fecha_Nacimiento;
        private string tipo_Usuario;
        private string usuario;
        private string pass;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Fecha_Nacimiento { get => fecha_Nacimiento; set => fecha_Nacimiento = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Tipo_Usuario { get => tipo_Usuario; set => tipo_Usuario = value; }
    }
    //Aplicar Seguridad y Privilegios de usuario
    public struct Positions 
    {
        public const string ADMINISTRADOR = "ADMINISTRADOR";
        public const string GENERAL = "GENERAL";
    }


}
