﻿
namespace TP2_Grupo4.Views
{
    partial class VistaAlojamiento
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
            this.lblAlojamiento = new System.Windows.Forms.Label();
            this.dgvAlojamiento = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLocalidad = new System.Windows.Forms.TextBox();
            this.comboBoxCantPersonas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxEstrellas = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoAloj = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamiento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlojamiento
            // 
            this.lblAlojamiento.AutoSize = true;
            this.lblAlojamiento.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlojamiento.ForeColor = System.Drawing.Color.Black;
            this.lblAlojamiento.Location = new System.Drawing.Point(370, 7);
            this.lblAlojamiento.Name = "lblAlojamiento";
            this.lblAlojamiento.Size = new System.Drawing.Size(260, 45);
            this.lblAlojamiento.TabIndex = 0;
            this.lblAlojamiento.Text = "Alojamientos";
            // 
            // dgvAlojamiento
            // 
            this.dgvAlojamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlojamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlojamiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvAlojamiento.Location = new System.Drawing.Point(12, 174);
            this.dgvAlojamiento.Name = "dgvAlojamiento";
            this.dgvAlojamiento.RowTemplate.Height = 25;
            this.dgvAlojamiento.Size = new System.Drawing.Size(976, 376);
            this.dgvAlojamiento.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxLocalidad);
            this.groupBox1.Controls.Add(this.comboBoxCantPersonas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxEstrellas);
            this.groupBox1.Controls.Add(this.comboBoxTipoAloj);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(84, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenamiento";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(531, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(531, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio";
            // 
            // comboBoxLocalidad
            // 
            this.comboBoxLocalidad.Location = new System.Drawing.Point(114, 74);
            this.comboBoxLocalidad.Name = "comboBoxLocalidad";
            this.comboBoxLocalidad.Size = new System.Drawing.Size(121, 23);
            this.comboBoxLocalidad.TabIndex = 4;
            // 
            // comboBoxCantPersonas
            // 
            this.comboBoxCantPersonas.FormattingEnabled = true;
            this.comboBoxCantPersonas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxCantPersonas.Location = new System.Drawing.Point(380, 26);
            this.comboBoxCantPersonas.Name = "comboBoxCantPersonas";
            this.comboBoxCantPersonas.Size = new System.Drawing.Size(65, 23);
            this.comboBoxCantPersonas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de Personas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Estrellas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Localidad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(692, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBoxEstrellas
            // 
            this.comboBoxEstrellas.FormattingEnabled = true;
            this.comboBoxEstrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxEstrellas.Location = new System.Drawing.Point(380, 74);
            this.comboBoxEstrellas.Name = "comboBoxEstrellas";
            this.comboBoxEstrellas.Size = new System.Drawing.Size(53, 23);
            this.comboBoxEstrellas.TabIndex = 5;
            // 
            // comboBoxTipoAloj
            // 
            this.comboBoxTipoAloj.FormattingEnabled = true;
            this.comboBoxTipoAloj.Items.AddRange(new object[] {
            "Todos",
            "Hotel",
            "Cabaña"});
            this.comboBoxTipoAloj.Location = new System.Drawing.Point(114, 26);
            this.comboBoxTipoAloj.Name = "comboBoxTipoAloj";
            this.comboBoxTipoAloj.Size = new System.Drawing.Size(107, 23);
            this.comboBoxTipoAloj.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(882, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 63);
            this.button2.TabIndex = 8;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // VistaAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAlojamiento);
            this.Controls.Add(this.lblAlojamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaAlojamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlojamiento";
            this.Load += new System.EventHandler(this.FormAlojamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamiento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlojamiento;
        private System.Windows.Forms.DataGridView dgvAlojamiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox comboBoxLocalidad;
        private System.Windows.Forms.ComboBox comboBoxCantPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxEstrellas;
        private System.Windows.Forms.ComboBox comboBoxTipoAloj;
        private System.Windows.Forms.Button button2;
    }
}