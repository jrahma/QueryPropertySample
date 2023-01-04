namespace QueryPropertySample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(MyPage2), typeof(MyPage2));

    }
}

