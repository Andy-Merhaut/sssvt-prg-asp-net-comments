using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommentsSection.Models.Comments
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public int Parent { get; set; }
    }
}
