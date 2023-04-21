namespace pryMiPrimerApp
{
    partial class frmAlacena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlacena));
            this.mrcControAlimentos = new System.Windows.Forms.GroupBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lstLugar = new System.Windows.Forms.ComboBox();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.mrcAlmacenar = new System.Windows.Forms.GroupBox();
            this.lstAlimento = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lstCantidad = new System.Windows.Forms.ComboBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.mrcAlmacenado = new System.Windows.Forms.GroupBox();
            this.lblCantidadAlmacenado = new System.Windows.Forms.Label();
            this.lstAlimentoAlmacenado = new System.Windows.Forms.ComboBox();
            this.lblAlimentoAlmacenado = new System.Windows.Forms.Label();
            this.lstLugarAlmacenado = new System.Windows.Forms.ComboBox();
            this.lblLugarAlmacenado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mrcControAlimentos.SuspendLayout();
            this.mrcAlmacenar.SuspendLayout();
            this.mrcAlmacenado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcControAlimentos
            // 
            this.mrcControAlimentos.Controls.Add(this.mrcAlmacenado);
            this.mrcControAlimentos.Controls.Add(this.mrcAlmacenar);
            this.mrcControAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcControAlimentos.Location = new System.Drawing.Point(12, 12);
            this.mrcControAlimentos.Name = "mrcControAlimentos";
            this.mrcControAlimentos.Size = new System.Drawing.Size(507, 345);
            this.mrcControAlimentos.TabIndex = 0;
            this.mrcControAlimentos.TabStop = false;
            this.mrcControAlimentos.Text = "Control de Alimentos";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(17, 33);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(55, 20);
            this.lblLugar.TabIndex = 1;
            this.lblLugar.Text = "Lugar";
            // 
            // lstLugar
            // 
            this.lstLugar.FormattingEnabled = true;
            this.lstLugar.Location = new System.Drawing.Point(21, 56);
            this.lstLugar.Name = "lstLugar";
            this.lstLugar.Size = new System.Drawing.Size(121, 28);
            this.lstLugar.TabIndex = 2;
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimento.Location = new System.Drawing.Point(155, 33);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(79, 20);
            this.lblAlimento.TabIndex = 3;
            this.lblAlimento.Text = "Alimento";
            this.lblAlimento.Click += new System.EventHandler(this.label1_Click);
            // 
            // mrcAlmacenar
            // 
            this.mrcAlmacenar.Controls.Add(this.cmdGuardar);
            this.mrcAlmacenar.Controls.Add(this.cmdCancelar);
            this.mrcAlmacenar.Controls.Add(this.lstCantidad);
            this.mrcAlmacenar.Controls.Add(this.lblCantidad);
            this.mrcAlmacenar.Controls.Add(this.lstAlimento);
            this.mrcAlmacenar.Controls.Add(this.lblAlimento);
            this.mrcAlmacenar.Controls.Add(this.lstLugar);
            this.mrcAlmacenar.Controls.Add(this.lblLugar);
            this.mrcAlmacenar.Location = new System.Drawing.Point(14, 37);
            this.mrcAlmacenar.Name = "mrcAlmacenar";
            this.mrcAlmacenar.Size = new System.Drawing.Size(475, 164);
            this.mrcAlmacenar.TabIndex = 4;
            this.mrcAlmacenar.TabStop = false;
            this.mrcAlmacenar.Text = "Almacenar";
            this.mrcAlmacenar.Enter += new System.EventHandler(this.mrcAlmacenar_Enter);
            // 
            // lstAlimento
            // 
            this.lstAlimento.FormattingEnabled = true;
            this.lstAlimento.Location = new System.Drawing.Point(159, 56);
            this.lstAlimento.Name = "lstAlimento";
            this.lstAlimento.Size = new System.Drawing.Size(121, 28);
            this.lstAlimento.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(297, 33);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(81, 20);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lstCantidad
            // 
            this.lstCantidad.FormattingEnabled = true;
            this.lstCantidad.Location = new System.Drawing.Point(301, 56);
            this.lstCantidad.Name = "lstCantidad";
            this.lstCantidad.Size = new System.Drawing.Size(121, 28);
            this.lstCantidad.TabIndex = 6;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(279, 119);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(92, 32);
            this.cmdCancelar.TabIndex = 8;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(377, 119);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(92, 32);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // mrcAlmacenado
            // 
            this.mrcAlmacenado.Controls.Add(this.label1);
            this.mrcAlmacenado.Controls.Add(this.lblCantidadAlmacenado);
            this.mrcAlmacenado.Controls.Add(this.lstAlimentoAlmacenado);
            this.mrcAlmacenado.Controls.Add(this.lblAlimentoAlmacenado);
            this.mrcAlmacenado.Controls.Add(this.lstLugarAlmacenado);
            this.mrcAlmacenado.Controls.Add(this.lblLugarAlmacenado);
            this.mrcAlmacenado.Location = new System.Drawing.Point(14, 222);
            this.mrcAlmacenado.Name = "mrcAlmacenado";
            this.mrcAlmacenado.Size = new System.Drawing.Size(475, 112);
            this.mrcAlmacenado.TabIndex = 10;
            this.mrcAlmacenado.TabStop = false;
            this.mrcAlmacenado.Text = "Almacenado";
            // 
            // lblCantidadAlmacenado
            // 
            this.lblCantidadAlmacenado.AutoSize = true;
            this.lblCantidadAlmacenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAlmacenado.Location = new System.Drawing.Point(297, 33);
            this.lblCantidadAlmacenado.Name = "lblCantidadAlmacenado";
            this.lblCantidadAlmacenado.Size = new System.Drawing.Size(81, 20);
            this.lblCantidadAlmacenado.TabIndex = 5;
            this.lblCantidadAlmacenado.Text = "Cantidad";
            // 
            // lstAlimentoAlmacenado
            // 
            this.lstAlimentoAlmacenado.FormattingEnabled = true;
            this.lstAlimentoAlmacenado.Location = new System.Drawing.Point(159, 56);
            this.lstAlimentoAlmacenado.Name = "lstAlimentoAlmacenado";
            this.lstAlimentoAlmacenado.Size = new System.Drawing.Size(121, 28);
            this.lstAlimentoAlmacenado.TabIndex = 4;
            // 
            // lblAlimentoAlmacenado
            // 
            this.lblAlimentoAlmacenado.AutoSize = true;
            this.lblAlimentoAlmacenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentoAlmacenado.Location = new System.Drawing.Point(155, 33);
            this.lblAlimentoAlmacenado.Name = "lblAlimentoAlmacenado";
            this.lblAlimentoAlmacenado.Size = new System.Drawing.Size(79, 20);
            this.lblAlimentoAlmacenado.TabIndex = 3;
            this.lblAlimentoAlmacenado.Text = "Alimento";
            // 
            // lstLugarAlmacenado
            // 
            this.lstLugarAlmacenado.FormattingEnabled = true;
            this.lstLugarAlmacenado.Location = new System.Drawing.Point(21, 56);
            this.lstLugarAlmacenado.Name = "lstLugarAlmacenado";
            this.lstLugarAlmacenado.Size = new System.Drawing.Size(121, 28);
            this.lstLugarAlmacenado.TabIndex = 2;
            // 
            // lblLugarAlmacenado
            // 
            this.lblLugarAlmacenado.AutoSize = true;
            this.lblLugarAlmacenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarAlmacenado.Location = new System.Drawing.Point(17, 33);
            this.lblLugarAlmacenado.Name = "lblLugarAlmacenado";
            this.lblLugarAlmacenado.Size = new System.Drawing.Size(55, 20);
            this.lblLugarAlmacenado.TabIndex = 1;
            this.lblLugarAlmacenado.Text = "Lugar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "_______________";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 368);
            this.Controls.Add(this.mrcControAlimentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlacena";
            this.Text = "Gestor de Alimentos";
            this.mrcControAlimentos.ResumeLayout(false);
            this.mrcAlmacenar.ResumeLayout(false);
            this.mrcAlmacenar.PerformLayout();
            this.mrcAlmacenado.ResumeLayout(false);
            this.mrcAlmacenado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcControAlimentos;
        private System.Windows.Forms.Label lblAlimento;
        private System.Windows.Forms.ComboBox lstLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.GroupBox mrcAlmacenar;
        private System.Windows.Forms.GroupBox mrcAlmacenado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidadAlmacenado;
        private System.Windows.Forms.ComboBox lstAlimentoAlmacenado;
        private System.Windows.Forms.Label lblAlimentoAlmacenado;
        private System.Windows.Forms.ComboBox lstLugarAlmacenado;
        private System.Windows.Forms.Label lblLugarAlmacenado;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ComboBox lstCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox lstAlimento;
    }
}