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
        public string BookName { get; set; }
    }
}
