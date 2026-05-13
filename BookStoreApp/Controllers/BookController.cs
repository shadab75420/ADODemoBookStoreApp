using BookStoreApp.DAL;
using BookStoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookDAL bookDAL;

        public BookController(IConfiguration configuration)
        {
            bookDAL = new BookDAL(configuration);
        }

        public IActionResult Index()
        {
            var books = bookDAL.GetAllBooks();

            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            bookDAL.AddBook(book);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var book = bookDAL.GetBookById(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            bookDAL.UpdateBook(book);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var book = bookDAL.GetBookById(id);

            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            bookDAL.DeleteBook(id);

            return RedirectToAction("Index");
        }
    }
}