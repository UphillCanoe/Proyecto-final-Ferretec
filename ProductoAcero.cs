namespace FerreTec
{
    public class ProductoAcero : Producto
    {
        public string Grosor { get; set; }

        public ProductoAcero(int id, string nombre, decimal precio,
                             int cantidad, string marca, string grosor)
            : base(id, nombre, precio, cantidad, marca, "Acero")
        {
            Grosor = grosor;
        }

        public override string MostrarInfo()
        {
            return base.MostrarInfo() + $" | Grosor: {Grosor}";
        }
    }
}