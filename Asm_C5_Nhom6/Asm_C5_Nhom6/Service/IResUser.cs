using Asm_C5_Nhom6.Models;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Service
{
    public interface IResUser
    {
        public IEnumerable<User> GetUser();
        public User GetIDUser(int id);

        public User AddUser(User user);

        public User UpdateUser(int id, User user);

        public User DeleteUser(int id);

    }
}
