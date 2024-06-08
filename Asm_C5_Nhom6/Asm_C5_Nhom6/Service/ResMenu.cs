using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class ResMenu : IResMenu
    {
        private readonly AppDbcontext _context;

        public ResMenu(AppDbcontext context)
        {
            _context = context;
        }

        //Add
        public Menu AddMenu(Menu menu)
        {
            _context.Add(menu);
            _context.SaveChanges();
            return menu;
        }

        //Delete
        public Menu DeleteMenu(int id)
        {
            var existingMenu = _context.Menus.Find(id);
            if (existingMenu == null)
            {
                return null;
            }
            else
            {
                _context.Remove(existingMenu);
                _context.SaveChanges();
                return existingMenu;
            }
        }


        //Get ID
        public Menu GetIDMenu(int id)
        {
            var menu = _context.Menus.Find(id);
            if (menu == null)
            {
                return null;
            }


            return (Menu)menu;
        }


        //Get
        public IEnumerable<Menu> GetMenu()
        {
            return _context.Menus.ToList();
        }


        //Update
        public Menu UpdateMenu(int id, Menu updatepmenu)
        {
            var existingmenu = _context.Menus.Find(id);
            if (existingmenu == null)
            {
                return null;
            }
            existingmenu.Name = updatepmenu.Name;


            _context.Update(existingmenu);
            _context.SaveChanges();
            return existingmenu;
        }

        
        public IEnumerable<Menu> GetMenus()
        {
            return GetMenus();
        }


    }
}
