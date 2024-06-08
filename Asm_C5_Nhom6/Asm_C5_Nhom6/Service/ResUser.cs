using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class ResUser : IResUser
    {
        private readonly AppDbcontext _context;

        public ResUser(AppDbcontext context)
        {
            _context = context;
        }

        public User AddUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User DeleteUser(int id)
        {
            var existingUser = _context.Users.Find(id);
            if (existingUser == null)
            {
                return null;
            }
            else
            {
                _context.Remove(existingUser);
                _context.SaveChanges();
                return existingUser;
            }
        }

        public User GetIDUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return null;
            }


            return (User)user;
        }

        public User UpdateUser(int id, User userupdate)
        {
            var existinguser = _context.Users.Find(id);
            if (existinguser == null)
            {
                return null;
            }
            existinguser.Name = userupdate.Name;
            existinguser.Email = userupdate.Email;
            existinguser.Password = userupdate.Password;
            existinguser.Phone = userupdate.Phone;
            existinguser.Address = userupdate.Address;
            existinguser.IsDelete = userupdate.IsDelete;

            _context.Update(existinguser);
            _context.SaveChanges();
            return existinguser;
        }
        public IEnumerable<User> GetUsers()
        {
            return GetUsers();
        }

        public IEnumerable<User> GetUser()
        {
            return _context.Users.ToList();
        }
    }
}
