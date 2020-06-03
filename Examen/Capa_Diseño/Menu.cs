using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Diseño.Mantenimientos;

namespace Capa_Diseño
{
    public partial class Menu : Form
    {
        private int childFormNumber = 0;

        public Menu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        bool ventanaClientes = false;
        Frm_MantenimientoClientes clientes = new Frm_MantenimientoClientes();
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantenimientoClientes);
            if (ventanaClientes == false || frmC == null)
            {
                if (frmC == null)
                {
                    clientes = new Frm_MantenimientoClientes();
                }

                clientes.MdiParent = this;
                clientes.Show();
                Application.DoEvents();
                ventanaClientes = true;
            }
            else
            {
                clientes.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaVendedores = false;
        Frm_MantenimientoVendedor vendedor= new Frm_MantenimientoVendedor();
        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantenimientoVendedor);
            if (ventanaVendedores == false || frmC == null)
            {
                if (frmC == null)
                {
                    vendedor = new Frm_MantenimientoVendedor();
                }

                vendedor.MdiParent = this;
                vendedor.Show();
                Application.DoEvents();
                ventanaVendedores = true;
            }
            else
            {
                vendedor.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaProveedores= false;
        Frm_MantenimientoProveedores proveedor = new Frm_MantenimientoProveedores();
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantenimientoProveedores);
            if (ventanaProveedores == false || frmC == null)
            {
                if (frmC == null)
                {
                    proveedor = new Frm_MantenimientoProveedores();
                }

                proveedor.MdiParent = this;
                proveedor.Show();
                Application.DoEvents();
                ventanaProveedores = true;
            }
            else
            {
                proveedor.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
