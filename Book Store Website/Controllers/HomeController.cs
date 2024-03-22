using Book_Store_Website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Book_Store_Website.Interfaces;

namespace Book_Store_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;
            var books = _bookRepository.GetBooks(pageNum, pageSize);
            ViewBag.TotalPages = (int)Math.Ceiling((double)_bookRepository.GetTotalBooks() / pageSize);
            ViewBag.CurrentPage = pageNum;
            return View(books);
        }
    }
}
