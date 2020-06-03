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

namespace Capa_Diseño.Consultas
{
    public partial class Frm_ConsultaVendedor : Form
    {
        Logica logic = new Logica();
        public Frm_ConsultaVendedor()
        {
            InitializeComponent();
            Dgv_consulta.Rows.Clear();
            MostrarConsulta();
        }
        //-----------------------------------------------------------------------------------para mostrar en DGV------------------------------------------------------------------------------
        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultaVendedor();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consulta.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        //

        private void Frm_ConsultaVendedor_Load(object sender, EventArgs e)
        {
            Dgv_consulta.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consulta.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consulta.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
