using BookStore_Api.Entities;
namespace BooksBL
{
    public class Class1
    {
        BooksDbContext context=new BooksDbContext();
        public Books AddBooks(Books book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return book;

        }

        public List<Books> GetAllBooks() {
         
           return context.Books.ToList();
        }

        public Books GetBookById(int id)
        { 
            return context.Books.FirstOrDefault(x=>x.BookId==id);
        }

        public Books updateBooks (Books book)
        {
            context.Books.Update(book);
            context.SaveChanges();
            return book;

        }

        public void DeleteBookById(int id)
        {
            var book = context.Books.FirstOrDefault(x=>x.BookId== id);
            context.Books.Remove(book);
            context.SaveChanges();
        }

    }
}