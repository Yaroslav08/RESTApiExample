using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RESTApi.Models
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public DateTime CreayedAt { get; set; } = DateTime.Now;
        public string Name { get; set; }

        public User(string name) => Name = name;
    }
}