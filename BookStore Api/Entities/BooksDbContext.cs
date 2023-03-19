using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Api.Entities
{
    public class BooksDbContext:DbContext
    {  
        public BooksDbContext() : base(){

        }


        public BooksDbContext (DbContextOptions<BooksDbContext>options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=OCTOTHORPE;Database=BooksDb;Trusted_Connection=True;Encrypt=False;");

        public DbSet<Books> Books { get; set; }
    }
}
