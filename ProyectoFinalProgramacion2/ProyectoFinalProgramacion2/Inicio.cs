using ProyectoFinalProgramacion2.App_Code;

namespace ProyectoFinalProgramacion2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            AbrirPanel(new Bienvenida());
        }

        private void CargarUser()
        {

        }

        Button botonSeleccionado = null;
        private void AbrirPanel(Form formInfo)
        {

            PanelInformacion.Controls.Clear();

            formInfo.TopLevel = false;
            formInfo.Dock = DockStyle.Fill;
            formInfo.FormBorderStyle = FormBorderStyle.None;

            PanelInformacion.Controls.Add(formInfo);
            formInfo.Show();

        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = SystemColors.Highlight;
            }
            btn.BackColor = Color.DodgerBlue;
            botonSeleccionado = btn;

            AbrirPanel(new AgregarProductos());
            lblCategorias.Text = "Agregar Productos";
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = SystemColors.Highlight;
            }
            btn.BackColor = Color.DodgerBlue;
            botonSeleccionado = btn;

            AbrirPanel(new BuscarProductos());
            lblCategorias.Text = "Buscar Productos";
        }

        private void btnEditarProductos_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = SystemColors.Highlight;
            }
            btn.BackColor = Color.DodgerBlue;
            botonSeleccionado = btn;

            AbrirPanel(new EditarProductos());
            lblCategorias.Text = "Editar Productos";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btnBorrarProductos_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = SystemColors.Highlight;
            }
            btn.BackColor = Color.DodgerBlue;
            botonSeleccionado = btn;

            AbrirPanel(new BorrarProductos());
            lblCategorias.Text = "Borrar Productos";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = SystemColors.Highlight;
            }
            btn.BackColor = Color.DodgerBlue;
            botonSeleccionado = btn;

            AbrirPanel(new Bienvenida());
            lblCategorias.Text = "Bienvenido";
        }
    }
}
