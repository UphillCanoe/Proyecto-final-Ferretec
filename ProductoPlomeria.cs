namespace FerreTec
{
    public class ProductoPlomeria : Producto
    {
        public string TipoConexion { get; set; }

        public ProductoPlomeria(int id, string nombre, decimal precio,
                                int cantidad, string marca, string conexion)
            : base(id, nombre, precio, cantidad, marca, "Plomeria")
        {
            TipoConexion = conexion;
        }

        public override string MostrarInfo()
        {
            return base.MostrarInfo() + $" | Conexion: {TipoConexion}";
        }
    }
}