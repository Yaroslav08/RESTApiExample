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
                new User("Yaroslav", new List<Comment>
                {
                    new Comment("Good like 1"),
                    new Comment("Very cool 1"),
                    new Comment("Some body was told me the world")
                }),
                new User("Nikita", new List<Comment>
                {
                    new Comment("Good like 2"),
                    new Comment("Very cool 2")
                }),
                new User("Zhdan", new List<Comment>
                {
                    new Comment("Good like 3"),
                    new Comment("Very cool 3")
                }),
                new User("Vadym", new List<Comment>
                {
                    new Comment("Good like 4"),
                    new Comment("Very cool 4")
                }),
                new User("Mykhailo", new List<Comment>
                {
                    new Comment("Good like 5"),
                    new Comment("Very cool 5")
                }),
                new User("Alex", new List<Comment>
                {
                    new Comment("Good like 6"),
                    new Comment("Very cool 6")
                }),
                new User("Alexander", new List<Comment>
                {
                    new Comment("Good like 7"),
                    new Comment("Very cool 7")
                }),
                new User("Bogdan", new List<Comment>
                {
                    new Comment("Good like 8"),
                    new Comment("Very cool 8")
                }),
                new User("Dmitry", new List<Comment>
                {
                    new Comment("Good like 9"),
                    new Comment("Very cool 9")
                }),
                new User("Eugene", new List<Comment>
                {
                    new Comment("Good like 10"),
                    new Comment("Very cool 10")
                })
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
