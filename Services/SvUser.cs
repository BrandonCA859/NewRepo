using DataAccess;
using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvUser : ISvUser
    {

        private readonly MyDbContext _myDbContext;

        
        public SvUser(MyDbContext myDbContext) 

        {
            _myDbContext = myDbContext;
        }

        public User Add(User user)
        {
            _myDbContext.Users.Add(user);
            _myDbContext.SaveChanges();

            return user;
        }


        public List<User> ListUsers()
        {
            return _myDbContext.Users.ToList();
        }

        public void Update(User user)
        {

            Console.WriteLine("Update");
        }


        public void Delete(int id)
        {
            User userFound = _myDbContext.Users.Where(user => user.Id == id).FirstOrDefault();

            _myDbContext.Users.Remove(userFound);
            _myDbContext.SaveChanges();
        }

    }
}
