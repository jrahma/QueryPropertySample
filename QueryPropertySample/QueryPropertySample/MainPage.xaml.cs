namespace QueryPropertySample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void GoTapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Label lbl = (Label)sender;

        Shell.Current.GoToAsync($"{nameof(MyPage2)}?PackageID={lbl.Text}");
    }
}


