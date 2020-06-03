using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using Capa_Datos;

namespace Capa_Logica
{
    public class Logica
    {
        Sentencias sn = new Sentencias();
        /*-----------------------------------------------------------------------Metodos Generales------------------------------------------------------------*/
        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }
        public OdbcDataReader Insertar(string[] datos)
        {
            return sn.Insertar(datos);
        }
        public OdbcDataReader Eliminar(string[] datos)
        {
            return sn.Eliminar(datos);
        }

        public OdbcDataReader Modificar(string[] datos, string[] campos)
        {
            return sn.Modificar(datos, campos);
        }
        public OdbcDataReader consultaCliente()
        {
            return sn.consultaCliente();
        }
        public OdbcDataReader consultaVendedor()
        {
            return sn.consultaVendedor();
        }
        public OdbcDataReader consultaProveedor()
        {
            return sn.consultaProveedor();
        }
        public OdbcDataReader consultaPagar()
        {
            return sn.consultaPagar();
        }
        public OdbcDataReader consultaCobrar()
        {
            return sn.consultaCobrar();
        }

        public OdbcDataReader consultaAbonosClientes()
        {
            return sn.consultaAbonosClientes();
        }
        public OdbcDataReader consultaAbonosProveedores()
        {
            return sn.consultaAbonosProveedores();
        }
    }
}
