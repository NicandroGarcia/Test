namespace FormularioPrueba
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
            this.btn_Hola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Hola
            // 
            this.btn_Hola.Location = new System.Drawing.Point(176, 114);
            this.btn_Hola.Name = "btn_Hola";
            this.btn_Hola.Size = new System.Drawing.Size(75, 23);
            this.btn_Hola.TabIndex = 0;
            this.btn_Hola.Text = "button1";
            this.btn_Hola.UseVisualStyleBackColor = true;
            this.btn_Hola.Click += new System.EventHandler(this.btn_Hola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 262);
            this.Controls.Add(this.btn_Hola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Hola;
    }
}

