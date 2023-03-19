using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Api.Entities
{
    public class Books
    {
      [Key]
      public  int BookId { get; set; }

      public string BookName { get; set; }
      public  int BookPrice { get; set; }
      public string BookGenre { get; set; }
    }
}
