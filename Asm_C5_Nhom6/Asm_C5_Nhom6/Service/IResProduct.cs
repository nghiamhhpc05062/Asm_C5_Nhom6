using Asm_C5_Nhom6.Models;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Service
{
    public interface IResProduct
    {
        //Product
        public IEnumerable<Product> Getproduct();
        public Product GetIDproduct(int id);

        public Product Addproduct(Product product);

        public Product Updateproduct(int id,Product product);

        public Product Deleteproduct(int id);


    }
}
