using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RESTApi.Models
{
    public class Comment
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Text { get; set; }
        public Comment(string text) => Text = text;
    }
}