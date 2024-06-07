using Asm_C5_Nhom6.Models;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Service
{
    public interface IResponsitory
    {
        public IEnumerable<Category> GetCategory();
        public Category GetIDcategory(int id);

        Category Addcategory(Category category);

        public Category Updatecategory(int id,Category category);

        public Category Deletecategory(int id);


        //Product
        public IEnumerable<Product> Getproduct();
        public Product GetIDproduct(int id);

        public Product Addproduct(Product product);

        public Product Updateproduct(Product product);

        public Product Deleteproduct(int id);


    }
}
