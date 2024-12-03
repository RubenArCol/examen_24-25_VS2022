namespace examen_rac
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRegistroClicked(object sender, EventArgs e)
        {
            // lanzo página Registro
            Navigation.PushAsync(new Vista.Registro());
        }

        private void OnProductosClicked(object sender, EventArgs e)
        {
            // lanzo página Productos
            Navigation.PushAsync(new Vista.Productos());
        }

    }

}
