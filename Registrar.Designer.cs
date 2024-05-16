namespace TaskPlanner
{
    partial class Registrar
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
            this.textoNombre = new System.Windows.Forms.Label();
            this.TextoContraseña = new System.Windows.Forms.Label();
            this.textoconfirma = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonRegistrarse = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // textoNombre
            // 
            this.textoNombre.AutoSize = true;
            this.textoNombre.Location = new System.Drawing.Point(119, 80);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(47, 13);
            this.textoNombre.TabIndex = 0;
            this.textoNombre.Text = "Nombre ";
            // 
            // TextoContraseña
            // 
            this.TextoContraseña.AutoSize = true;
            this.TextoContraseña.Location = new System.Drawing.Point(119, 128);
            this.TextoContraseña.Name = "TextoContraseña";
            this.TextoContraseña.Size = new System.Drawing.Size(61, 13);
            this.TextoContraseña.TabIndex = 1;
            this.TextoContraseña.Text = "Contraseña";
            // 
            // textoconfirma
            // 
            this.textoconfirma.AutoSize = true;
            this.textoconfirma.Location = new System.Drawing.Point(119, 183);
            this.textoconfirma.Name = "textoconfirma";
            this.textoconfirma.Size = new System.Drawing.Size(105, 13);
            this.textoconfirma.TabIndex = 2;
            this.textoconfirma.Text = "Confirma Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registrarse";
            // 
            // BotonRegistrarse
            // 
            this.BotonRegistrarse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BotonRegistrarse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BotonRegistrarse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonRegistrarse.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonRegistrarse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BotonRegistrarse.FillColor = System.Drawing.Color.Black;
            this.BotonRegistrarse.FillColor2 = System.Drawing.Color.Black;
            this.BotonRegistrarse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BotonRegistrarse.ForeColor = System.Drawing.Color.White;
            this.BotonRegistrarse.Location = new System.Drawing.Point(122, 263);
            this.BotonRegistrarse.Name = "BotonRegistrarse";
            this.BotonRegistrarse.Size = new System.Drawing.Size(180, 45);
            this.BotonRegistrarse.TabIndex = 8;
            this.BotonRegistrarse.Text = "Rregistrarse";
            this.BotonRegistrarse.Click += new System.EventHandler(this.BotonRegistrarse_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 355);
            this.Controls.Add(this.BotonRegistrarse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textoconfirma);
            this.Controls.Add(this.TextoContraseña);
            this.Controls.Add(this.textoNombre);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoNombre;
        private System.Windows.Forms.Label TextoContraseña;
        private System.Windows.Forms.Label textoconfirma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton BotonRegistrarse;
    }
}