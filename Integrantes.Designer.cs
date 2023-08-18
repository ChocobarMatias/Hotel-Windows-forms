namespace ProyectoFinal_Grupo1_Com2
{
    partial class Integrantes
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
            this.btnIntegrantes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picintegrantes = new System.Windows.Forms.PictureBox();
            this.btnizq = new System.Windows.Forms.Button();
            this.btnder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picintegrantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIntegrantes
            // 
            this.btnIntegrantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntegrantes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIntegrantes.Location = new System.Drawing.Point(662, 473);
            this.btnIntegrantes.Name = "btnIntegrantes";
            this.btnIntegrantes.Size = new System.Drawing.Size(102, 36);
            this.btnIntegrantes.TabIndex = 0;
            this.btnIntegrantes.Text = "Atras";
            this.btnIntegrantes.UseVisualStyleBackColor = false;
            this.btnIntegrantes.Click += new System.EventHandler(this.btnIntegrantes_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 433);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picintegrantes);
            this.panel2.Location = new System.Drawing.Point(12, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 415);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(153, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Integrantes del Grupo 1";
            // 
            // picintegrantes
            // 
            this.picintegrantes.Location = new System.Drawing.Point(-9, 0);
            this.picintegrantes.Name = "picintegrantes";
            this.picintegrantes.Size = new System.Drawing.Size(581, 412);
            this.picintegrantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picintegrantes.TabIndex = 0;
            this.picintegrantes.TabStop = false;
            // 
            // btnizq
            // 
            this.btnizq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnizq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnizq.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnizq.Location = new System.Drawing.Point(111, 473);
            this.btnizq.Name = "btnizq";
            this.btnizq.Size = new System.Drawing.Size(75, 36);
            this.btnizq.TabIndex = 2;
            this.btnizq.Text = "<<<";
            this.btnizq.UseVisualStyleBackColor = false;
            this.btnizq.Click += new System.EventHandler(this.btnizq_Click);
            // 
            // btnder
            // 
            this.btnder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnder.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnder.Location = new System.Drawing.Point(363, 473);
            this.btnder.Name = "btnder";
            this.btnder.Size = new System.Drawing.Size(75, 36);
            this.btnder.TabIndex = 3;
            this.btnder.Text = ">>>";
            this.btnder.UseVisualStyleBackColor = false;
            this.btnder.Click += new System.EventHandler(this.btnder_Click);
            // 
            // Integrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.btnder);
            this.Controls.Add(this.btnizq);
            this.Controls.Add(this.btnIntegrantes);
            this.Controls.Add(this.panel1);
            this.Name = "Integrantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integrantes";
            this.Load += new System.EventHandler(this.Integrantes_load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picintegrantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntegrantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picintegrantes;
        private System.Windows.Forms.Button btnizq;
        private System.Windows.Forms.Button btnder;
        private System.Windows.Forms.Label label1;
    }
}