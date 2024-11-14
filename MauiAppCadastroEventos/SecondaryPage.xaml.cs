namespace MauiAppCadastroEventos;

public partial class SecondaryPage : ContentPage
{
	public SecondaryPage()
	{
		InitializeComponent();
	}

    private void bnt_voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}