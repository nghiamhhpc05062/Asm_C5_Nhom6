using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class ResReview : IResReview
    {
        private readonly AppDbcontext _context;

        public ResReview(AppDbcontext context)
        {
            _context = context;
        }


        public IEnumerable<Review> GetReview()
        {
            return _context.Reviews.ToList();
        }

        public Review GetIDReview(int id)
        {
            var review = _context.Reviews.Find(id);
            if (review == null)
            {
                return null;
            }


            return (Review)review;
        }

        public Review AddReview(Review review)
        {
            _context.Add(review);
            _context.SaveChanges();
            return review;
        }

        public Review UpdateReview(int id, Review reviewupdate)
        {
            var existingreview = _context.Reviews.Find(id);
            if (existingreview == null)
            {
                return null;
            }
            existingreview.ProductId = reviewupdate.ProductId;
            existingreview.UserId   = reviewupdate.UserId;
            existingreview.Rating = reviewupdate.Rating;
            existingreview.ReviewDate = reviewupdate.ReviewDate;

            _context.Update(existingreview);
            _context.SaveChanges();
            return existingreview;
        }

        public Review DeleteReview(int id)
        {
            var existingReview = _context.Reviews.Find(id);
            if (existingReview == null)
            {
                return null;
            }
            else
            {
                _context.Remove(existingReview);
                _context.SaveChanges();
                return existingReview;
            }
        }

        public IEnumerable<Review> GetReviews()
        {
            return GetReviews();
        }
    }
}
