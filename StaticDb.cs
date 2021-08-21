using SEDC.BookApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BookApp.DataAccess
{
    public class StaticDb
    {
        public List<User> users = new List<User>()
        {
            new User
            {
                Id = 1,
                FirstName = "Gorgi",
                LastName = "Damchevski",
                UserName = "gorgi.damchevski",
                Address = "Skopje",
                Phone = 072394675
            }
        };
        public List<Book> books = new List<Book>()
        {
            new Book
            {
                Id = 1,
                Title = "The Fundamentals Of Physics",
                Author = "Stephen Hawking"
            }
        };
    }
}
