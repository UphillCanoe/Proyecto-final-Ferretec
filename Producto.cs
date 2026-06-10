namespace FerreTec
{
    public class Producto : IInventariable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string RutaImagen { get; set; }

        // Sobrecarga 1: constructor minimo
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = 0;
            Marca = "Sin marca";
        }

        // Sobrecarga 2: constructor completo
        public Producto(int id, string nombre, decimal precio,
                        int cantidad, string marca, string categoria)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Marca = marca;
            Categoria = categoria;
        }

        public virtual void AgregarStock(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");
            Cantidad += cantidad;
        }

        public virtual string MostrarInfo()
        {
            return $"[{Id}] {Nombre} | ${Precio} | Stock: {Cantidad} | Marca: {Marca}";
        }
    }
}