using Asm_C5_Nhom6.Models;
using Asm_C5_Nhom6.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VouterController : ControllerBase
    {
        private readonly IResVouter _voterResponsitory;
        public VouterController(IResVouter voter)
        {
            _voterResponsitory = voter;
        }

        [HttpGet]
        public IEnumerable<Vouter> GetAll()
        {
            return _voterResponsitory.GetVouter();
        }

        [HttpGet("{id}")]
        public ActionResult<Vouter> GetId(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be...");

            }
            return Ok(_voterResponsitory.GetIDVouter(id));
        }

        [HttpPost]
        public Vouter Add(Vouter vouter)
        {
            return _voterResponsitory.AddVouter(new Vouter
            {
                ProductId = vouter.ProductId,
                Code = vouter.Code,
                Discount = vouter.Discount,
                ExpirationDate = vouter.ExpirationDate,

            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deletedCategory = _voterResponsitory.DeleteVouter(id);
            if (deletedCategory == null)
            {
                return NotFound("Vouter not found");
            }

            return Ok(deletedCategory);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Vouter updatedVouter)
        {
            var updated = _voterResponsitory.UpdateVouter(id, updatedVouter);
            if (updated == null)
            {
                return NotFound("Vouter not found");
            }

            return Ok(updated);
        }
    }
}
