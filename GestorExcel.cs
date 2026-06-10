using OfficeOpenXml;

namespace FerreTec
{
    public class GestorExcel
    {
        private string ruta;

        public GestorExcel(string rutaArchivo)
        {
            ruta = rutaArchivo;
            ExcelPackage.License.SetNonCommercialPersonal("FerreTec");
        }

        public List<Producto> LeerProductos()
        {
            var lista = new List<Producto>();
            try
            {
                using var paquete = new ExcelPackage(new FileInfo(ruta));
                var hoja = paquete.Workbook.Worksheets.FirstOrDefault();
                if (hoja == null)
                {
                    MessageBox.Show("No se encontro ninguna hoja.");
                    return lista;
                }

                for (int fila = 2; fila <= hoja.Dimension.End.Row; fila++)
                {
                    string idTexto = hoja.Cells[fila, 1].Text;

                    // Si no es número (ej. fila TOTAL) se detiene
                    if (!int.TryParse(idTexto, out int id)) break;

                    string nombre = hoja.Cells[fila, 2].Text;
                    string precioTxt = hoja.Cells[fila, 3].Text;
                    string cantTxt = hoja.Cells[fila, 4].Text;
                    string marca = hoja.Cells[fila, 5].Text;
                    string categoria = hoja.Cells[fila, 6].Text;
                    string imagen = hoja.Cells[fila, 7].Text;

                    if (!decimal.TryParse(precioTxt, out decimal precio)) continue;
                    if (!int.TryParse(cantTxt, out int cantidad)) continue;

                    Producto p = categoria switch
                    {
                        "Herramientas Manuales" => new ProductoHerramienta(id, nombre, precio, cantidad, marca, "General"),
                        "Plomeria" => new ProductoPlomeria(id, nombre, precio, cantidad, marca, "General"),
                        "Electricos" => new ProductoElectrico(id, nombre, precio, cantidad, marca, "110V"),
                        "Acero" => new ProductoAcero(id, nombre, precio, cantidad, marca, "Estandar"),
                        _ => new Producto(id, nombre, precio, cantidad, marca, categoria)
                    };
                    p.RutaImagen = imagen;
                    lista.Add(p);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se encontro el archivo Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }

        public void GuardarProductos(List<Producto> productos)
        {
            try
            {
                using var paquete = new ExcelPackage(new FileInfo(ruta));
                var hoja = paquete.Workbook.Worksheets.FirstOrDefault();
                if (hoja == null) return;

                for (int i = 0; i < productos.Count; i++)
                {
                    hoja.Cells[i + 2, 1].Value = productos[i].Id;
                    hoja.Cells[i + 2, 2].Value = productos[i].Nombre;
                    hoja.Cells[i + 2, 3].Value = productos[i].Precio;
                    hoja.Cells[i + 2, 4].Value = productos[i].Cantidad;
                    hoja.Cells[i + 2, 5].Value = productos[i].Marca;
                    hoja.Cells[i + 2, 6].Value = productos[i].Categoria;
                    hoja.Cells[i + 2, 7].Value = productos[i].RutaImagen;
                }
                paquete.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}