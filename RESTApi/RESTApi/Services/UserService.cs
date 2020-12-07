using RESTApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApi.Services
{
    public class UserService : IUserService
    {
        private List<User> users;
        public UserService()
        {
            users = new List<User>
            {
                new User("Yaroslav"),
                new User("Nikita"),
                new User("Zhdan"),
                new User("Vadym"),
                new User("Mykhailo"),
                new User("Alex"),
                new User("Alexander"),
                new User("Bogdan"),
                new User("Dmitry"),
                new User("Eugene"),
                new User("Ivan"),
                new User("Danilo"),
                new User("Nazar"),
                new User("Vitaly"),
                new User("Denis"),
                new User("Roman"),
                new User("Mykola"),
                new User("Yuri"),
                new User("Artem"),
                new User("Paul"),
                new User("Andrew"),
                new User("Andrew"),
            };
        }

        public User CreateUser(User user)
        {
            users.Add(user);
            return user;
        }

        public List<User> GetAllUsers(Sort sort = Sort.IdAsc)
        {
            return sort switch
            {
                Sort.IdAsc => users.OrderBy(d => d.Id).ToList(),
                Sort.IdDesc => users.OrderByDescending(d => d.Id).ToList(),
                Sort.NameAsc => users.OrderBy(d => d.Name).ToList(),
                Sort.NameDesc => users.OrderByDescending(d => d.Name).ToList(),
                _ => users
            };
        }

        public User GetUserById(string id) => users.FirstOrDefault(d => d.Id == id);

        public List<User> GetUserByName(string name) => users.Where(d => d.Name.Contains(name)).ToList();
    }
}
