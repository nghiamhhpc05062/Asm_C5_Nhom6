using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class ResRestaurant : IResRestaurant
    {
        private readonly AppDbcontext _context;

        public ResRestaurant(AppDbcontext context)
        {
            _context = context;
        }

      
    }
}
