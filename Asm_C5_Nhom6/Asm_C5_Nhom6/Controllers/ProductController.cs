using Asm_C5_Nhom6.Models;
using Asm_C5_Nhom6.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IResProduct _productResponsitory;

        public ProductController(IResProduct _product)
        {
            _productResponsitory = _product;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _productResponsitory.Getproduct();
        }

        [HttpPost]
        public Product Add(Product product)
        {
            return _productResponsitory.Addproduct(new Product
            {
                MenuId = product.MenuId,
                Name = product.Name,
                Description = product.Description,
                Image = product.Image,
                Price = product.Price,
                IsDelete = product.IsDelete,

            });
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetId(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be...");

            }
            return Ok(_productResponsitory.GetIDproduct(id));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deletedCategory = _productResponsitory.Deleteproduct(id);
            if (deletedCategory == null)
            {
                return NotFound("Category not found");
            }

            return Ok(deletedCategory);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product updatedProduct)
        {
            var updatedLoai = _productResponsitory.Updateproduct(id, updatedProduct);
            if (updatedLoai == null)
            {
                return NotFound("Category not found");
            }

            return Ok(updatedLoai);
        }
    }
}
