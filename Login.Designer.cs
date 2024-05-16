namespace TaskPlanner
{
    partial class Login
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
            this.botonIniciarsesion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Texto1Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonRegistrarse = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Texto2Contraseña = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonIniciarsesion
            // 
            this.botonIniciarsesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.botonIniciarsesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.botonIniciarsesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.botonIniciarsesion.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.botonIniciarsesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.botonIniciarsesion.FillColor = System.Drawing.Color.Black;
            this.botonIniciarsesion.FillColor2 = System.Drawing.Color.Black;
            this.botonIniciarsesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonIniciarsesion.ForeColor = System.Drawing.Color.White;
            this.botonIniciarsesion.Location = new System.Drawing.Point(142, 271);
            this.botonIniciarsesion.Name = "botonIniciarsesion";
            this.botonIniciarsesion.Size = new System.Drawing.Size(98, 33);
            this.botonIniciarsesion.TabIndex = 0;
            this.botonIniciarsesion.Text = "Iniciar Sesión";
            this.botonIniciarsesion.Click += new System.EventHandler(this.botonIniciarsesion_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 2;
            // 
            // Texto1Usuario
            // 
            this.Texto1Usuario.AutoSize = true;
            this.Texto1Usuario.Location = new System.Drawing.Point(176, 136);
            this.Texto1Usuario.Name = "Texto1Usuario";
            this.Texto1Usuario.Size = new System.Drawing.Size(43, 13);
            this.Texto1Usuario.TabIndex = 3;
            this.Texto1Usuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // botonRegistrarse
            // 
            this.botonRegistrarse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.botonRegistrarse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.botonRegistrarse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.botonRegistrarse.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.botonRegistrarse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.botonRegistrarse.FillColor = System.Drawing.Color.Black;
            this.botonRegistrarse.FillColor2 = System.Drawing.Color.Black;
            this.botonRegistrarse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonRegistrarse.ForeColor = System.Drawing.Color.White;
            this.botonRegistrarse.Location = new System.Drawing.Point(296, 271);
            this.botonRegistrarse.Name = "botonRegistrarse";
            this.botonRegistrarse.Size = new System.Drawing.Size(98, 33);
            this.botonRegistrarse.TabIndex = 5;
            this.botonRegistrarse.Text = "Registrarse";
            this.botonRegistrarse.Click += new System.EventHandler(this.botonRegistrarse_Click);
            // 
            // Texto2Contraseña
            // 
            this.Texto2Contraseña.AutoSize = true;
            this.Texto2Contraseña.Location = new System.Drawing.Point(179, 188);
            this.Texto2Contraseña.Name = "Texto2Contraseña";
            this.Texto2Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Texto2Contraseña.TabIndex = 6;
            this.Texto2Contraseña.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Iniciar Sesión";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Texto2Contraseña);
            this.Controls.Add(this.botonRegistrarse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Texto1Usuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonIniciarsesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton botonIniciarsesion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Texto1Usuario;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton botonRegistrarse;
        private System.Windows.Forms.Label Texto2Contraseña;
        private System.Windows.Forms.Label label3;
    }
}