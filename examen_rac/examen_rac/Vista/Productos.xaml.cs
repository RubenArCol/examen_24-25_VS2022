using System.Collections.ObjectModel;
using examen_rac.Modelo;

namespace examen_rac.Vista
{
    public partial class Productos : ContentPage
    {
        public ObservableCollection<Producto> ListaProductos { get; set; }

        public Productos()
        {
            // falla al compilar???
            InitializeComponent();
            ListaProductos = new ObservableCollection<Producto>();
            BindingContext = this;
            CargarProductos();
        }

        private void CargarProductos()
        {
            // Agrego productos
            ListaProductos.Add(new Producto
            {
                Nombre = "Mesa",
                Descripcion = "Mesa de madera",
                Imagen = "mesa.jpg"
            });

            ListaProductos.Add(new Producto
            {
                Nombre = "Silla",
                Descripcion = "Silla c�moda",
                Imagen = "silla.jpg"
            });

            ListaProductos.Add(new Producto
            {
                Nombre = "L�mpara",
                Descripcion = "L�mpara moderna",
                Imagen = "lampara.jpg"
            });

            ListaProductos.Add(new Producto
            {
                Nombre = "Sof�",
                Descripcion = "Sof� de alta calidad",
                Imagen = "sofa.jpg"
            });

            ListaProductos.Add(new Producto
            {
                Nombre = "Espejo",
                Descripcion = "Espejo decorativo",
                Imagen = "espejo.jpg"
            });
        }

        private async void OnProductoSeleccionado(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                // Producto seleccionado
                var producto = (Producto)e.CurrentSelection.FirstOrDefault();

                // Cargar la p�gina de detalles del producto
                await Navigation.PushAsync(new DetalleProducto(producto));
            }
        }
    }
}