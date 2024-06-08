using Asm_C5_Nhom6.Models;
using Asm_C5_Nhom6.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IResRestaurant _restaurantResponsitory;
        public RestaurantController(IResRestaurant restaurant)
        {
            _restaurantResponsitory = restaurant;
        }

        [HttpGet]
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurantResponsitory.GetRestaurant();
        }

        [HttpPost]
        public Restaurant Add(Restaurant restaurant)
        {
            return _restaurantResponsitory.AddRestaurant(new Restaurant
            {
                CategoryId = restaurant.CategoryId,
                Name = restaurant.Name,
                Image = restaurant.Image,
                Address = restaurant.Address,
                OpeningHours = restaurant.OpeningHours,
                IsDelete = restaurant.IsDelete,

            });
        }

        [HttpGet("{id}")]
        public ActionResult<Restaurant> GetId(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be...");

            }
            return Ok(_restaurantResponsitory.GetIDRestaurant(id));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _restaurantResponsitory.DeleteRestaurant(id);
            if (deleted == null)
            {
                return NotFound("Restaurant not found");
            }

            return Ok(deleted);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Restaurant updatedRestaurant)
        {
            var updated = _restaurantResponsitory.UpdateRestaurant(id, updatedRestaurant);
            if (updated == null)
            {
                return NotFound("Restaurant not found");
            }

            return Ok(updated);
        }
    }
}
