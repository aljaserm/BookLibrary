using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Pages.BooksList
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;
        public IEnumerable<Books> books { get; set; }
        [TempData]
        public string msgData { get; set; }
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            books = await _db.Books.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book =await _db.Books.FindAsync(id);
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            msgData = "Book Deleted successfully";
            return RedirectToPage("Index");
        }
    }
}