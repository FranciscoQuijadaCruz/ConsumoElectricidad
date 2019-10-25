namespace GeekGas
{
    partial class VentanaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnGenerarFacturas = new System.Windows.Forms.Button();
            this.btnReporteTotalAnual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(139, 127);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(238, 57);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registrar Usuarios";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnGenerarFacturas
            // 
            this.btnGenerarFacturas.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarFacturas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFacturas.Location = new System.Drawing.Point(139, 202);
            this.btnGenerarFacturas.Name = "btnGenerarFacturas";
            this.btnGenerarFacturas.Size = new System.Drawing.Size(238, 57);
            this.btnGenerarFacturas.TabIndex = 2;
            this.btnGenerarFacturas.Text = "Generar Facturas";
            this.btnGenerarFacturas.UseVisualStyleBackColor = false;
            this.btnGenerarFacturas.Click += new System.EventHandler(this.btnGenerarFacturas_Click);
            // 
            // btnReporteTotalAnual
            // 
            this.btnReporteTotalAnual.BackColor = System.Drawing.Color.Transparent;
            this.btnReporteTotalAnual.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteTotalAnual.Location = new System.Drawing.Point(139, 275);
            this.btnReporteTotalAnual.Name = "btnReporteTotalAnual";
            this.btnReporteTotalAnual.Size = new System.Drawing.Size(238, 57);
            this.btnReporteTotalAnual.TabIndex = 3;
            this.btnReporteTotalAnual.Text = "Reporte Total Anual";
            this.btnReporteTotalAnual.UseVisualStyleBackColor = false;
            this.btnReporteTotalAnual.Click += new System.EventHandler(this.btnReporteTotalAnual_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 91);
            this.panel1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Orange;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(42, 5);
            this.label8.MinimumSize = new System.Drawing.Size(140, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 80);
            this.label8.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(-2, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 14);
            this.panel2.TabIndex = 18;
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(482, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReporteTotalAnual);
            this.Controls.Add(this.btnGenerarFacturas);
            this.Controls.Add(this.btnRegistro);
            this.Name = "VentanaAdmin";
            this.Text = "VistaAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnGenerarFacturas;
        private System.Windows.Forms.Button btnReporteTotalAnual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}