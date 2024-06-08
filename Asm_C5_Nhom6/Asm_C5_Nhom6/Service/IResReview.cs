using Asm_C5_Nhom6.Models;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Service
{
    public interface IResReview
    {
        public IEnumerable<Review> GetReview();
        public Review GetIDReview(int id);

        public Review AddReview(Review review);

        public Review UpdateReview(int id, Review review);

        public Review DeleteReview(int id);

    }
}
