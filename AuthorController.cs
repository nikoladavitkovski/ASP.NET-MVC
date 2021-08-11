using Microsoft.AspNetCore.Mvc;
using SEDC.Library.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Library.Web.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        public IActionResult JsonData()
        {
            Author author = new Author
            {
                Id = 1,
                Name = "Hercules Poirot",
                DateOfBirth = new DateTime(11/01/1998)
            };
            return new JsonResult(author);
        }

        public IActionResult ListOfAuthors()
        {
            Author author = new Author
            {
                Id = 1,
                Name = "Hercules Poirot",
                DateOfBirth = new DateTime(11 / 01 / 1998)
            };

            Author author1 = new Author
            {
                Id = 1,
                Name = "Hercules Poirot",
                DateOfBirth = new DateTime(11 / 01 / 1998)
            };

            Author author2 = new Author
            {
                Id = 1,
                Name = "Hercules Poirot",
                DateOfBirth = new DateTime(11 / 01 / 1998)
            };

            List<Author> authors = new List<Author>();
            authors.Add(author1);
            authors.Add(author2);
            return new JsonResult(authors);
        }


        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }

        public IActionResult BackToHome()
        {
            return RedirectToAction("Privacy", "Home");
        }

        public IActionResult Details(int id)
        {
            Book book = StaticDB.Books.SingleOrDefault(x => x.Id == id);

            if (book == null)
            {
                return RedirectToAction("Error");
            }

            PublishingHouse publishingHouse = StaticDB.PublishingHouses.SingleOrDefault(q => q.Id.Equals(book.PublishingHouseId));
            PublishingHouseDto publishingHouseDto = new PublishingHouseDto
            {
                Id = publishingHouse.Id,
                Name = publishingHouse.Name
            };

            publishingHouseDto.Name = "Ljube";
            ViewBag.PublishingHouseName = publishingHouseDto.Name;

            return View(book);
        }

        public IActionResult ViewModelDetails(int id)
        {
            Book book = StaticDB.Books.SingleOrDefault(x => x.Id == id);

            PublishingHouse publishingHouse = StaticDB.PublishingHouses.SingleOrDefault(q => q.Id.Equals(book.PublishingHouseId));

            Author author = StaticDB.Authors.SingleOrDefault(q => q.Id.Equals(book.AuthorId));

            BookDetailsViewModel bookDetailsViewModel = new BookDetailsViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = author.Name,
                PublishingHouse = publishingHouse.Name
            };

            //if(book == null)
            //{
            //    return RedirectToAction("Error", "Home");
            //}

            return View(bookDetailsViewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult ViewAuthorDetails(int id)
        {
            Author author = new Author
            {
                Id = author.Id,
                Name = author.Name,
                DateOfBirth = author.DateOfBirth
            };
            return ViewAuthorDetails(author.Id);
        }
    }
}
