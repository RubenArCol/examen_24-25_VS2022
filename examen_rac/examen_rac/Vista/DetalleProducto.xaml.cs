using examen_rac.Modelo;

namespace examen_rac.Vista
{
    public partial class DetalleProducto : ContentPage
    {
        public Producto Producto { get; set; }

        public DetalleProducto(Producto producto)
        {
            InitializeComponent(); 
            Producto = producto;
            BindingContext = this;
        }
    }
}