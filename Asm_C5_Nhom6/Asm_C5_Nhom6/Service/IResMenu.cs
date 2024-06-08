using Asm_C5_Nhom6.Models;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Service
{
    public interface IResMenu
    {
        //Product
        public IEnumerable<Menu> GetMenu();
        public Menu GetIDMenu(int id);

        public Menu AddMenu(Menu menu);

        public Menu UpdateMenu(int id, Menu menu);

        public Menu DeleteMenu(int id);


    }
}
