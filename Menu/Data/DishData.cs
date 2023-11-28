using Menu.Model;
using Microsoft.Maui.Controls;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Data
{
    public class DishData
    {   
        public List<Dish> DishList()
        {
            return
            [
                new () {
                    DishName = "Arepa",
                    Details = "Corn Flour at grill filled with delicious protein of your choice",
                    Price = 2.00m,
                    Image = "arepa.jpg"
                },

                new()
                {
                    DishName = "Lasagna",
                    Details = "Italian dish made of stacked layers of lasagna alternating with fillings",
                    Price = 4.00m,
                    Image = "lasagna.jpg"
                },

                new()
                {
                    DishName = "Pizza",
                    Details = "Leavened wheat - based dough topped with tomatoes, cheese and your desire ingredients",
                    Price = 7.00m,
                    Image = "pizza.jpg"
                }

            ];
        }

    }
}
