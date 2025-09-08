namespace Ejercicio1
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
            this.btnCargarGranja = new System.Windows.Forms.Button();
            this.btnIniciarRutina = new System.Windows.Forms.Button();
            this.lbDetalle = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCargarGranja
            // 
            this.btnCargarGranja.Location = new System.Drawing.Point(134, 70);
            this.btnCargarGranja.Name = "btnCargarGranja";
            this.btnCargarGranja.Size = new System.Drawing.Size(88, 40);
            this.btnCargarGranja.TabIndex = 0;
            this.btnCargarGranja.Text = "Cargar Granja";
            this.btnCargarGranja.UseVisualStyleBackColor = true;
            this.btnCargarGranja.Click += new System.EventHandler(this.btnCargarGranja_Click);
            // 
            // btnIniciarRutina
            // 
            this.btnIniciarRutina.Location = new System.Drawing.Point(480, 60);
            this.btnIniciarRutina.Name = "btnIniciarRutina";
            this.btnIniciarRutina.Size = new System.Drawing.Size(88, 40);
            this.btnIniciarRutina.TabIndex = 1;
            this.btnIniciarRutina.Text = "Iniciar Rutina";
            this.btnIniciarRutina.UseVisualStyleBackColor = true;
            this.btnIniciarRutina.Click += new System.EventHandler(this.btnIniciarRutina_Click);
            // 
            // lbDetalle
            // 
            this.lbDetalle.FormattingEnabled = true;
            this.lbDetalle.Location = new System.Drawing.Point(89, 143);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(459, 199);
            this.lbDetalle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.btnIniciarRutina);
            this.Controls.Add(this.btnCargarGranja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarGranja;
        private System.Windows.Forms.Button btnIniciarRutina;
        private System.Windows.Forms.ListBox lbDetalle;
    }
}

