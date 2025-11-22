namespace ProyectoFinalProgramacion2
{
    partial class EditarProductos
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
            label1 = new Label();
            txtFiltroBuscar = new TextBox();
            dgvEditarProducto = new DataGridView();
            btnEditarProducto = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPrecioProducto = new TextBox();
            txtCategoriaProducto = new TextBox();
            txtModeloProducto = new TextBox();
            txtMarcaProducto = new TextBox();
            txtIDProducto = new TextBox();
            label4 = new Label();
            btnBuscarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEditarProducto).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // txtFiltroBuscar
            // 
            txtFiltroBuscar.Location = new Point(23, 39);
            txtFiltroBuscar.Margin = new Padding(3, 4, 3, 4);
            txtFiltroBuscar.Name = "txtFiltroBuscar";
            txtFiltroBuscar.Size = new Size(556, 27);
            txtFiltroBuscar.TabIndex = 10;
            // 
            // dgvEditarProducto
            // 
            dgvEditarProducto.BackgroundColor = Color.DodgerBlue;
            dgvEditarProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditarProducto.Location = new Point(27, 119);
            dgvEditarProducto.Margin = new Padding(3, 4, 3, 4);
            dgvEditarProducto.Name = "dgvEditarProducto";
            dgvEditarProducto.ReadOnly = true;
            dgvEditarProducto.RowHeadersWidth = 51;
            dgvEditarProducto.Size = new Size(604, 413);
            dgvEditarProducto.TabIndex = 9;
            dgvEditarProducto.CellDoubleClick += dgvEditarProducto_CellDoubleClick;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.BackColor = Color.DodgerBlue;
            btnEditarProducto.FlatAppearance.BorderSize = 0;
            btnEditarProducto.FlatStyle = FlatStyle.Flat;
            btnEditarProducto.ForeColor = SystemColors.ControlLightLight;
            btnEditarProducto.Location = new Point(733, 481);
            btnEditarProducto.Margin = new Padding(3, 4, 3, 4);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(112, 51);
            btnEditarProducto.TabIndex = 12;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = false;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(txtFiltroBuscar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 33);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 77);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPrecioProducto);
            panel2.Controls.Add(txtCategoriaProducto);
            panel2.Controls.Add(txtModeloProducto);
            panel2.Controls.Add(txtMarcaProducto);
            panel2.Controls.Add(txtIDProducto);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(658, 33);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 313);
            panel2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(23, 240);
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
            label5.Location = new Point(23, 185);
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
            label3.Location = new Point(23, 130);
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
            label2.Location = new Point(23, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 19;
            label2.Text = "Marca";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(23, 264);
            txtPrecioProducto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(141, 27);
            txtPrecioProducto.TabIndex = 18;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.Location = new Point(23, 209);
            txtCategoriaProducto.Margin = new Padding(3, 4, 3, 4);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.Size = new Size(141, 27);
            txtCategoriaProducto.TabIndex = 17;
            // 
            // txtModeloProducto
            // 
            txtModeloProducto.Location = new Point(23, 154);
            txtModeloProducto.Margin = new Padding(3, 4, 3, 4);
            txtModeloProducto.Name = "txtModeloProducto";
            txtModeloProducto.Size = new Size(141, 27);
            txtModeloProducto.TabIndex = 16;
            // 
            // txtMarcaProducto
            // 
            txtMarcaProducto.Location = new Point(23, 97);
            txtMarcaProducto.Margin = new Padding(3, 4, 3, 4);
            txtMarcaProducto.Name = "txtMarcaProducto";
            txtMarcaProducto.Size = new Size(141, 27);
            txtMarcaProducto.TabIndex = 15;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(23, 39);
            txtIDProducto.Margin = new Padding(3, 4, 3, 4);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.ReadOnly = true;
            txtIDProducto.Size = new Size(141, 27);
            txtIDProducto.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(23, 15);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 14;
            label4.Text = "ID";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.DodgerBlue;
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ForeColor = SystemColors.ControlLightLight;
            btnBuscarProducto.Location = new Point(733, 412);
            btnBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(112, 51);
            btnBuscarProducto.TabIndex = 18;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // EditarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 600);
            Controls.Add(btnBuscarProducto);
            Controls.Add(panel2);
            Controls.Add(btnEditarProducto);
            Controls.Add(dgvEditarProducto);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditarProductos";
            Text = "EditarProductos";
            ((System.ComponentModel.ISupportInitialize)dgvEditarProducto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtFiltroBuscar;
        private DataGridView dgvEditarProducto;
        private Button btnEditarProducto;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtPrecioProducto;
        private TextBox txtCategoriaProducto;
        private TextBox txtModeloProducto;
        private TextBox txtMarcaProducto;
        private TextBox txtIDProducto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Button btnBuscarProducto;
    }
}