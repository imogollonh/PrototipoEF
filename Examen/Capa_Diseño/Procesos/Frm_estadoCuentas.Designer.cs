namespace Capa_Diseño.Procesos
{
    partial class Frm_estadoCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dgv_consultaPagar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_consultaCobrar = new System.Windows.Forms.DataGridView();
            this.Btn_Cargo = new System.Windows.Forms.Button();
            this.Btn_Abono = new System.Windows.Forms.Button();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaCobrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_consultaPagar
            // 
            this.Dgv_consultaPagar.AllowUserToAddRows = false;
            this.Dgv_consultaPagar.AllowUserToDeleteRows = false;
            this.Dgv_consultaPagar.AllowUserToResizeColumns = false;
            this.Dgv_consultaPagar.AllowUserToResizeRows = false;
            this.Dgv_consultaPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nombre,
            this.total,
            this.haber});
            this.Dgv_consultaPagar.Location = new System.Drawing.Point(11, 40);
            this.Dgv_consultaPagar.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_consultaPagar.Name = "Dgv_consultaPagar";
            this.Dgv_consultaPagar.ReadOnly = true;
            this.Dgv_consultaPagar.RowHeadersVisible = false;
            this.Dgv_consultaPagar.RowHeadersWidth = 51;
            this.Dgv_consultaPagar.RowTemplate.Height = 24;
            this.Dgv_consultaPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaPagar.Size = new System.Drawing.Size(933, 184);
            this.Dgv_consultaPagar.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 79;
            this.label1.Text = "Por Pagar ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 81;
            this.label2.Text = "Por Cobrar";
            // 
            // Dgv_consultaCobrar
            // 
            this.Dgv_consultaCobrar.AllowUserToAddRows = false;
            this.Dgv_consultaCobrar.AllowUserToDeleteRows = false;
            this.Dgv_consultaCobrar.AllowUserToResizeColumns = false;
            this.Dgv_consultaCobrar.AllowUserToResizeRows = false;
            this.Dgv_consultaCobrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaCobrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codC,
            this.nombreC,
            this.totalC,
            this.haber2});
            this.Dgv_consultaCobrar.Location = new System.Drawing.Point(20, 325);
            this.Dgv_consultaCobrar.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_consultaCobrar.Name = "Dgv_consultaCobrar";
            this.Dgv_consultaCobrar.ReadOnly = true;
            this.Dgv_consultaCobrar.RowHeadersVisible = false;
            this.Dgv_consultaCobrar.RowHeadersWidth = 51;
            this.Dgv_consultaCobrar.RowTemplate.Height = 24;
            this.Dgv_consultaCobrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaCobrar.Size = new System.Drawing.Size(933, 186);
            this.Dgv_consultaCobrar.TabIndex = 82;
            // 
            // Btn_Cargo
            // 
            this.Btn_Cargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Cargo.FlatAppearance.BorderSize = 3;
            this.Btn_Cargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Cargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cargo.Location = new System.Drawing.Point(821, 228);
            this.Btn_Cargo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cargo.Name = "Btn_Cargo";
            this.Btn_Cargo.Size = new System.Drawing.Size(123, 33);
            this.Btn_Cargo.TabIndex = 84;
            this.Btn_Cargo.Text = "Abono";
            this.Btn_Cargo.UseVisualStyleBackColor = true;
            this.Btn_Cargo.Click += new System.EventHandler(this.Btn_Cargo_Click);
            // 
            // Btn_Abono
            // 
            this.Btn_Abono.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Abono.FlatAppearance.BorderSize = 3;
            this.Btn_Abono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Abono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Abono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Abono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Abono.Location = new System.Drawing.Point(830, 515);
            this.Btn_Abono.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Abono.Name = "Btn_Abono";
            this.Btn_Abono.Size = new System.Drawing.Size(123, 33);
            this.Btn_Abono.TabIndex = 83;
            this.Btn_Abono.Text = "Abono";
            this.Btn_Abono.UseVisualStyleBackColor = true;
            this.Btn_Abono.Click += new System.EventHandler(this.Btn_Abono_Click);
            // 
            // cod
            // 
            this.cod.HeaderText = "COD Proveedor";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Debe";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // haber
            // 
            this.haber.HeaderText = "Haber";
            this.haber.Name = "haber";
            this.haber.ReadOnly = true;
            // 
            // codC
            // 
            this.codC.HeaderText = "COD Cliente";
            this.codC.Name = "codC";
            this.codC.ReadOnly = true;
            // 
            // nombreC
            // 
            this.nombreC.HeaderText = "Nombre";
            this.nombreC.Name = "nombreC";
            this.nombreC.ReadOnly = true;
            // 
            // totalC
            // 
            this.totalC.HeaderText = "Debe";
            this.totalC.Name = "totalC";
            this.totalC.ReadOnly = true;
            // 
            // haber2
            // 
            this.haber2.HeaderText = "Haber";
            this.haber2.Name = "haber2";
            this.haber2.ReadOnly = true;
            // 
            // Frm_estadoCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 559);
            this.Controls.Add(this.Btn_Cargo);
            this.Controls.Add(this.Btn_Abono);
            this.Controls.Add(this.Dgv_consultaCobrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_consultaPagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_estadoCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldos Cuentas";
            this.Load += new System.EventHandler(this.Frm_estadoCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaCobrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Dgv_consultaPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView Dgv_consultaCobrar;
        private System.Windows.Forms.Button Btn_Cargo;
        private System.Windows.Forms.Button Btn_Abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn codC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalC;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber2;
    }
}