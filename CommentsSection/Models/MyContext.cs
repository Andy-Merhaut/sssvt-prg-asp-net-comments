using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommentsSection.Models.Comments;
using Microsoft.EntityFrameworkCore;

namespace CommentsSection.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=Comments;user=root;password=");
        }

    }
}
