using Menu.Data;
using Menu.ViewModel;


namespace Menu.Views;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
		var viewModel = new MenuViewModel();

		BindingContext = viewModel;
		//var DishData = new DishData();
		//DishList.ItemsSource = DishData.DishList();
		
	}
}