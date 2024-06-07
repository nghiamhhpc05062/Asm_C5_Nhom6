using System.Collections.Generic;

namespace Asm_C5_Nhom6.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }

        public Restaurant Restaurant { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
