using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
using System.Data.Odbc;

namespace Capa_Diseño.Consultas
{
    public partial class Frm_ConsultaCliente : Form
    {
        Logica logic = new Logica();
        public Frm_ConsultaCliente()
        {
            InitializeComponent();
            Dgv_consulta.Rows.Clear();
            MostrarConsulta();
        }

        //-----------------------------------------------------------------------------------para mostrar en DGV------------------------------------------------------------------------------
        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultaCliente();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consulta.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        //

        private void Frm_ConsultaCliente_Load(object sender, EventArgs e)
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
