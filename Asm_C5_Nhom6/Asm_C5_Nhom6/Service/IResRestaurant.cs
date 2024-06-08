using Asm_C5_Nhom6.Models;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Service
{
    public interface IResRestaurant
    {
        public IEnumerable<Restaurant> GetRestaurant();
        public Restaurant GetIDRestaurant(int id);

        public Restaurant AddRestaurant(Restaurant restaurant);

        public Restaurant UpdateRestaurant(int id, Restaurant restaurant);

        public Restaurant DeleteRestaurant(int id);

    }
}
