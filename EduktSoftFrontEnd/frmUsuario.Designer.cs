namespace EduktSoftFrontEnd
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblErrorInicioSesion = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblLinkOlvidoContra = new System.Windows.Forms.LinkLabel();
            this.pbOjo = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOjo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(198, 218);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(375, 26);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.Click += new System.EventHandler(this.txtNombreUsuario_Click);
            this.txtNombreUsuario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtNombreUsuario_PreviewKeyDown);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContrasena.Location = new System.Drawing.Point(198, 294);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(375, 26);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.Click += new System.EventHandler(this.txtContrasena_Click);
            this.txtContrasena.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtContrasena_PreviewKeyDown);
            // 
            // lblErrorInicioSesion
            // 
            this.lblErrorInicioSesion.AutoSize = true;
            this.lblErrorInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorInicioSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(60)))), ((int)(((byte)(129)))));
            this.lblErrorInicioSesion.Location = new System.Drawing.Point(194, 154);
            this.lblErrorInicioSesion.Name = "lblErrorInicioSesion";
            this.lblErrorInicioSesion.Size = new System.Drawing.Size(225, 20);
            this.lblErrorInicioSesion.TabIndex = 4;
            this.lblErrorInicioSesion.Text = "Usuario o contraseña inválidos";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIngresar.Location = new System.Drawing.Point(321, 371);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(136, 39);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnIngresar_PreviewKeyDown);
            // 
            // lblLinkOlvidoContra
            // 
            this.lblLinkOlvidoContra.AutoSize = true;
            this.lblLinkOlvidoContra.BackColor = System.Drawing.Color.Transparent;
            this.lblLinkOlvidoContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkOlvidoContra.Location = new System.Drawing.Point(366, 338);
            this.lblLinkOlvidoContra.Name = "lblLinkOlvidoContra";
            this.lblLinkOlvidoContra.Size = new System.Drawing.Size(207, 20);
            this.lblLinkOlvidoContra.TabIndex = 0;
            this.lblLinkOlvidoContra.TabStop = true;
            this.lblLinkOlvidoContra.Text = "¿Olvidaste tu contraseña? :(";
            // 
            // pbOjo
            // 
            this.pbOjo.Location = new System.Drawing.Point(594, 294);
            this.pbOjo.Name = "pbOjo";
            this.pbOjo.Size = new System.Drawing.Size(28, 26);
            this.pbOjo.TabIndex = 5;
            this.pbOjo.TabStop = false;
            this.pbOjo.Click += new System.EventHandler(this.pbOjo_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(198, 68);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(375, 58);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbOjo);
            this.Controls.Add(this.lblLinkOlvidoContra);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblErrorInicioSesion);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNombreUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuario";
            this.Text = "EduktSoft";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOjo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblErrorInicioSesion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel lblLinkOlvidoContra;
        private System.Windows.Forms.PictureBox pbOjo;
    }
}