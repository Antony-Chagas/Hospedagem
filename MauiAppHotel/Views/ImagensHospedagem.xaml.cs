namespace MauiAppHotel.Views;

public partial class ImagensHospedagem : ContentPage
{
	public ImagensHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}