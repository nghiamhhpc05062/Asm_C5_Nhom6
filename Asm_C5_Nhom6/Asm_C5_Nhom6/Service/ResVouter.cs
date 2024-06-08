using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class ResVouter : IResVouter
    {
        private readonly AppDbcontext _context;

        public ResVouter(AppDbcontext context)
        {
            _context = context;
        }

        public Vouter AddVouter(Vouter vouter)
        {
            _context.Add(vouter);
            _context.SaveChanges();
            return vouter;
        }

        public Vouter DeleteVouter(int id)
        {
            var existingVouter = _context.Vouters.Find(id);
            if (existingVouter == null)
            {
                return null;
            }
            else
            {
                _context.Remove(existingVouter);
                _context.SaveChanges();
                return existingVouter;
            }
        }

        public Vouter GetIDVouter(int id)
        {
            var vouter = _context.Vouters.Find(id);
            if (vouter == null)
            {
                return null;
            }


            return (Vouter)vouter;
        }

        public IEnumerable<Vouter> GetVouter()
        {
            return _context.Vouters.ToList();
        }

        public Vouter UpdateVouter(int id, Vouter vouterupdate)
        {
            var existingvouter = _context.Vouters.Find(id);
            if (existingvouter == null)
            {
                return null;
            }
            existingvouter.ProductId = vouterupdate.ProductId;
            existingvouter.Code = vouterupdate.Code;
            existingvouter.Discount = vouterupdate.Discount;
            existingvouter.ExpirationDate = vouterupdate.ExpirationDate;

            _context.Update(existingvouter);
            _context.SaveChanges();
            return existingvouter;
        }

        public IEnumerable<Vouter> GetVouters()
        {
            return GetVouters();
        }

    }
}
