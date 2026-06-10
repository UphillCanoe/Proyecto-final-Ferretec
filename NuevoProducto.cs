namespace FerreTec
{
    public partial class NuevoProducto : Form
    {
        private string rutaImagenSeleccionada = "";

        public NuevoProducto()
        {
            InitializeComponent();
            CargarComboCategorias();
            CargarTabla();
        }

        private void CargarComboCategorias()
        {
            comboTipo.Items.Clear();
            comboTipo.Items.Add("Herramientas Manuales");
            comboTipo.Items.Add("Plomeria");
            comboTipo.Items.Add("Electricos");
            comboTipo.Items.Add("Acero");
            comboTipo.SelectedIndex = 0;
        }

        private void CargarTabla()
        {
            string rutaExcel = Path.Combine(Application.StartupPath, "inventario.xlsx");
            GestorExcel gestor = new GestorExcel(rutaExcel);
            var productos = gestor.LeerProductos();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Marca", "Marca");
            dataGridView1.Columns.Add("Categoria", "Categoría");

            foreach (var p in productos)
                dataGridView1.Rows.Add(p.Id, p.Nombre, $"${p.Precio}", p.Cantidad, p.Marca, p.Categoria);

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridView1.Rows.Count > 0)
            {
                int ultima = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[ultima].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridView1.Rows[ultima].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void Guardar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                    string.IsNullOrWhiteSpace(txtMarca.Text))
                {
                    MessageBox.Show("Llena todos los campos.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string rutaExcel = Path.Combine(Application.StartupPath, "inventario.xlsx");
                GestorExcel gestor = new GestorExcel(rutaExcel);
                var todos = gestor.LeerProductos();
                int id = todos.Count > 0 ? todos.Max(x => x.Id) + 1 : 1;

                string nombre = txtNombre.Text.Trim();
                decimal precio = decimal.Parse(txtPrecio.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                string marca = txtMarca.Text.Trim();
                string categoria = comboTipo.SelectedItem?.ToString() ?? "";

                Producto p = categoria switch
                {
                    "Herramientas Manuales" => new ProductoHerramienta(id, nombre, precio, cantidad, marca, "General"),
                    "Plomeria" => new ProductoPlomeria(id, nombre, precio, cantidad, marca, "General"),
                    "Electricos" => new ProductoElectrico(id, nombre, precio, cantidad, marca, "110V"),
                    "Acero" => new ProductoAcero(id, nombre, precio, cantidad, marca, "Estandar"),
                    _ => new Producto(id, nombre, precio, cantidad, marca, categoria)
                };
                p.RutaImagen = rutaImagenSeleccionada;

                todos.Add(p);
                gestor.GuardarProductos(todos);

                MessageBox.Show("Producto guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarTabla();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifica que Precio y Cantidad sean números.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Borrar()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingresa el ID del producto a eliminar:", "Eliminar Producto", "");

            if (string.IsNullOrWhiteSpace(input)) return;

            try
            {
                int id = int.Parse(input);

                string rutaExcel = Path.Combine(Application.StartupPath, "inventario.xlsx");
                GestorExcel gestor = new GestorExcel(rutaExcel);
                var todos = gestor.LeerProductos();

                var producto = todos.FirstOrDefault(p => p.Id == id);

                if (producto == null)
                {
                    MessageBox.Show($"No se encontró ningún producto con ID {id}.", "No encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacion = MessageBox.Show(
                    $"¿Deseas eliminar '{producto.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    todos.Remove(producto);
                    gestor.GuardarProductos(todos);
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTabla();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un ID válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtMarca.Text = "";
            comboTipo.SelectedIndex = 0;
            pictureBox.Image = null;
            rutaImagenSeleccionada = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e) => Guardar();
        private void btnGuardar_Click_1(object sender, EventArgs e) => Guardar();
        private void btnSubir_Click(object sender, EventArgs e) => Guardar();
        private void btnSubir_Click_1(object sender, EventArgs e) => Guardar();

        private void btnBorrar_Click(object sender, EventArgs e) => Borrar();
        private void btnBorrar_Click_1(object sender, EventArgs e) => Borrar();

        private void btnSubirImagen_Click(object sender, EventArgs e) => AbrirImagen();
        private void btnSubirImagen_Click_1(object sender, EventArgs e) => AbrirImagen();

        private void AbrirImagen()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagenes|*.jpg;*.jpeg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                rutaImagenSeleccionada = Path.GetFileName(dialog.FileName);
                string destino = Path.Combine(Application.StartupPath, "Imagenes", rutaImagenSeleccionada);
                File.Copy(dialog.FileName, destino, true);
                pictureBox.Image = Image.FromFile(dialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Main)
                {
                    f.Show();
                    break;
                }
            }
            this.Close();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtMarca_TextChanged(object sender, EventArgs e) { }
        private void txtCantidad_TextChanged(object sender, EventArgs e) { }
        private void txtPrecio_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtId_TextChanged(object sender, EventArgs e) { }
    }
}