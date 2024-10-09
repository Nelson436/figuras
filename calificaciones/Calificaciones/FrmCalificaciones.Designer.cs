namespace Calificaciones
{
    partial class FrmCalificaciones
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbcalif = new System.Windows.Forms.TextBox();
            this.cmbalumno = new System.Windows.Forms.ComboBox();
            this.cmbmateria = new System.Windows.Forms.ComboBox();
            this.dgvcalificaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AsignarCalificacion);
            // 
            // tbcalif
            // 
            this.tbcalif.Location = new System.Drawing.Point(338, 34);
            this.tbcalif.Name = "tbcalif";
            this.tbcalif.Size = new System.Drawing.Size(100, 20);
            this.tbcalif.TabIndex = 1;
            // 
            // cmbalumno
            // 
            this.cmbalumno.FormattingEnabled = true;
            this.cmbalumno.Location = new System.Drawing.Point(34, 33);
            this.cmbalumno.Name = "cmbalumno";
            this.cmbalumno.Size = new System.Drawing.Size(121, 21);
            this.cmbalumno.TabIndex = 2;
            // 
            // cmbmateria
            // 
            this.cmbmateria.FormattingEnabled = true;
            this.cmbmateria.Location = new System.Drawing.Point(186, 33);
            this.cmbmateria.Name = "cmbmateria";
            this.cmbmateria.Size = new System.Drawing.Size(121, 21);
            this.cmbmateria.TabIndex = 3;
            // 
            // dgvcalificaciones
            // 
            this.dgvcalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcalificaciones.Location = new System.Drawing.Point(32, 109);
            this.dgvcalificaciones.Name = "dgvcalificaciones";
            this.dgvcalificaciones.Size = new System.Drawing.Size(423, 129);
            this.dgvcalificaciones.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calificacion:";
            // 
            // FrmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcalificaciones);
            this.Controls.Add(this.cmbmateria);
            this.Controls.Add(this.cmbalumno);
            this.Controls.Add(this.tbcalif);
            this.Controls.Add(this.button1);
            this.Name = "FrmCalificaciones";
            this.Text = "FrmCalificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcalificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbcalif;
        private System.Windows.Forms.ComboBox cmbalumno;
        private System.Windows.Forms.ComboBox cmbmateria;
        private System.Windows.Forms.DataGridView dgvcalificaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}