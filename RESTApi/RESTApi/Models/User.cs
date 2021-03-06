﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RESTApi.Models
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public List<Comment> Comments { get; set; }

        public User(string name, List<Comment> comments)
        {
            Name = name;
            Comments = comments;
        }
    }
}