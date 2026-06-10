namespace FerreTec
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void HerramientasManuales_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HManuales ventana = new HManuales("Herramientas Manuales");
            ventana.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HManuales ventana = new HManuales("Acero");
            ventana.Show();
            this.Hide();
        }

        private void Plomeria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HManuales ventana = new HManuales("Plomeria");
            ventana.Show();
            this.Hide();
        }

        private void Plomeria_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HManuales ventana = new HManuales("Plomeria");
            ventana.Show();
            this.Hide();
        }

        private void PElectricos_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HManuales ventana = new HManuales("Electricos");
            ventana.Show();
            this.Hide();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string busqueda = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Escribe el nombre de un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string rutaExcel = Path.Combine(Application.StartupPath, "inventario.xlsx");
            GestorExcel gestor = new GestorExcel(rutaExcel);
            var productos = gestor.LeerProductos();

            var resultado = productos.FirstOrDefault(p =>
                p.Nombre.ToLower().Contains(busqueda));

            if (resultado != null)
            {
                MessageBox.Show(
                    $"Producto encontrado:\n\n" +
                    $"Nombre: {resultado.Nombre}\n" +
                    $"Precio: ${resultado.Precio}\n" +
                    $"Stock disponible: {resultado.Cantidad} unidades\n" +
                    $"Marca: {resultado.Marca}\n" +
                    $"Categoría: {resultado.Categoria}",
                    "Stock disponible",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se encontró ningún producto con '{textBox1.Text}'.",
                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Agregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevoProducto ventana = new NuevoProducto();
            ventana.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}