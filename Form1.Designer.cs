namespace Rixpert
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.analista = new System.Windows.Forms.TextBox();
            this.labelFECHA = new System.Windows.Forms.Label();
            this.labelanalistaTOP = new System.Windows.Forms.Label();
            this.buttonAGREGAR = new System.Windows.Forms.Button();
            this.buttonGrabar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "RIXPERT";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(572, 72);
            this.Fecha.Multiline = true;
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(151, 29);
            this.Fecha.TabIndex = 6;
            // 
            // analista
            // 
            this.analista.Location = new System.Drawing.Point(572, 22);
            this.analista.Multiline = true;
            this.analista.Name = "analista";
            this.analista.Size = new System.Drawing.Size(151, 29);
            this.analista.TabIndex = 7;
            // 
            // labelFECHA
            // 
            this.labelFECHA.AutoSize = true;
            this.labelFECHA.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFECHA.Location = new System.Drawing.Point(511, 29);
            this.labelFECHA.Name = "labelFECHA";
            this.labelFECHA.Size = new System.Drawing.Size(55, 22);
            this.labelFECHA.TabIndex = 8;
            this.labelFECHA.Text = "Fecha";
            // 
            // labelanalistaTOP
            // 
            this.labelanalistaTOP.AutoSize = true;
            this.labelanalistaTOP.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelanalistaTOP.Location = new System.Drawing.Point(491, 79);
            this.labelanalistaTOP.Name = "labelanalistaTOP";
            this.labelanalistaTOP.Size = new System.Drawing.Size(75, 22);
            this.labelanalistaTOP.TabIndex = 9;
            this.labelanalistaTOP.Text = "Analista";
            // 
            // buttonAGREGAR
            // 
            this.buttonAGREGAR.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAGREGAR.Location = new System.Drawing.Point(12, 131);
            this.buttonAGREGAR.Name = "buttonAGREGAR";
            this.buttonAGREGAR.Size = new System.Drawing.Size(47, 41);
            this.buttonAGREGAR.TabIndex = 10;
            this.buttonAGREGAR.Text = "+";
            this.buttonAGREGAR.UseVisualStyleBackColor = true;
            this.buttonAGREGAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrabar.Location = new System.Drawing.Point(94, 131);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(47, 41);
            this.buttonGrabar.TabIndex = 11;
            this.buttonGrabar.Text = "✓";
            this.buttonGrabar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 159);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 145;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Activo";
            this.Column2.Name = "Column2";
            this.Column2.Width = 145;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Analista";
            this.Column3.Name = "Column3";
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Riesgo";
            this.Column4.Name = "Column4";
            this.Column4.Width = 145;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Daño";
            this.Column5.Name = "Column5";
            this.Column5.Width = 145;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.buttonAGREGAR);
            this.Controls.Add(this.labelanalistaTOP);
            this.Controls.Add(this.labelFECHA);
            this.Controls.Add(this.analista);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulario1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.TextBox analista;
        private System.Windows.Forms.Label labelFECHA;
        private System.Windows.Forms.Label labelanalistaTOP;
        private System.Windows.Forms.Button buttonAGREGAR;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

