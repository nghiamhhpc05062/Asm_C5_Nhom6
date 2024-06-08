using Asm_C5_Nhom6.Models;
using Asm_C5_Nhom6.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IResMenu _menuResponsitory;
        public MenuController(IResMenu menu)
        {
            _menuResponsitory = menu;
        }

        [HttpGet]
        public IEnumerable<Menu> GetAll()
        {
            return _menuResponsitory.GetMenu();
        }

        [HttpGet("{id}")]
        public ActionResult<Menu> GetId(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be...");

            }
            return Ok(_menuResponsitory.GetIDMenu(id));
        }

        [HttpPost]
        public Menu Add(Menu menu)
        {
            return _menuResponsitory.AddMenu(new Menu
            {
                Restaurant = menu.Restaurant,
                Name = menu.Name,
                Description = menu.Description,
                IsDelete = menu.IsDelete,

            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deletedMenu = _menuResponsitory.DeleteMenu(id);
            if (deletedMenu == null)
            {
                return NotFound("Menu not found");
            }

            return Ok(deletedMenu);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Menu updatedMenu)
        {
            var updated = _menuResponsitory.UpdateMenu(id, updatedMenu);
            if (updated == null)
            {
                return NotFound("Menu not found");
            }

            return Ok(updated);
        }
    }
}
