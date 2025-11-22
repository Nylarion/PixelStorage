namespace ProyectoFinalProgramacion2
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(71, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 455);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(448, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(46, 38);
            label1.Name = "label1";
            label1.Size = new Size(249, 28);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido a PixelStorage!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(46, 86);
            label2.Name = "label2";
            label2.Size = new Size(254, 23);
            label2.TabIndex = 1;
            label2.Text = "Primera version de PixelStorage,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(53, 109);
            label3.Name = "label3";
            label3.Size = new Size(242, 23);
            label3.TabIndex = 2;
            label3.Text = "versión en desarrollo. Ya tiene ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(46, 132);
            label4.Name = "label4";
            label4.Size = new Size(265, 23);
            label4.TabIndex = 3;
            label4.Text = "funciones como Agregar, Buscar, ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(64, 155);
            label5.Name = "label5";
            label5.Size = new Size(205, 23);
            label5.TabIndex = 4;
            label5.Text = "Editar y Borrar productos.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(77, 403);
            label6.Name = "label6";
            label6.Size = new Size(196, 23);
            label6.TabIndex = 5;
            label6.Text = "Disfruta de la aplicación.";
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 509);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Bienvenida";
            Text = "Bienvenida";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}