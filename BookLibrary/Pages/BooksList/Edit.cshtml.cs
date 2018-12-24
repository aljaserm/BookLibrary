using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.Pages.BooksList
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _db;
        public EditModel(AppDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Books books { get; set; }
        [TempData]
        public string msgData { get; set; }
        public void OnGet(int id)
        {
            books = _db.Books.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var selectedBook = _db.Books.Find(books.Id);
                selectedBook.BookName = books.BookName;
                selectedBook.AuthorName = books.AuthorName;
                selectedBook.ISBN = books.ISBN;

                await _db.SaveChangesAsync();
                msgData = "Book info updated correctly";
                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }
    }
}