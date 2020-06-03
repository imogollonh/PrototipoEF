using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño.Procesos
{
    public partial class Frm_estadoCuentas : Form
    {
        Logica logic = new Logica();
        public Frm_estadoCuentas()
        {
            InitializeComponent();
            Dgv_consultaPagar.Rows.Clear();
            Dgv_consultaCobrar.Rows.Clear();
            MostrarConsulta();
        }
        //-----------------------------------------------------------------------------------para mostrar en DGV------------------------------------------------------------------------------
        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultaPagar();
            OdbcDataReader mostrarPagar = logic.consultaAbonosProveedores();
            try
            {
                while (mostrar.Read() && mostrarPagar.Read())
                {
                    Dgv_consultaPagar.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrarPagar.GetString(1));
                   
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            
            //saldo
            //fin saldo
            OdbcDataReader mostrar2 = logic.consultaCobrar();
            OdbcDataReader mostrarPagar2 = logic.consultaAbonosClientes();
            try
            {
                while (mostrar2.Read() && mostrarPagar2.Read())
                {
                    Dgv_consultaCobrar.Rows.Add(mostrar2.GetString(0), mostrar2.GetString(1),  mostrarPagar2.GetString(1), mostrar2.GetString(2));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        //

        private void Frm_estadoCuentas_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cargo_Click(object sender, EventArgs e)
        {
            Frm_PagoProveedores consulta = new Frm_PagoProveedores();
            consulta.ShowDialog();
        }

        private void Btn_Abono_Click(object sender, EventArgs e)
        {
            Frm_PagoClientes consulta = new Frm_PagoClientes();
            consulta.ShowDialog();
        }
    }
}
