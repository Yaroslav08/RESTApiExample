using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RESTApiLibrary.Models
{
    public class User
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Date: {CreatedAt}, Name: {Name}";
        }
    }
}