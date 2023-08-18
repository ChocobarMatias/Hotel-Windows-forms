namespace ProyectoFinal_Grupo1_Com2
{
    partial class Pagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDos = new System.Windows.Forms.Label();
            this.lblUno = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblConsumo1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.rdoEfectivo = new System.Windows.Forms.RadioButton();
            this.rdoTarjeta = new System.Windows.Forms.RadioButton();
            this.rdoCrypto = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.lblDos);
            this.groupBox1.Controls.Add(this.lblUno);
            this.groupBox1.Controls.Add(this.lblDatos);
            this.groupBox1.Controls.Add(this.lblConsumo1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(214, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(357, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hora/s Seleccionada";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDos
            // 
            this.lblDos.AutoSize = true;
            this.lblDos.Location = new System.Drawing.Point(208, 46);
            this.lblDos.Name = "lblDos";
            this.lblDos.Size = new System.Drawing.Size(51, 16);
            this.lblDos.TabIndex = 9;
            this.lblDos.Text = "label2";
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Location = new System.Drawing.Point(19, 46);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(51, 16);
            this.lblUno.TabIndex = 8;
            this.lblUno.Text = "label1";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(14, 31);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(0, 16);
            this.lblDatos.TabIndex = 7;
            // 
            // lblConsumo1
            // 
            this.lblConsumo1.AutoSize = true;
            this.lblConsumo1.Location = new System.Drawing.Point(5, 26);
            this.lblConsumo1.Name = "lblConsumo1";
            this.lblConsumo1.Size = new System.Drawing.Size(0, 16);
            this.lblConsumo1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.lblValor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(535, 296);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(177, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOTAL A ABONAR";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(20, 29);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(16, 16);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "$";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(24, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar mi Compra";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbonar
            // 
            this.btnAbonar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbonar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAbonar.Location = new System.Drawing.Point(570, 473);
            this.btnAbonar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(142, 36);
            this.btnAbonar.TabIndex = 5;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.UseVisualStyleBackColor = false;
            this.btnAbonar.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdoEfectivo
            // 
            this.rdoEfectivo.AutoSize = true;
            this.rdoEfectivo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEfectivo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdoEfectivo.Location = new System.Drawing.Point(18, 296);
            this.rdoEfectivo.Name = "rdoEfectivo";
            this.rdoEfectivo.Size = new System.Drawing.Size(391, 20);
            this.rdoEfectivo.TabIndex = 6;
            this.rdoEfectivo.TabStop = true;
            this.rdoEfectivo.Text = "Abonando en EFECTIVO tenés un 10% de Descuento";
            this.rdoEfectivo.UseVisualStyleBackColor = false;
            this.rdoEfectivo.CheckedChanged += new System.EventHandler(this.rdoEfectivo_CheckedChanged);
            // 
            // rdoTarjeta
            // 
            this.rdoTarjeta.AutoSize = true;
            this.rdoTarjeta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTarjeta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdoTarjeta.Location = new System.Drawing.Point(18, 327);
            this.rdoTarjeta.Name = "rdoTarjeta";
            this.rdoTarjeta.Size = new System.Drawing.Size(437, 20);
            this.rdoTarjeta.TabIndex = 7;
            this.rdoTarjeta.TabStop = true;
            this.rdoTarjeta.Text = "Abonando con Tarjeta de Credito tenés un 15% de Recargo";
            this.rdoTarjeta.UseVisualStyleBackColor = false;
            this.rdoTarjeta.CheckedChanged += new System.EventHandler(this.rdoTarjeta_CheckedChanged);
            // 
            // rdoCrypto
            // 
            this.rdoCrypto.AutoSize = true;
            this.rdoCrypto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoCrypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCrypto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdoCrypto.Location = new System.Drawing.Point(18, 359);
            this.rdoCrypto.Name = "rdoCrypto";
            this.rdoCrypto.Size = new System.Drawing.Size(348, 20);
            this.rdoCrypto.TabIndex = 8;
            this.rdoCrypto.TabStop = true;
            this.rdoCrypto.Text = "Abona con Criptos tenés un 20% de Descuento";
            this.rdoCrypto.UseVisualStyleBackColor = false;
            this.rdoCrypto.CheckedChanged += new System.EventHandler(this.rdoCrypto_CheckedChanged);
            // 
            // Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.rdoCrypto);
            this.Controls.Add(this.rdoTarjeta);
            this.Controls.Add(this.rdoEfectivo);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Label lblConsumo1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.RadioButton rdoEfectivo;
        private System.Windows.Forms.RadioButton rdoTarjeta;
        private System.Windows.Forms.RadioButton rdoCrypto;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblDos;
        private System.Windows.Forms.Label lblUno;
    }
}