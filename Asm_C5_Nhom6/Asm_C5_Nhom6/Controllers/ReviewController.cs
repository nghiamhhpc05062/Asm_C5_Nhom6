using Asm_C5_Nhom6.Models;
using Asm_C5_Nhom6.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IResReview _reviewResponsitory;
        public ReviewController(IResReview review)
        {
            _reviewResponsitory = review;
        }

        [HttpGet]
        public IEnumerable<Review> GetAll()
        {
            return _reviewResponsitory.GetReview();
        }

        [HttpPost]
        public Review Add(Review review)
        {
            return _reviewResponsitory.AddReview(new Review
            {
                ProductId = review.ProductId,
                UserId = review.UserId,
                Rating = review.Rating,
                ReviewDate = review.ReviewDate,


            });
        }

        [HttpGet("{id}")]
        public ActionResult<Review> GetId(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be...");

            }
            return Ok(_reviewResponsitory.GetIDReview(id));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _reviewResponsitory.DeleteReview(id);
            if (deleted == null)
            {
                return NotFound("Review not found");
            }

            return Ok(deleted);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Review updatedReview)
        {
            var updated = _reviewResponsitory.UpdateReview(id, updatedReview);
            if (updated == null)
            {
                return NotFound("Review not found");
            }

            return Ok(updated);
        }
    }
}
