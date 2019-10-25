namespace EduktSoftFrontEnd
{
    partial class frmConfirmacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmacion));
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.lblListo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlConfirmar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            this.pnlConfirmar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCheck
            // 
            this.pbCheck.Image = global::EduktSoftFrontEnd.Properties.Resources.Check;
            this.pbCheck.Location = new System.Drawing.Point(323, 62);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(160, 150);
            this.pbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheck.TabIndex = 1;
            this.pbCheck.TabStop = false;
            // 
            // lblListo
            // 
            this.lblListo.AutoSize = true;
            this.lblListo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListo.Location = new System.Drawing.Point(357, 20);
            this.lblListo.Name = "lblListo";
            this.lblListo.Size = new System.Drawing.Size(88, 39);
            this.lblListo.TabIndex = 2;
            this.lblListo.Text = "Listo!";
            this.lblListo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(250, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Revise su correo electrónico.";
            // 
            // pnlConfirmar
            // 
            this.pnlConfirmar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlConfirmar.Controls.Add(this.label5);
            this.pnlConfirmar.Controls.Add(this.label4);
            this.pnlConfirmar.Controls.Add(this.lblCorreo);
            this.pnlConfirmar.Controls.Add(this.label3);
            this.pnlConfirmar.Controls.Add(this.label2);
            this.pnlConfirmar.Controls.Add(this.lblListo);
            this.pnlConfirmar.Controls.Add(this.pbCheck);
            this.pnlConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfirmar.Location = new System.Drawing.Point(0, 0);
            this.pnlConfirmar.Name = "pnlConfirmar";
            this.pnlConfirmar.Size = new System.Drawing.Size(800, 450);
            this.pnlConfirmar.TabIndex = 1;
            this.pnlConfirmar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConfirmar_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(252, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hemos enviado su nueva contraseña al correo:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCorreo.Location = new System.Drawing.Point(252, 276);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(0, 18);
            this.lblCorreo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(252, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Si no encuentra el correo reivse su carpeta de ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(252, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "spam.";
            // 
            // frmConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlConfirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfirmacion";
            this.Text = "EduktSoft";
            this.Load += new System.EventHandler(this.frmConfirmacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            this.pnlConfirmar.ResumeLayout(false);
            this.pnlConfirmar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.Label lblListo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCorreo;
    }
}