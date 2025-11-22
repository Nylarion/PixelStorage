namespace ProyectoFinalProgramacion2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            btnIniciarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(159, 140);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(268, 27);
            txtContrasena.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(159, 87);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(268, 27);
            txtUsuario.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(432, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 47);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(432, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 47);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtContrasena);
            panel1.Location = new Point(127, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 249);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(45, 140);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 9;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(76, 86);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 8;
            label2.Text = "Usuario";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = SystemColors.Highlight;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.ForeColor = SystemColors.ControlLightLight;
            btnIniciarSesion.Location = new Point(659, 376);
            btnIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(107, 47);
            btnIniciarSesion.TabIndex = 7;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnIniciarSesion);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtContrasena;
        private PictureBox pictureBox1;
        private TextBox txtUsuario;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Button btnIniciarSesion;
    }
}