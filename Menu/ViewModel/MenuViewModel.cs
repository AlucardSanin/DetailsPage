using Menu.Data;
using Menu.Model;
using System.Collections.ObjectModel;

namespace Menu.ViewModel
{
    public class MenuViewModel
    {
        public MenuViewModel()
        {            
            var dishData = new DishData();
            DishList = new ObservableCollection<Dish>();

            foreach(Dish dish in dishData.DishList())
            {
                DishList.Add(dish);
            }
            //DishList.ItemsSource = DishData.DishList();
            DishSelectionCommand = new Command (DishSelection);
        }

        public ObservableCollection<Dish> DishList { get; set; }

        public Command DishSelectionCommand { get; }

        public void DishSelection()
        {
            Console.WriteLine("prueba");
        }
    }
}
