using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Model
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }
        public string ISBN { get; set; }
    }
}
