using System.Net.Http;
using System.Text.Json;

namespace QueryPropertySample;

public partial class MyPage2 : ContentPage
{
    public MyPage2(QueryParam vm)
	{
		InitializeComponent();

        BindingContext = vm;

        ShowMessage();

    }

    public async void ShowMessage()
    {
        await DisplayAlert("Query", (BindingContext as QueryParam).PackageId, "Ok");
    }
}
