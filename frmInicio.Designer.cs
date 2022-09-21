namespace SP1EjercicioPorResolver
{
    partial class frmInicio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnAceptar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 65);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido al Sistema!";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(65, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(192, 31);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Sinterpart SRL";
            // 
            // btnAceptar2
            // 
            this.btnAceptar2.Location = new System.Drawing.Point(110, 139);
            this.btnAceptar2.Name = "btnAceptar2";
            this.btnAceptar2.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar2.TabIndex = 2;
            this.btnAceptar2.Text = "Aceptar";
            this.btnAceptar2.UseVisualStyleBackColor = true;
            this.btnAceptar2.Click += new System.EventHandler(this.btnAceptar2_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 180);
            this.Controls.Add(this.btnAceptar2);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnAceptar2;
    }
}