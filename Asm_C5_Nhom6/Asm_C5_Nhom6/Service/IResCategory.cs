using Asm_C5_Nhom6.Models;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Service
{
    public interface IResCategory
    {
        public IEnumerable<Category> Getcategory();
        public Category GetIDcategory(int id);

        public Category Addcategory(Category category);

        public Category Updatecategory(int id,Category category);

        public Category Deletecategory(int id);

    }
}
