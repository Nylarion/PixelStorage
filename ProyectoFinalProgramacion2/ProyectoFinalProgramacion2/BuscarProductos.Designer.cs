namespace ProyectoFinalProgramacion2
{
    partial class BuscarProductos
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
            btnBuscarProducto = new Button();
            dgvBuscarProducto = new DataGridView();
            panel1 = new Panel();
            txtFiltroBuscar = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarProducto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.BackColor = SystemColors.Highlight;
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
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = SystemColors.Highlight;
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ForeColor = SystemColors.ControlLightLight;
            btnBuscarProducto.Location = new Point(733, 407);
            btnBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(112, 51);
            btnBuscarProducto.TabIndex = 18;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // dgvBuscarProducto
            // 
            dgvBuscarProducto.BackgroundColor = SystemColors.Highlight;
            dgvBuscarProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarProducto.Location = new Point(27, 119);
            dgvBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            dgvBuscarProducto.Name = "dgvBuscarProducto";
            dgvBuscarProducto.ReadOnly = true;
            dgvBuscarProducto.RowHeadersWidth = 51;
            dgvBuscarProducto.Size = new Size(665, 413);
            dgvBuscarProducto.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(txtFiltroBuscar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 33);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 77);
            panel1.TabIndex = 20;
            // 
            // txtFiltroBuscar
            // 
            txtFiltroBuscar.Location = new Point(23, 39);
            txtFiltroBuscar.Margin = new Padding(3, 4, 3, 4);
            txtFiltroBuscar.Name = "txtFiltroBuscar";
            txtFiltroBuscar.Size = new Size(618, 27);
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
            // BuscarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 600);
            Controls.Add(btnLimpiarFiltro);
            Controls.Add(btnBuscarProducto);
            Controls.Add(dgvBuscarProducto);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BuscarProductos";
            Text = "BuscarProductos";
            ((System.ComponentModel.ISupportInitialize)dgvBuscarProducto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLimpiarFiltro;
        private Button btnBuscarProducto;
        private DataGridView dgvBuscarProducto;
        private Panel panel1;
        private TextBox txtFiltroBuscar;
        private Label label1;
    }
}