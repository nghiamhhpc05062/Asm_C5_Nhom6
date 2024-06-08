using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class ResRestaurant : IResRestaurant
    {
        private readonly AppDbcontext _context;

        public ResRestaurant(AppDbcontext context)
        {
            _context = context;
        }

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            _context.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant DeleteRestaurant(int id)
        {
            var existingRestaurant = _context.Restaurants.Find(id);
            if (existingRestaurant == null)
            {
                return null;
            }
            else
            {
                _context.Remove(existingRestaurant);
                _context.SaveChanges();
                return existingRestaurant;
            }
        }

        public Restaurant GetIDRestaurant(int id)
        {
            var restaurant = _context.Restaurants.Find(id);
            if (restaurant == null)
            {
                return null;
            }


            return (Restaurant)restaurant;
        }

        public IEnumerable<Restaurant> GetRestaurant()
        {
            return _context.Restaurants.ToList();
        }

        public Restaurant UpdateRestaurant(int id, Restaurant restaurantupdate)
        {
            var existingrestaurant = _context.Restaurants.Find(id);
            if (existingrestaurant == null)
            {
                return null;
            }
            existingrestaurant.CategoryId = restaurantupdate.CategoryId;
            existingrestaurant.Name = restaurantupdate.Name;
            existingrestaurant.Image = restaurantupdate.Image;
            existingrestaurant.Address = restaurantupdate.Address;
            existingrestaurant.OpeningHours = restaurantupdate.OpeningHours;
            existingrestaurant.IsDelete = restaurantupdate.IsDelete;


            _context.Update(existingrestaurant);
            _context.SaveChanges();
            return existingrestaurant;
        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            return GetRestaurants();
        }

    }
}
