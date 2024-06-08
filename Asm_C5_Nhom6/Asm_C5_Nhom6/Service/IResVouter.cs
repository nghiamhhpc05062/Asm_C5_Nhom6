using Asm_C5_Nhom6.Models;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Service
{
    public interface IResVouter
    {
        public IEnumerable<Vouter> GetVouter();
        public Vouter GetIDVouter(int id);

        public Vouter AddVouter(Vouter vouter);

        public Vouter UpdateVouter(int id, Vouter vouter);

        public Vouter DeleteVouter(int id);

    }
}
