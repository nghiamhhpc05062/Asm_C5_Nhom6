using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class ResCategory : IResCategory
    {
        private readonly AppDbcontext _context;

        public ResCategory(AppDbcontext context)
        {
            _context = context;
        }

        //Add
        public Category Addcategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return category;
        }

        //Delete
        public Category Deletecategory(int id)
        {
            var existingLoai = _context.Categories.Find(id);
            if (existingLoai == null)
            {
                return null;
            }
            else
            {
                _context.Remove(existingLoai);
                _context.SaveChanges();
                return existingLoai;
            }
        }


        //Get ID
        public Category GetIDcategory(int id)
        {
            var loai = _context.Categories.Find(id);
            if (loai == null)
            {
                return null;
            }


            return (Category)loai;
        }



        //Get
        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }


        //Update
        public Category Updatecategory(int id,Category updatecategory)
        {
            var existingLoai = _context.Categories.Find(id);
            if (existingLoai == null)
            {
                return null;
            }

            existingLoai.Name = updatecategory.Name;

            _context.Update(existingLoai);
            _context.SaveChanges();
            return existingLoai;
        }


        public IEnumerable<Category> Getcategory()
        {
            return GetCategories();
        }

    }
}
