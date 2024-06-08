using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class ResProduct : IResProduct
    {
        private readonly AppDbcontext _context;

        public ResProduct(AppDbcontext context)
        {
            _context = context;
        }

        //Add
        public Product Addproduct(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return product;
        }

        //Delete
        public Product Deleteproduct(int id)
        {
            var existingProd = _context.Products.Find(id);
            if (existingProd == null)
            {
                return null;
            }
            else
            {
                _context.Remove(existingProd);
                _context.SaveChanges();
                return existingProd;
            }
        }


        //Get ID
        public Product GetIDproduct(int id)
        {
            var prod = _context.Products.Find(id);
            if (prod == null)
            {
                return null;
            }


            return (Product)prod;
        }


        //Get
        public IEnumerable<Product> Getproduct()
        {
            return _context.Products.ToList();
        }


        //Update
        public Product Updateproduct(int id,Product updateproduct)
        {
            var existingprod = _context.Products.Find(id);
            if (existingprod == null)
            {
                return null;
            }
            existingprod.MenuId = updateproduct.MenuId;
            existingprod.Name = updateproduct.Name;
            existingprod.Description = updateproduct.Description;
            existingprod.Image = updateproduct.Image;
            existingprod.Price = updateproduct.Price;
            existingprod.IsDelete = updateproduct.IsDelete;


            _context.Update(existingprod);
            _context.SaveChanges();
            return existingprod;
        }

        
        public IEnumerable<Product> GetProducts()
        {
            return GetProducts();
        }

    }
}
