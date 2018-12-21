using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.Pages.BooksList
{
    public class IndexModel : PageModel
    {
        public string Data { get; set; }
        public void OnGet()
        {
            Data = "New Data";
        }
    }
}