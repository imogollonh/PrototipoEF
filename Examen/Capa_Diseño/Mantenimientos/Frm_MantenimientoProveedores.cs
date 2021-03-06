﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
using Capa_Diseño.Consultas;

namespace Capa_Diseño.Mantenimientos
{
    public partial class Frm_MantenimientoProveedores : Form
    {
        Logica logic = new Logica();
        string scampo;
        string sTabla = "proveedores";      //Aqui iria el nombre de la tabla a la cual se le hara el mantenimiento
        string sLlave = "codigo_proveedor";      //Aqui iria el nombre de la llave primaria de la tabla

        public Frm_MantenimientoProveedores()
        {
            InitializeComponent();
            scampo = logic.siguiente(sTabla, sLlave);
            textBox1.Text = scampo;
            bloquearTXT();
        }

        private void Frm_MantenimientoProveedores_Load(object sender, EventArgs e)
        {
            TextBox[] txtBox = { textBox1, textBox2, textBox3, textBox4, textBox5 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            TextBox[] txtBox = { textBox2, textBox3, textBox4, textBox5 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = true;
            }
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Enabled = true;
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            //COMBO QUE USARAN 
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //ComboBox[] comboBox = {comboBox1, comboBox2, etc}   Aqui podemos declarar los combo 
            //Primero debemos de validar si los txt vienen vacios
            TextBox[] txtBox = { textBox1, textBox2, textBox3, textBox4, textBox5 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //ComboBox[] comboBox = {comboBox1, comboBox2, etc}   Aqui podemos declarar los combo 
            if (validarTXT(txtBox) == 0)
                return;
            else
            {
                if (comboBox1.Text == "Activo")
                {
                    comboBox1.Text = "1";
                }
                else
                {
                    comboBox1.Text = "0";
                }
                //Aqui se declara la tabla donde se ira a modificar y en el segundoa arreglo, se debe de colocar los nombre de los campos.
                string[] valores = { sTabla, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox1.Text };
                string[] campos = { "codigo_proveedor", "nombre_proveedor", "direccion_proveedor", "telefono_proveedor", "nit_proveedor", "estado" }; //CAMPOS DE LA TABLA
                if (logic.Modificar(valores, campos) == null)
                    MessageBox.Show("Ocurrio un error al modificar los datos.");
                else
                {
                    MessageBox.Show("Datos modificados exitosamente.");
                    limpiarTXT(txtBox, comboBox); //Si usamos combo, debemos de enviarselo aqui a la funcion y declarar a la funcion que recibe
                    bloquearTXT();
                }
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Primero debemos de validar si los txt vienen vacios
            TextBox[] txtBox = { textBox1, textBox2, textBox3, textBox4, textBox5 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //COMBO QUE USARAN 
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //ComboBox[] comboBox = {comboBox1, comboBox2, etc}   Aqui podemos declarar los combo 
            if (validarTXT(txtBox) == 0)
                return;
            else
            {
                if (comboBox1.Text == "Activo")
                {
                    comboBox1.Text = "1";
                }
                else
                {
                    comboBox1.Text = "0";
                }
                //Aqui se declara la tabla donde se ira a insertar y los txt que se guardaran en el orden de la tabla
                string[] valores = { sTabla, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox1.Text };
                //Debemos de cambiar los datos que se le envian a la bitacora, dependiendo del modulo, tipo de movimiento 
                if (logic.Insertar(valores) == null)
                    MessageBox.Show("Ocurrio un error al guardar los datos.");
                else
                {
                    MessageBox.Show("Datos guardados exitosamente.");
                    limpiarTXT(txtBox, comboBox); //Si usamos combo, debemos de enviarselo aqui a la funcion y declarar a la funcion que recibe
                    bloquearTXT();
                }
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            //COMBO QUE USARAN 
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //ComboBox[] comboBox = {comboBox1, comboBox2, etc}   Aqui podemos declarar los combo 
            TextBox[] txtBox = { textBox1, textBox2, textBox3, textBox4, textBox5 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //Aqui se declara la tabla que se ira a eliminar, el codigo por medio del txt y el nombre de la llave primaria.
            string[] valores = { sTabla, textBox1.Text, sLlave };
            if (logic.Eliminar(valores) == null)
                MessageBox.Show("Ocurrio un error al borrar los datos.");
            else
            {
                MessageBox.Show("Datos eliminados exitosamente.");
                limpiarTXT(txtBox, comboBox); //Si usamos combo, debemos de enviarselo aqui a la funcion y declarar a la funcion que recibe
                bloquearTXT();
            }
        }
        private int validarTXT(TextBox[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (string.IsNullOrEmpty(list[i].Text))
                {
                    MessageBox.Show("Debe completar la informacion en el campo " + list[i].Name);
                    return 0;
                }
            }
            return 1;
        }
        void limpiarTXT(TextBox[] txtBox, ComboBox[] comboBo)
        {
            //Aqui se limpian los txt
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Text = "";
            }
            //Aqui colocamos el siguiente codigo de la tabla y su llave primaria 
            scampo = logic.siguiente(sTabla, sLlave);
            textBox1.Text = scampo;
            if (comboBox1.Text != "")
            {
                comboBox1.Text = "Activo";
            }
            else
            {
                comboBox1.Text = "Inactico";
            }
        }
        void bloquearTXT()
        {
            TextBox[] txtBox = { textBox1, textBox2, textBox3, textBox4, textBox5 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = false;
            }
            //COMBO QUE USARAN 
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //ComboBox[] comboBox = {comboBox1, comboBox2, etc}   Aqui podemos declarar los combo 
            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Enabled = false;
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_ConsultaProveedores consulta = new Frm_ConsultaProveedores();
            consulta.ShowDialog();

            if (consulta.DialogResult == DialogResult.OK)
            {
                textBox1.Text = consulta.Dgv_consulta.Rows[consulta.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                textBox2.Text = consulta.Dgv_consulta.Rows[consulta.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                textBox3.Text = consulta.Dgv_consulta.Rows[consulta.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                textBox4.Text = consulta.Dgv_consulta.Rows[consulta.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
                textBox5.Text = consulta.Dgv_consulta.Rows[consulta.Dgv_consulta.CurrentRow.Index].
                      Cells[4].Value.ToString();
            }
        }
    }
}
