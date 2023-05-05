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
            this.mrcAlmacenado = new System.Windows.Forms.GroupBox();
            this.cboAlimentoAlmacenado = new System.Windows.Forms.ComboBox();
            this.lblAlimentoAlmacenado = new System.Windows.Forms.Label();
            this.cboLugarAlmacenado = new System.Windows.Forms.ComboBox();
            this.lblLugarAlmacenado = new System.Windows.Forms.Label();
            this.mrcAlmacenar = new System.Windows.Forms.GroupBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboAlimento = new System.Windows.Forms.ComboBox();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.cboLugar = new System.Windows.Forms.ComboBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAlmacenado = new System.Windows.Forms.Label();
            this.lblFechaAlmacenado2 = new System.Windows.Forms.Label();
            this.lblCantidadAlmacenado = new System.Windows.Forms.Label();
            this.lblCantidadAlmacenado2 = new System.Windows.Forms.Label();
            this.mrcControAlimentos.SuspendLayout();
            this.mrcAlmacenado.SuspendLayout();
            this.mrcAlmacenar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcControAlimentos
            // 
            this.mrcControAlimentos.Controls.Add(this.mrcAlmacenado);
            this.mrcControAlimentos.Controls.Add(this.mrcAlmacenar);
            this.mrcControAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcControAlimentos.Location = new System.Drawing.Point(12, 12);
            this.mrcControAlimentos.Name = "mrcControAlimentos";
            this.mrcControAlimentos.Size = new System.Drawing.Size(507, 408);
            this.mrcControAlimentos.TabIndex = 0;
            this.mrcControAlimentos.TabStop = false;
            this.mrcControAlimentos.Text = "Control de Alimentos";
            // 
            // mrcAlmacenado
            // 
            this.mrcAlmacenado.Controls.Add(this.lblCantidadAlmacenado2);
            this.mrcAlmacenado.Controls.Add(this.lblCantidadAlmacenado);
            this.mrcAlmacenado.Controls.Add(this.lblFechaAlmacenado2);
            this.mrcAlmacenado.Controls.Add(this.lblFechaAlmacenado);
            this.mrcAlmacenado.Controls.Add(this.cboAlimentoAlmacenado);
            this.mrcAlmacenado.Controls.Add(this.lblAlimentoAlmacenado);
            this.mrcAlmacenado.Controls.Add(this.cboLugarAlmacenado);
            this.mrcAlmacenado.Controls.Add(this.lblLugarAlmacenado);
            this.mrcAlmacenado.Location = new System.Drawing.Point(14, 222);
            this.mrcAlmacenado.Name = "mrcAlmacenado";
            this.mrcAlmacenado.Size = new System.Drawing.Size(475, 169);
            this.mrcAlmacenado.TabIndex = 10;
            this.mrcAlmacenado.TabStop = false;
            this.mrcAlmacenado.Text = "Almacenado";
            // 
            // cboAlimentoAlmacenado
            // 
            this.cboAlimentoAlmacenado.FormattingEnabled = true;
            this.cboAlimentoAlmacenado.Location = new System.Drawing.Point(202, 56);
            this.cboAlimentoAlmacenado.Name = "cboAlimentoAlmacenado";
            this.cboAlimentoAlmacenado.Size = new System.Drawing.Size(188, 28);
            this.cboAlimentoAlmacenado.TabIndex = 4;
            this.cboAlimentoAlmacenado.SelectedIndexChanged += new System.EventHandler(this.cboAlimentoAlmacenado_SelectedIndexChanged);
            // 
            // lblAlimentoAlmacenado
            // 
            this.lblAlimentoAlmacenado.AutoSize = true;
            this.lblAlimentoAlmacenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentoAlmacenado.Location = new System.Drawing.Point(198, 33);
            this.lblAlimentoAlmacenado.Name = "lblAlimentoAlmacenado";
            this.lblAlimentoAlmacenado.Size = new System.Drawing.Size(79, 20);
            this.lblAlimentoAlmacenado.TabIndex = 3;
            this.lblAlimentoAlmacenado.Text = "Alimento";
            // 
            // cboLugarAlmacenado
            // 
            this.cboLugarAlmacenado.FormattingEnabled = true;
            this.cboLugarAlmacenado.Location = new System.Drawing.Point(21, 56);
            this.cboLugarAlmacenado.Name = "cboLugarAlmacenado";
            this.cboLugarAlmacenado.Size = new System.Drawing.Size(175, 28);
            this.cboLugarAlmacenado.TabIndex = 2;
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
            // mrcAlmacenar
            // 
            this.mrcAlmacenar.Controls.Add(this.dtpVencimiento);
            this.mrcAlmacenar.Controls.Add(this.lblVencimiento);
            this.mrcAlmacenar.Controls.Add(this.nudCantidad);
            this.mrcAlmacenar.Controls.Add(this.cmdGuardar);
            this.mrcAlmacenar.Controls.Add(this.cmdCancelar);
            this.mrcAlmacenar.Controls.Add(this.lblCantidad);
            this.mrcAlmacenar.Controls.Add(this.cboAlimento);
            this.mrcAlmacenar.Controls.Add(this.lblAlimento);
            this.mrcAlmacenar.Controls.Add(this.cboLugar);
            this.mrcAlmacenar.Controls.Add(this.lblLugar);
            this.mrcAlmacenar.Location = new System.Drawing.Point(14, 37);
            this.mrcAlmacenar.Name = "mrcAlmacenar";
            this.mrcAlmacenar.Size = new System.Drawing.Size(475, 164);
            this.mrcAlmacenar.TabIndex = 4;
            this.mrcAlmacenar.TabStop = false;
            this.mrcAlmacenar.Text = "Almacenar";
            this.mrcAlmacenar.Enter += new System.EventHandler(this.mrcAlmacenar_Enter);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(377, 119);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(92, 32);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
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
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(388, 33);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(81, 20);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cboAlimento
            // 
            this.cboAlimento.FormattingEnabled = true;
            this.cboAlimento.Location = new System.Drawing.Point(220, 56);
            this.cboAlimento.Name = "cboAlimento";
            this.cboAlimento.Size = new System.Drawing.Size(192, 28);
            this.cboAlimento.TabIndex = 4;
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimento.Location = new System.Drawing.Point(216, 33);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(79, 20);
            this.lblAlimento.TabIndex = 3;
            this.lblAlimento.Text = "Alimento";
            this.lblAlimento.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboLugar
            // 
            this.cboLugar.FormattingEnabled = true;
            this.cboLugar.Location = new System.Drawing.Point(21, 56);
            this.cboLugar.Name = "cboLugar";
            this.cboLugar.Size = new System.Drawing.Size(193, 28);
            this.cboLugar.TabIndex = 2;
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
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(418, 57);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(51, 26);
            this.nudCantidad.TabIndex = 10;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(17, 96);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(188, 20);
            this.lblVencimiento.TabIndex = 11;
            this.lblVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Location = new System.Drawing.Point(23, 120);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(211, 18);
            this.dtpVencimiento.TabIndex = 12;
            // 
            // lblFechaAlmacenado
            // 
            this.lblFechaAlmacenado.AutoSize = true;
            this.lblFechaAlmacenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlmacenado.Location = new System.Drawing.Point(17, 100);
            this.lblFechaAlmacenado.Name = "lblFechaAlmacenado";
            this.lblFechaAlmacenado.Size = new System.Drawing.Size(188, 20);
            this.lblFechaAlmacenado.TabIndex = 12;
            this.lblFechaAlmacenado.Text = "Fecha de Vencimiento";
            // 
            // lblFechaAlmacenado2
            // 
            this.lblFechaAlmacenado2.AutoSize = true;
            this.lblFechaAlmacenado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlmacenado2.Location = new System.Drawing.Point(17, 132);
            this.lblFechaAlmacenado2.Name = "lblFechaAlmacenado2";
            this.lblFechaAlmacenado2.Size = new System.Drawing.Size(179, 20);
            this.lblFechaAlmacenado2.TabIndex = 13;
            this.lblFechaAlmacenado2.Text = "_________________";
            // 
            // lblCantidadAlmacenado
            // 
            this.lblCantidadAlmacenado.AutoSize = true;
            this.lblCantidadAlmacenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAlmacenado.Location = new System.Drawing.Point(388, 33);
            this.lblCantidadAlmacenado.Name = "lblCantidadAlmacenado";
            this.lblCantidadAlmacenado.Size = new System.Drawing.Size(81, 20);
            this.lblCantidadAlmacenado.TabIndex = 14;
            this.lblCantidadAlmacenado.Text = "Cantidad";
            // 
            // lblCantidadAlmacenado2
            // 
            this.lblCantidadAlmacenado2.AutoSize = true;
            this.lblCantidadAlmacenado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAlmacenado2.Location = new System.Drawing.Point(396, 59);
            this.lblCantidadAlmacenado2.Name = "lblCantidadAlmacenado2";
            this.lblCantidadAlmacenado2.Size = new System.Drawing.Size(79, 20);
            this.lblCantidadAlmacenado2.TabIndex = 15;
            this.lblCantidadAlmacenado2.Text = "_______";
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 467);
            this.Controls.Add(this.mrcControAlimentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlacena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Alimentos";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.mrcControAlimentos.ResumeLayout(false);
            this.mrcAlmacenado.ResumeLayout(false);
            this.mrcAlmacenado.PerformLayout();
            this.mrcAlmacenar.ResumeLayout(false);
            this.mrcAlmacenar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcControAlimentos;
        private System.Windows.Forms.Label lblAlimento;
        private System.Windows.Forms.ComboBox cboLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.GroupBox mrcAlmacenar;
        private System.Windows.Forms.GroupBox mrcAlmacenado;
        private System.Windows.Forms.ComboBox cboAlimentoAlmacenado;
        private System.Windows.Forms.Label lblAlimentoAlmacenado;
        private System.Windows.Forms.ComboBox cboLugarAlmacenado;
        private System.Windows.Forms.Label lblLugarAlmacenado;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboAlimento;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label lblFechaAlmacenado2;
        private System.Windows.Forms.Label lblFechaAlmacenado;
        private System.Windows.Forms.Label lblCantidadAlmacenado2;
        private System.Windows.Forms.Label lblCantidadAlmacenado;
    }
}