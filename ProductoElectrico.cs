namespace FerreTec
{
    public class ProductoElectrico : Producto
    {
        public string Voltaje { get; set; }

        public ProductoElectrico(int id, string nombre, decimal precio,
                                 int cantidad, string marca, string voltaje)
            : base(id, nombre, precio, cantidad, marca, "Electricos")
        {
            Voltaje = voltaje;
        }

        public override string MostrarInfo()
        {
            return base.MostrarInfo() + $" | Voltaje: {Voltaje}";
        }
    }
}