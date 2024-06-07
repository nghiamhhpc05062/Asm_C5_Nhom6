using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class Responsitory : IResponsitory
    {
        private readonly AppDbcontext _context;

        public Responsitory(AppDbcontext context)
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

        public Product Addproduct(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return product;
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

        public Product Deleteproduct(int id)
        {
            throw new System.NotImplementedException();
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

        public Product GetIDproduct(int id)
        {
            throw new System.NotImplementedException();
        }


        //Get
        public IEnumerable<Category> GetCategory()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<Product> Getproduct()
        {
            return _context.Products.ToList();
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

        public Product Updateproduct(Product product)
        {
            throw new System.NotImplementedException();
        }

    }
}
