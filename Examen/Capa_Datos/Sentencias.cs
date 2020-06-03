using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Datos
{
   public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;
        //--------------------------------------------------------------------Metodos General--------------------------------------------------------------------//
        public string obtenerfinal(string tabla, string campo)
        {
            String camporesultante = "";
            try
            {
                string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(sql, cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();
                //Console.WriteLine("El resultado es: " + camporesultante);
                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;
        }

        public OdbcDataReader Insertar(string[] datos)
        {
            string query = "";
            for (int i = 1; i < datos.Length; i++)
            {
                query += "'";
                query += datos[i];
                if (i == datos.Length - 1)
                    query += "'";
                else
                    query += "',";
            }
            try
            {
                cn.conexionbd();
                string consulta = "insert into " + datos[0] + " values(" + query + ");";
                //Console.WriteLine(consulta);
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader Eliminar(string[] datos)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE " + datos[0] + " set estado='0' where " + datos[2] + " = '" + datos[1] + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader Modificar(string[] datos, string[] campos)
        {
            string query = "";
            int n = 1;
            query += " set ";
            for (int i = 2; i < datos.Length; i++)
            {
                query += campos[n];
                query += " = '";
                query += datos[i];
                if (i == datos.Length - 1)
                    query += "'";
                else
                    query += "',";
                n++;
            }

            try
            {
                cn.conexionbd();
                string consulta = "UPDATE " + datos[0] + query + " where " + campos[0] + " = '" + datos[1] + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consultaCliente()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM clientes;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consultaVendedor()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM vendedores;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consultaProveedor()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM proveedores;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consultaPagar()
        {
            try
            {
                cn.conexionbd();
                string consulta = "select C.codigo_proveedor, P.nombre_proveedor,sum(total_compraenca) from compras_encabezado C inner join proveedores P on C.codigo_proveedor = P.codigo_proveedor group by C.codigo_proveedor;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consultaCobrar()
        {
            try
            {
                cn.conexionbd();
                string consulta = "select V.codigo_cliente, C.nombre_cliente,sum(total_ventaenca) from ventas_encabezado V inner join clientes C on V.codigo_cliente = C.codigo_cliente group by C.codigo_cliente;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consultaAbonosClientes()
        {
            try
            {
                cn.conexionbd();
                string consulta = "select codigoCliente, sum(cantidad) from abonoclientes A group by codigoCliente;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consultaAbonosProveedores()
        {
            try
            {
                cn.conexionbd();
                string consulta = "select codigoProveedor, sum(abono) from abonosproveedores group by codigoProveedor;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
