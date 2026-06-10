namespace FerreTec
{
    public class ProductoHerramienta : Producto
    {
        public string TipoHerramienta { get; set; }

        public ProductoHerramienta(int id, string nombre, decimal precio,
                                   int cantidad, string marca, string tipo)
            : base(id, nombre, precio, cantidad, marca, "Herramientas Manuales")
        {
            TipoHerramienta = tipo;
        }

        public override string MostrarInfo()
        {
            return base.MostrarInfo() + $" | Tipo: {TipoHerramienta}";
        }
    }
}   