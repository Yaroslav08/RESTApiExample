using RESTApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RESTApi.Services
{
    public interface IUserService
    {
        User GetUserById(string id);
        List<User> GetAllUsers();
        List<User> GetUserByName(string name);
        User CreateUser(User user);
    }
}