namespace ProyectoFinalProgramacion2
{
    partial class BorrarProductos
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
            btnLimpiarFiltro = new Button();
            btnBorrarProducto = new Button();
            dgvBorrarProducto = new DataGridView();
            panel1 = new Panel();
            txtFiltroBuscar = new TextBox();
            label1 = new Label();
            btnBuscarProducto = new Button();
            panel2 = new Panel();
            txtIDProtuctoBorrar = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPrecioProducto = new TextBox();
            txtCategoriaProducto = new TextBox();
            txtModeloProducto = new TextBox();
            txtMarcaProducto = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBorrarProducto).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.BackColor = SystemColors.HotTrack;
            btnLimpiarFiltro.FlatAppearance.BorderSize = 0;
            btnLimpiarFiltro.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltro.ForeColor = SystemColors.ControlLightLight;
            btnLimpiarFiltro.Location = new Point(733, 481);
            btnLimpiarFiltro.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(112, 51);
            btnLimpiarFiltro.TabIndex = 19;
            btnLimpiarFiltro.Text = "Limpiar";
            btnLimpiarFiltro.UseVisualStyleBackColor = false;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.BackColor = SystemColors.HotTrack;
            btnBorrarProducto.FlatAppearance.BorderSize = 0;
            btnBorrarProducto.FlatStyle = FlatStyle.Flat;
            btnBorrarProducto.ForeColor = SystemColors.ControlLightLight;
            btnBorrarProducto.Location = new Point(733, 422);
            btnBorrarProducto.Margin = new Padding(3, 4, 3, 4);
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.Size = new Size(112, 51);
            btnBorrarProducto.TabIndex = 18;
            btnBorrarProducto.Text = "Borrar";
            btnBorrarProducto.UseVisualStyleBackColor = false;
            btnBorrarProducto.Click += btnBorrarProducto_Click;
            // 
            // dgvBorrarProducto
            // 
            dgvBorrarProducto.BackgroundColor = SystemColors.HotTrack;
            dgvBorrarProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrarProducto.Location = new Point(27, 119);
            dgvBorrarProducto.Margin = new Padding(3, 4, 3, 4);
            dgvBorrarProducto.Name = "dgvBorrarProducto";
            dgvBorrarProducto.ReadOnly = true;
            dgvBorrarProducto.RowHeadersWidth = 51;
            dgvBorrarProducto.Size = new Size(604, 413);
            dgvBorrarProducto.TabIndex = 17;
            dgvBorrarProducto.CellClick += dgvBorrarProducto_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(txtFiltroBuscar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 33);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 77);
            panel1.TabIndex = 20;
            // 
            // txtFiltroBuscar
            // 
            txtFiltroBuscar.Location = new Point(23, 39);
            txtFiltroBuscar.Margin = new Padding(3, 4, 3, 4);
            txtFiltroBuscar.Name = "txtFiltroBuscar";
            txtFiltroBuscar.Size = new Size(558, 27);
            txtFiltroBuscar.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 14;
            label1.Text = "Filtrar";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = SystemColors.HotTrack;
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ForeColor = SystemColors.ControlLightLight;
            btnBuscarProducto.Location = new Point(733, 363);
            btnBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(112, 51);
            btnBuscarProducto.TabIndex = 21;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(txtIDProtuctoBorrar);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPrecioProducto);
            panel2.Controls.Add(txtCategoriaProducto);
            panel2.Controls.Add(txtModeloProducto);
            panel2.Controls.Add(txtMarcaProducto);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(658, 33);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 322);
            panel2.TabIndex = 22;
            // 
            // txtIDProtuctoBorrar
            // 
            txtIDProtuctoBorrar.Location = new Point(23, 60);
            txtIDProtuctoBorrar.Margin = new Padding(3, 4, 3, 4);
            txtIDProtuctoBorrar.Name = "txtIDProtuctoBorrar";
            txtIDProtuctoBorrar.ReadOnly = true;
            txtIDProtuctoBorrar.Size = new Size(141, 27);
            txtIDProtuctoBorrar.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(6, 15);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 24;
            label7.Text = "Se eliminara:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(23, 256);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 22;
            label6.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(23, 201);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 21;
            label5.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(23, 146);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 20;
            label3.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(23, 91);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 19;
            label2.Text = "Marca";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(23, 280);
            txtPrecioProducto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.ReadOnly = true;
            txtPrecioProducto.Size = new Size(141, 27);
            txtPrecioProducto.TabIndex = 18;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.Location = new Point(23, 225);
            txtCategoriaProducto.Margin = new Padding(3, 4, 3, 4);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.ReadOnly = true;
            txtCategoriaProducto.Size = new Size(141, 27);
            txtCategoriaProducto.TabIndex = 17;
            // 
            // txtModeloProducto
            // 
            txtModeloProducto.Location = new Point(23, 170);
            txtModeloProducto.Margin = new Padding(3, 4, 3, 4);
            txtModeloProducto.Name = "txtModeloProducto";
            txtModeloProducto.ReadOnly = true;
            txtModeloProducto.Size = new Size(141, 27);
            txtModeloProducto.TabIndex = 16;
            // 
            // txtMarcaProducto
            // 
            txtMarcaProducto.Location = new Point(23, 115);
            txtMarcaProducto.Margin = new Padding(3, 4, 3, 4);
            txtMarcaProducto.Name = "txtMarcaProducto";
            txtMarcaProducto.ReadOnly = true;
            txtMarcaProducto.Size = new Size(141, 27);
            txtMarcaProducto.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(23, 36);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 14;
            label4.Text = "ID";
            // 
            // BorrarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(btnBuscarProducto);
            Controls.Add(btnLimpiarFiltro);
            Controls.Add(btnBorrarProducto);
            Controls.Add(dgvBorrarProducto);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BorrarProductos";
            Text = "BorrarProductos";
            ((System.ComponentModel.ISupportInitialize)dgvBorrarProducto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLimpiarFiltro;
        private Button btnBorrarProducto;
        private DataGridView dgvBorrarProducto;
        private Panel panel1;
        private TextBox txtFiltroBuscar;
        private Label label1;
        private Button btnBuscarProducto;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtPrecioProducto;
        private TextBox txtCategoriaProducto;
        private TextBox txtModeloProducto;
        private TextBox txtMarcaProducto;
        private Label label4;
        private Label label7;
        private TextBox txtIDProtuctoBorrar;
    }
}