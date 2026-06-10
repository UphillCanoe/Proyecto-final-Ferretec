namespace FerreTec
{
    public partial class DetalleProducto : Form
    {
        private Producto producto;

        public DetalleProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            // Imagen del producto
            string rutaImg = Path.Combine(Application.StartupPath, "Imagenes", producto.RutaImagen ?? "");
            if (File.Exists(rutaImg))
            {
                pictureBox1.Image = Image.FromFile(rutaImg);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }

            // DataGridView con estilo naranja
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("campo", "Campo");
            dataGridView1.Columns.Add("valor", "Valor");

            dataGridView1.Rows.Add("Nombre", producto.Nombre);
            dataGridView1.Rows.Add("Precio", $"${producto.Precio}");
            dataGridView1.Rows.Add("Cantidad", producto.Cantidad.ToString());
            dataGridView1.Rows.Add("Marca", producto.Marca);
            dataGridView1.Rows.Add("ID", producto.Id.ToString());

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Columns["campo"].Width = 100;
            dataGridView1.Columns["valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Cantidad a agregar:", "Agregar Stock", "0");

            try
            {
                int cantidad = int.Parse(input);
                producto.AgregarStock(cantidad);

                string rutaExcel = Path.Combine(Application.StartupPath, "inventario.xlsx");
                GestorExcel gestor = new GestorExcel(rutaExcel);
                var todos = gestor.LeerProductos();
                var item = todos.FirstOrDefault(p => p.Id == producto.Id);
                if (item != null)
                    item.Cantidad = producto.Cantidad;
                gestor.GuardarProductos(todos);


                // Actualizar también el DataGridView
                dataGridView1.Rows[2].Cells["valor"].Value = producto.Cantidad.ToString();

                MessageBox.Show("Stock actualizado correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void DetalleProducto_Load(object sender, EventArgs e)
        {
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is HManuales)
                {
                    f.Show();
                    break;
                }
            }
            this.Close();
        }
    }
}