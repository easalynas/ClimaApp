
namespace ClimaUPC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtFono = new System.Windows.Forms.TextBox();
            this.txtClima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFono = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRevisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(108, 88);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 23);
            this.txtCiudad.TabIndex = 0;
            // 
            // txtFono
            // 
            this.txtFono.Location = new System.Drawing.Point(108, 164);
            this.txtFono.Name = "txtFono";
            this.txtFono.Size = new System.Drawing.Size(100, 23);
            this.txtFono.TabIndex = 1;
            // 
            // txtClima
            // 
            this.txtClima.Location = new System.Drawing.Point(377, 128);
            this.txtClima.Name = "txtClima";
            this.txtClima.Size = new System.Drawing.Size(100, 23);
            this.txtClima.TabIndex = 2;
            this.txtClima.TextChanged += new System.EventHandler(this.txtClima_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Respuesta";
            // 
            // lblFono
            // 
            this.lblFono.AutoSize = true;
            this.lblFono.Location = new System.Drawing.Point(108, 143);
            this.lblFono.Name = "lblFono";
            this.lblFono.Size = new System.Drawing.Size(52, 15);
            this.lblFono.TabIndex = 4;
            this.lblFono.Text = "Telefono";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(108, 67);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(45, 15);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "Ciudad";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(241, 127);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnRevisar
            // 
            this.btnRevisar.Location = new System.Drawing.Point(386, 163);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(75, 23);
            this.btnRevisar.TabIndex = 7;
            this.btnRevisar.Text = "Ver Clima";
            this.btnRevisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(467, 110);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 314);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRevisar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblFono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClima);
            this.Controls.Add(this.txtFono);
            this.Controls.Add(this.txtCiudad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFono;
        private System.Windows.Forms.TextBox txtClima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFono;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRevisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtCiudad;
    }
}

