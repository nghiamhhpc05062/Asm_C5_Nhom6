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
        private readonly IResponsitory _productResponsitory;
        public ProductController(IResponsitory _product)
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
    }
}
