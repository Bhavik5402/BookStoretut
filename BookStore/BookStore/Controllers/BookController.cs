using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {

        private readonly BookRepository _bookRepository = null; 


        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult GetAllBooks()
        {
            var x = _bookRepository.GetAllBooks();
            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookByID(id);
        }

       public List<BookModel> SearchBooks(string bookName , string author)
        {
            return _bookRepository.SearchBook(bookName , author);
        }
    }
}
