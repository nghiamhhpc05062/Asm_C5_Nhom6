using Asm_C5_Nhom6.Models;
using Asm_C5_Nhom6.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IResCategory _loaiResponsitory;
        public CategoryController(IResCategory loai)
        {
            _loaiResponsitory = loai;
        }

        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            return _loaiResponsitory.Getcategory();
        }

        [HttpGet("{id}")]
        public ActionResult<Category> GetId(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be...");

            }
            return Ok(_loaiResponsitory.GetIDcategory(id));
        }

        [HttpPost]
        public Category Add(Category category)
        {
            return _loaiResponsitory.Addcategory(new Category
            {
                Name = category.Name,

            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deletedCategory = _loaiResponsitory.Deletecategory(id);
            if (deletedCategory == null)
            {
                return NotFound("Category not found");
            }

            return Ok(deletedCategory);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Category updatedCategory)
        {
            var updatedLoai = _loaiResponsitory.Updatecategory(id, updatedCategory);
            if (updatedLoai == null)
            {
                return NotFound("Category not found");
            }

            return Ok(updatedLoai);
        }
    }
}
