namespace PM02P012024.Views;

public partial class PageListPersonas : ContentPage
{
	public PageListPersonas()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {

    }

    private void listperson_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listperson.ItemsSource = await App.Database.GetListPersons();
    }
}