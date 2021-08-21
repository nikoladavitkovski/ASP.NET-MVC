using Microsoft.AspNetCore.Mvc;
using SEDC.BookApp.Domain.Models;
using SEDC.BookApp.Models;
using SEDC.BookApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.BookApp.Controllers
{
    public class BookController : Controller
    {
        private BookService _bookService;

        public BookController()
        {
            _bookService = new BookService();
        }
        public IActionResult Index()
        {
            List<User> allUsers = _bookService.GetBookById(id);

            List<BookViewModel> viewModel = new List<BookViewModel>();

            foreach(User user in allUsers)
            {
                BookViewModel bookViewModel = new BookViewModel
                {
                    Id = bookViewModel.Id,
                    Title = bookViewModel.Title,
                    Author = bookViewModel.Author
                };
                viewModel.Add(bookViewModel);
            }
            return View(viewModel);
        }
        public IActionResult Details(int id)
        {
            Book book = _bookService.GetBookById(id);

            BookViewModel bookView = new BookViewModel
            {
                Id = bookView.Id,
                Title = bookView.Title,
                Author = bookView.Author
            };
            return View(bookView);
        }
    }
}
