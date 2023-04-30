namespace pryMiPrimerApp
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mrcAplicaciones = new System.Windows.Forms.GroupBox();
            this.cmdAdministradorDeGastos = new System.Windows.Forms.Button();
            this.cmdAlacena = new System.Windows.Forms.Button();
            this.mrcAplicaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcAplicaciones
            // 
            this.mrcAplicaciones.Controls.Add(this.cmdAdministradorDeGastos);
            this.mrcAplicaciones.Controls.Add(this.cmdAlacena);
            this.mrcAplicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcAplicaciones.Location = new System.Drawing.Point(16, 16);
            this.mrcAplicaciones.Name = "mrcAplicaciones";
            this.mrcAplicaciones.Size = new System.Drawing.Size(217, 273);
            this.mrcAplicaciones.TabIndex = 0;
            this.mrcAplicaciones.TabStop = false;
            this.mrcAplicaciones.Text = "Aplicaciones";
            // 
            // cmdAdministradorDeGastos
            // 
            this.cmdAdministradorDeGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdministradorDeGastos.Location = new System.Drawing.Point(22, 36);
            this.cmdAdministradorDeGastos.Name = "cmdAdministradorDeGastos";
            this.cmdAdministradorDeGastos.Size = new System.Drawing.Size(170, 88);
            this.cmdAdministradorDeGastos.TabIndex = 1;
            this.cmdAdministradorDeGastos.Text = "Administrador de Gastos";
            this.cmdAdministradorDeGastos.UseVisualStyleBackColor = true;
            this.cmdAdministradorDeGastos.Click += new System.EventHandler(this.cmdAdministradorDeGastos_Click);
            // 
            // cmdAlacena
            // 
            this.cmdAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAlacena.Location = new System.Drawing.Point(22, 156);
            this.cmdAlacena.Name = "cmdAlacena";
            this.cmdAlacena.Size = new System.Drawing.Size(170, 88);
            this.cmdAlacena.TabIndex = 0;
            this.cmdAlacena.Text = "Alacena";
            this.cmdAlacena.UseVisualStyleBackColor = true;
            this.cmdAlacena.Click += new System.EventHandler(this.cmdAlacena_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 301);
            this.Controls.Add(this.mrcAplicaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Aplicaciones";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mrcAplicaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcAplicaciones;
        private System.Windows.Forms.Button cmdAdministradorDeGastos;
        private System.Windows.Forms.Button cmdAlacena;
    }
}