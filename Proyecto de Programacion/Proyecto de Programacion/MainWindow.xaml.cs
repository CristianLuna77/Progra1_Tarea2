using Proyecto_de_Programacion.clases.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto_de_Programacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Conectar_MySql()
        {         
            ClsConexiones cn = new ClsConexiones();
            string sentencial_sql = "";
            cn.EjecutaSQLDirecto(sentencial_sql);
           
        }

 
        private void ButtonConectar_Click(object sender, RoutedEventArgs e)
        {
            Conectar_MySql();
        }

        public DataTable CargarDatos2(string condicion = "1=1")
        {
            ClsConexiones cn = new ClsConexiones();
            DataTable dt = new DataTable();
            string sentencia = $"select * from databasesjl.ingreso";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;

        }

        public DataTable CargarDatosDB(string condicion = "1=1")
        {
            ClsConexiones cn = new ClsConexiones();
            DataTable dt = new DataTable();
            string sentencia = $"select * from databasesjl.ingreso where {condicion} ";
            dt = cn.consultaTablaDirecta(sentencia);           
            return dt;

        }

        private void Controlador(String instruccion)
        {
            ClsConexiones cn = new ClsConexiones();
            cn.EjecutaSQLDirecto(instruccion);
            CargarDatosDB();

        }
        

        public DataTable borrar()
        {
            var dt = CargarDatosDB();

            foreach (DataRow dr in dt.Rows)
            {

                listno.Items.Clear();
                listname.Items.Clear();
                listedad.Items.Clear();
                listlugar.Items.Clear();
                listel.Items.Clear();
                listfecha.Items.Clear();
            }
            return dt;
        }

        public DataTable Cargar_ActualizarLista()
        {
            
            var dt = CargarDatosDB();

            foreach (DataRow dr in dt.Rows)
            {


                string no = dr["codigo_regalo"].ToString();
                string name = dr["nombre"].ToString();
                string edad = dr["edad"].ToString();
                string lugar = dr["lugar"].ToString();
                string tel = dr["num_telefono"].ToString();
                string fecha = dr["fecha"].ToString();
                string resul = "";
                resul = resul + $"{no} {name} {edad}";
                listno.Items.Add(no);
                listname.Items.Add(name);
                listedad.Items.Add(edad);
                listlugar.Items.Add(lugar);
                listel.Items.Add(tel);
                listfecha.Items.Add(fecha);
               
                

            }

            return dt;
        }

        private void buscartodo_Click(object sender, RoutedEventArgs e)
        {
            
            
            Cargar_ActualizarLista();
            
            
           
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            string id = texboxNumero.Text;
            string instruccion = $"delete from databasesjl.ingreso where codigo_regalo = {id}";
            Controlador(instruccion);
        }

        private bool existeRegistro(string id)
        {
            string condicion = $"codigo_regalo = {id}";
            DataTable dt = CargarDatosDB(condicion);
            return (dt.Rows.Count > 0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string no = TextBoxNumeros.Text;
            string name = TextBoxName.Text;
            string edad = TextBoxEdad.Text;
            string lugar = TextBoxLugar.Text;
            string tel = TextBoxTelefono.Text;
            string fecha = "current_timestamp()";
            string instruccion = $"insert into  databasesjl.ingreso (codigo_regalo,nombre,edad,lugar,num_telefono,fecha) values ({no},'{name}',{edad} ,'{lugar}' ,'{tel}',{fecha});";
            if (existeRegistro(no))
            {
                TextBoxNumeros.Text = "El registro ya existe!";

            }
            else
            {
                Controlador(instruccion);
            }
            
        }



        private void masterr()
        {


            string ruta = @"C:\Users\Cristian Luna\Desktop\proyecto progra.csv";
            File.WriteAllText(ruta, $"{listname}");



        }
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            masterr();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            borrar();
        }
    }

}
