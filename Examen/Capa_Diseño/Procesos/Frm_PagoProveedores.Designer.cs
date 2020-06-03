namespace Capa_Diseño.Procesos
{
    partial class Frm_PagoProveedores
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Btn_Cargo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 150;
            this.label4.Text = "Fecha Pago:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 152;
            this.label1.Text = "Total:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 151;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 154;
            this.label2.Text = "Numero Documento:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 20);
            this.textBox3.TabIndex = 153;
            // 
            // Btn_Cargo
            // 
            this.Btn_Cargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Cargo.FlatAppearance.BorderSize = 3;
            this.Btn_Cargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Cargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cargo.Location = new System.Drawing.Point(288, 153);
            this.Btn_Cargo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cargo.Name = "Btn_Cargo";
            this.Btn_Cargo.Size = new System.Drawing.Size(123, 33);
            this.Btn_Cargo.TabIndex = 155;
            this.Btn_Cargo.Text = "Pagar";
            this.Btn_Cargo.UseVisualStyleBackColor = true;
            // 
            // Frm_PagoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 197);
            this.Controls.Add(this.Btn_Cargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_PagoProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Btn_Cargo;
    }
}