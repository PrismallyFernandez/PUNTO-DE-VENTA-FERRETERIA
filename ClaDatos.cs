using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient.Memcached;

namespace Proyecto_Final
{
    public class ClaDatos
    {
    
        public MySqlConnection conex = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; " +
                    "pwd= '' ; database=ferreteriestrella");

        public DataTable consulta(string strSql)
        {
            DataTable tabla = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(strSql, conex);
            da.Fill(tabla);
            return tabla;

        }

        public void CrearFacturas(ClaVentas Ventas)
        {
            string strSql = "crear_factura";
            MySqlCommand cmd = new MySqlCommand(strSql, conex);
            conex.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_CLIENTE", Ventas.IDCLIENTE);
            cmd.Parameters.AddWithValue("@MONTO", Ventas.MONTO);
            cmd.Parameters.AddWithValue("@TIPO", Ventas.TIPO);
            cmd.Parameters.AddWithValue("@FECHA", Ventas.FechaVenta);
            cmd.ExecuteNonQuery();
            conex.Close();
        }
        public void CrearClientes(ClaClientes Clientes)
        {
            string strSql = "crear_cliente";
            MySqlCommand cmd = new MySqlCommand(strSql, conex);
            conex.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", Clientes.NOMBRE);
            cmd.Parameters.AddWithValue("@cedula", Clientes.CEDULA);
            cmd.Parameters.AddWithValue("@telefono", Clientes.TELEFONO);
            cmd.Parameters.AddWithValue("@direccion", Clientes.DIRECCION);
            cmd.Parameters.AddWithValue("@ESTADO", Clientes.ESTADO);

            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public void ActualizarClientes(ClaClientes Clientes)
        {
            string strSql = "actualizar_cliente";
            MySqlCommand cmd = new MySqlCommand(strSql, conex);
            conex.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", Clientes.ID);
            cmd.Parameters.AddWithValue("@NOMBRE", Clientes.NOMBRE);
            cmd.Parameters.AddWithValue("@CEDULA", Clientes.CEDULA);
            cmd.Parameters.AddWithValue("@TELEFONO", Clientes.TELEFONO);
            cmd.Parameters.AddWithValue("@DIRECCION", Clientes.DIRECCION);
            cmd.Parameters.AddWithValue("@ESTADO", Clientes.ESTADO);

            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public void CrearProductos(ClaProductos Productos)
        {
            string strSql = "crear_producto";
           MySqlCommand cmd = new MySqlCommand(strSql, conex);
            conex.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descripcion", Productos.DESCRIPCION);
            cmd.Parameters.AddWithValue("@costo", Productos.COSTO);
            cmd.Parameters.AddWithValue("@precio",Productos.PRECIO);
            cmd.Parameters.AddWithValue("@estado", Productos.ESTADO);
            cmd.Parameters.AddWithValue("@suplidor",Productos.SUPLIDOR);
            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public void ActualizarProductos(ClaProductos Productos)
        {
            string strSql = "actualizar_producto";
            MySqlCommand cmd = new MySqlCommand(strSql, conex);
            conex.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", Productos.ID);
            cmd.Parameters.AddWithValue("@DESCRIPCION", Productos.DESCRIPCION);
            cmd.Parameters.AddWithValue("@COSTO", Productos.COSTO);
            cmd.Parameters.AddWithValue("@PRECIO", Productos.PRECIO);
            cmd.Parameters.AddWithValue("@ESTADO", Productos.ESTADO);
            cmd.Parameters.AddWithValue("@SUPLIDOR", Productos.SUPLIDOR);
            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public void CrearEmpleados(ClaEmpleados Empleados)
        {
            string strSql = "crear_empleado";
            MySqlCommand cmd = new MySqlCommand(strSql, conex);
            conex.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", Empleados.NOMBRE);
            cmd.Parameters.AddWithValue("@SEXO", Empleados.SEXO);
            cmd.Parameters.AddWithValue("@CEDULA", Empleados.CEDULA);
            cmd.Parameters.AddWithValue("@TELEFONO", Empleados.TELEFONO);
            cmd.Parameters.AddWithValue("@DIRECCION", Empleados.DIRECCION);
            cmd.Parameters.AddWithValue("@POSICION", Empleados.POSICION);
            cmd.Parameters.AddWithValue("@ESTADO", Empleados.ESTADO);


            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public void ActualizarEmpleados(ClaEmpleados Empleados)
        {
            string strSql = "actualizar_empleado";
            MySqlCommand cmd = new MySqlCommand(strSql, conex);
            conex.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", Empleados.ID);
            cmd.Parameters.AddWithValue("@NOMBRE", Empleados.NOMBRE);
            cmd.Parameters.AddWithValue("@SEXO", Empleados.SEXO);
            cmd.Parameters.AddWithValue("@CEDULA", Empleados.CEDULA);
            cmd.Parameters.AddWithValue("@TELEFONO", Empleados.TELEFONO);
            cmd.Parameters.AddWithValue("@DIRECCION", Empleados.DIRECCION);
            cmd.Parameters.AddWithValue("@POSICION", Empleados.POSICION);
            cmd.Parameters.AddWithValue("@ESTADO", Empleados.ESTADO);

            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public void CrearSuplidores(ClaSuplidores Suplidores)
        {
            string strSql = "crear_suplidor";
            MySqlCommand cmd = new MySqlCommand(strSql, conex);
            conex.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", Suplidores.NOMBRRE);
            cmd.Parameters.AddWithValue("@TELEFONO", Suplidores.TELEFONO);
            cmd.Parameters.AddWithValue("@RNC", Suplidores.RNC);
            cmd.Parameters.AddWithValue("@DIRECCION", Suplidores.DIRECCION);
            cmd.Parameters.AddWithValue("@ESTADO", Suplidores.ESTADO);

            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public void ActualizarSuplidores(ClaSuplidores Suplidores)
        {
            string strSql = "actualizar_suplidor";
            MySqlCommand cmd = new MySqlCommand(strSql, conex);
            conex.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", Suplidores.ID);
            cmd.Parameters.AddWithValue("@NOMBRE", Suplidores.NOMBRRE);
            cmd.Parameters.AddWithValue("@TELEFONO", Suplidores.TELEFONO);
            cmd.Parameters.AddWithValue("@RNC", Suplidores.RNC);
            cmd.Parameters.AddWithValue("@DIRECCION", Suplidores.DIRECCION);
            cmd.Parameters.AddWithValue("@ESTADO", Suplidores.ESTADO);

            

            cmd.ExecuteNonQuery();
            conex.Close();
        }


    }
}