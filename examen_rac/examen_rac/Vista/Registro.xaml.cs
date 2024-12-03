namespace examen_rac.Vista;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}
private void OnRegistrarClicked(object sender, EventArgs e)
    {
        string nombre = NombreRegistro.Text;
        string correo = CorreoRegistro.Text;
        string contrasena = ContraseniaRegistro.Text;
        string confirmarContrasena = ConfirmaRegistro.Text;

        // no acepto valores vacios
        if (string.IsNullOrWhiteSpace(nombre) ||
            string.IsNullOrWhiteSpace(correo) ||
            string.IsNullOrWhiteSpace(contrasena) ||
            string.IsNullOrWhiteSpace(confirmarContrasena))
        {
            DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
            return;
        }

        // si no tiene @ o . considero que no es un correo
        if (!correo.Contains("@") || !correo.Contains("."))
        {
            DisplayAlert("Error", "Correo electr�nico no v�lido", "OK");
            return;
        }

        // m�nimo de 8 caracteres
        if (contrasena.Length < 8)
        {
            DisplayAlert("Error", "La contrase�a debe tener al menos 8 caracteres", "OK");
            return;
        }

        // tiene que ser igual a la contrase�a
        if (contrasena != confirmarContrasena)
        {
            DisplayAlert("Error", "Las contrase�as no coinciden", "OK");
            return;
        }

        DisplayAlert("�xito", "Registro exitoso", "OK");
    }

    //limpio los campos (btnLimpiar)
    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        NombreRegistro.Text = string.Empty;
        CorreoRegistro.Text = string.Empty;
        ContraseniaRegistro.Text = string.Empty;
        ConfirmaRegistro.Text = string.Empty;
    }
}