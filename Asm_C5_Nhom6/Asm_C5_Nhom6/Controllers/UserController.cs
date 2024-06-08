using Asm_C5_Nhom6.Models;
using Asm_C5_Nhom6.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IResUser _userResponsitory;

        public UserController(IResUser user)
        {
            _userResponsitory = user;
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _userResponsitory.GetUser();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetId(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be...");

            }
            return Ok(_userResponsitory.GetIDUser(id));
        }

        [HttpPost]
        public User Add(User user)
        {
            return _userResponsitory.AddUser(new User
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Phone = user.Phone,
                Address = user.Address,
                role = user.role,
                IsDelete = user.IsDelete,

            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _userResponsitory.DeleteUser(id);
            if (deleted == null)
            {
                return NotFound("Order not found");
            }

            return Ok(deleted);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] User updateuser)
        {
            var updated = _userResponsitory.UpdateUser(id, updateuser);
            if (updated == null)
            {
                return NotFound("Order not found");
            }

            return Ok(updated);
        }
    }
}
