

namespace AppEdu.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void btnDocentes_ClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DocentePage());
    }

    private async void btnGrupos_ClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Docente_GrupoPage());
    }

    private async void btnAsignaturasAsync_ClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DocenteMateriaPage());
    }

    private async void btnDirector_ClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DirectorPage());
    }

    private async void btnNotas_ClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotasPage());
    }

    private async void btnCalendario_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CalendarioPage());
    }

    private async void btnLogOut_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}