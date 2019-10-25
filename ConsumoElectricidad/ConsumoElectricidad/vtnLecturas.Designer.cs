namespace ConsumoElectricidad
{
    partial class vtnLecturas
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
            this.dgvLecturas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONSUMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLecturas
            // 
            this.dgvLecturas.AllowUserToAddRows = false;
            this.dgvLecturas.AllowUserToDeleteRows = false;
            this.dgvLecturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FECHA,
            this.CONSUMO,
            this.IDUSUARIO});
            this.dgvLecturas.Location = new System.Drawing.Point(12, 164);
            this.dgvLecturas.Name = "dgvLecturas";
            this.dgvLecturas.ReadOnly = true;
            this.dgvLecturas.Size = new System.Drawing.Size(469, 150);
            this.dgvLecturas.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // CONSUMO
            // 
            this.CONSUMO.HeaderText = "CONSUMO";
            this.CONSUMO.Name = "CONSUMO";
            this.CONSUMO.ReadOnly = true;
            // 
            // IDUSUARIO
            // 
            this.IDUSUARIO.HeaderText = "IDUSUARIO";
            this.IDUSUARIO.Name = "IDUSUARIO";
            this.IDUSUARIO.ReadOnly = true;
            // 
            // vtnLecturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 358);
            this.Controls.Add(this.dgvLecturas);
            this.Name = "vtnLecturas";
            this.Text = "vtnLecturas";
            this.Load += new System.EventHandler(this.vtnLecturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLecturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONSUMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUSUARIO;
    }
}