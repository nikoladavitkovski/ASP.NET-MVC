using SEDC.BookApp.DataAccess;
using SEDC.BookApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.BookApp.Services
{
    public class BookService
    {
        public Book GetBookById(int id)
        {
            StaticDb database = new StaticDb();
            Book book = database.books.SingleOrDefault(x => x.Id.Equals(id));
            return book;
        }
    }
}
