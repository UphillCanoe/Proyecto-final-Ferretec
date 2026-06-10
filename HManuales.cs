using OfficeOpenXml;

namespace FerreTec
{
    public partial class HManuales : Form
    {
        private List<Producto> productos = new List<Producto>();
        private string categoria;

        public HManuales(string categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            ConfigurarVentana();
            CargarProductos();
            MostrarProductos();
        }

        private void ConfigurarVentana()
        {
            lblCategoria.Text = categoria.ToUpper();
            lblCategoria.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(255, 128, 0);

            string icono = categoria switch
            {
                "Herramientas Manuales" => "Herramienta1.png",
                "Plomeria" => "Herramienta2.png",
                "Electricos" => "Herramienta3.png",
                "Acero" => "Herramienta4.png",
                _ => "Herramienta1.png"
            };

            string rutaIcono = Path.Combine(Application.StartupPath, "Imagenes", icono);
            if (File.Exists(rutaIcono))
                picIcono.Image = Image.FromFile(rutaIcono);
            picIcono.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void CargarProductos()
        {
            string rutaExcel = Path.Combine(Application.StartupPath, "inventario.xlsx");
            GestorExcel gestor = new GestorExcel(rutaExcel);
            productos = gestor.LeerProductos()
                              .Where(p => p.Categoria == categoria)
                              .ToList();
        }

        private void MostrarProductos()
        {
            MessageBox.Show($"Productos encontrados: {productos.Count}");
            flowProductos.Controls.Clear();
            flowProductos.Controls.Clear();
            flowProductos.Padding = new Padding(10);

            foreach (var producto in productos)
            {
                // Panel contenedor de cada producto
                Panel panel = new Panel();
                panel.Size = new Size(150, 200);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Margin = new Padding(10);
                panel.Cursor = Cursors.Hand;
                panel.Tag = producto;
                panel.Click += Producto_Click;

                // Imagen del producto
                PictureBox pic = new PictureBox();
                pic.Size = new Size(130, 130);
                pic.Location = new Point(10, 10);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Tag = producto;
                pic.Click += Producto_Click;
                pic.Cursor = Cursors.Hand;

                string rutaImg = Path.Combine(Application.StartupPath, "Imagenes", producto.RutaImagen ?? "");
                if (File.Exists(rutaImg))
                    pic.Image = Image.FromFile(rutaImg);

                // Nombre del producto
                LinkLabel lbl = new LinkLabel();
                lbl.Text = producto.Nombre + " →";
                lbl.Location = new Point(5, 148);
                lbl.Size = new Size(140, 40);
                lbl.LinkColor = Color.FromArgb(255, 128, 0);
                lbl.Font = new Font("Segoe UI", 8);
                lbl.Tag = producto;
                lbl.Click += Producto_Click;

                panel.Controls.Add(pic);
                panel.Controls.Add(lbl);
                flowProductos.Controls.Add(panel);
            }
        }

        private void Producto_Click(object? sender, EventArgs e)
        {
            var control = sender as Control;
            if (control?.Tag is Producto producto)
            {
                DetalleProducto detalle = new DetalleProducto(producto);
                detalle.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}