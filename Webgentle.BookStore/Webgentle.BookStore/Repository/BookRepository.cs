using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Author.Contains(authorName) && x.Title.Contains(title)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title="MVC", Author = "Nitish", Description="This section will be used to display sumary MVC book"},
                new BookModel(){Id = 2, Title="Lavarel", Author = "Nitish", Description="This section will be used to display sumary Lavarel book"},
                new BookModel(){Id = 3, Title="C#", Author = "Monika", Description="This section will be used to display sumary C# book"},
                new BookModel(){Id = 4, Title="Java", Author = "Webgentle", Description="This section will be used to display sumary Java book"},
                new BookModel(){Id = 5, Title="Php", Author = "Webgentle", Description="This section will be used to display sumary Php book"},
            };
        }  
    }
}
