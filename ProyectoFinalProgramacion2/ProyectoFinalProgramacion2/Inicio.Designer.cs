namespace ProyectoFinalProgramacion2
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panel1 = new Panel();
            panel2 = new Panel();
            btnBorrarProductos = new Button();
            btnEditarProductos = new Button();
            btnCerrarSesion = new Button();
            btnBuscarProductos = new Button();
            btnAgregarProductos = new Button();
            btnInicio = new Button();
            panel3 = new Panel();
            lblPixelStorage = new Label();
            panel4 = new Panel();
            lblCategorias = new Label();
            PanelInformacion = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 675);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(btnBorrarProductos);
            panel2.Controls.Add(btnEditarProductos);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Controls.Add(btnBuscarProductos);
            panel2.Controls.Add(btnAgregarProductos);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 675);
            panel2.TabIndex = 1;
            // 
            // btnBorrarProductos
            // 
            btnBorrarProductos.Dock = DockStyle.Top;
            btnBorrarProductos.FlatAppearance.BorderSize = 0;
            btnBorrarProductos.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnBorrarProductos.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnBorrarProductos.FlatStyle = FlatStyle.Flat;
            btnBorrarProductos.ForeColor = SystemColors.ControlLightLight;
            btnBorrarProductos.Image = (Image)resources.GetObject("btnBorrarProductos.Image");
            btnBorrarProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrarProductos.Location = new Point(0, 401);
            btnBorrarProductos.Name = "btnBorrarProductos";
            btnBorrarProductos.Size = new Size(250, 73);
            btnBorrarProductos.TabIndex = 6;
            btnBorrarProductos.Text = "Borrar Productos";
            btnBorrarProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrarProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrarProductos.UseVisualStyleBackColor = true;
            btnBorrarProductos.Click += btnBorrarProductos_Click;
            // 
            // btnEditarProductos
            // 
            btnEditarProductos.Dock = DockStyle.Top;
            btnEditarProductos.FlatAppearance.BorderSize = 0;
            btnEditarProductos.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnEditarProductos.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnEditarProductos.FlatStyle = FlatStyle.Flat;
            btnEditarProductos.ForeColor = SystemColors.ControlLightLight;
            btnEditarProductos.Image = (Image)resources.GetObject("btnEditarProductos.Image");
            btnEditarProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarProductos.Location = new Point(0, 328);
            btnEditarProductos.Name = "btnEditarProductos";
            btnEditarProductos.Size = new Size(250, 73);
            btnEditarProductos.TabIndex = 5;
            btnEditarProductos.Text = "Editar Productos";
            btnEditarProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarProductos.UseVisualStyleBackColor = true;
            btnEditarProductos.Click += btnEditarProductos_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 602);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(250, 73);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnBuscarProductos
            // 
            btnBuscarProductos.Dock = DockStyle.Top;
            btnBuscarProductos.FlatAppearance.BorderSize = 0;
            btnBuscarProductos.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnBuscarProductos.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnBuscarProductos.FlatStyle = FlatStyle.Flat;
            btnBuscarProductos.ForeColor = SystemColors.ControlLightLight;
            btnBuscarProductos.Image = (Image)resources.GetObject("btnBuscarProductos.Image");
            btnBuscarProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarProductos.Location = new Point(0, 255);
            btnBuscarProductos.Name = "btnBuscarProductos";
            btnBuscarProductos.Size = new Size(250, 73);
            btnBuscarProductos.TabIndex = 2;
            btnBuscarProductos.Text = "Buscar Productos";
            btnBuscarProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarProductos.UseVisualStyleBackColor = true;
            btnBuscarProductos.Click += btnBuscarProductos_Click;
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.BackColor = SystemColors.Highlight;
            btnAgregarProductos.Dock = DockStyle.Top;
            btnAgregarProductos.FlatAppearance.BorderSize = 0;
            btnAgregarProductos.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnAgregarProductos.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnAgregarProductos.FlatStyle = FlatStyle.Flat;
            btnAgregarProductos.ForeColor = SystemColors.ControlLightLight;
            btnAgregarProductos.Image = (Image)resources.GetObject("btnAgregarProductos.Image");
            btnAgregarProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarProductos.Location = new Point(0, 182);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(250, 73);
            btnAgregarProductos.TabIndex = 1;
            btnAgregarProductos.Text = "Agregar Productos";
            btnAgregarProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarProductos.UseVisualStyleBackColor = false;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.Highlight;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ForeColor = SystemColors.ControlLightLight;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 109);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(250, 73);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(lblPixelStorage);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 109);
            panel3.TabIndex = 1;
            // 
            // lblPixelStorage
            // 
            lblPixelStorage.AutoSize = true;
            lblPixelStorage.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPixelStorage.ForeColor = SystemColors.ControlLightLight;
            lblPixelStorage.Location = new Point(57, 44);
            lblPixelStorage.Name = "lblPixelStorage";
            lblPixelStorage.Size = new Size(125, 25);
            lblPixelStorage.TabIndex = 0;
            lblPixelStorage.Text = "PixelStorage";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Controls.Add(lblCategorias);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(250, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(881, 109);
            panel4.TabIndex = 1;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCategorias.ForeColor = SystemColors.ControlLightLight;
            lblCategorias.Location = new Point(337, 44);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(147, 35);
            lblCategorias.TabIndex = 1;
            lblCategorias.Text = "Bienvenido";
            lblCategorias.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelInformacion
            // 
            PanelInformacion.Location = new Point(257, 121);
            PanelInformacion.Margin = new Padding(3, 4, 3, 4);
            PanelInformacion.Name = "PanelInformacion";
            PanelInformacion.Size = new Size(861, 537);
            PanelInformacion.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1131, 675);
            Controls.Add(PanelInformacion);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Inicio";
            Text = "PixelStorage";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCerrarSesion;
        private Button btnBuscarProductos;
        private Button btnAgregarProductos;
        private Panel panel3;
        private Button btnEditarProductos;
        private Panel panel4;
        private Panel PanelInformacion;
        private Label lblPixelStorage;
        private Label lblCategorias;
        private Button btnBorrarProductos;
        private Button btnInicio;
    }
}
