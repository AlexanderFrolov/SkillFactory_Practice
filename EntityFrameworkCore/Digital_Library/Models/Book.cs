using System;
using System.Collections.Generic;


namespace Digital_Library.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateRelease { get; set; }
        public ushort PageCounts { get; set; }

        public List<User> Users { get; set; } = new List<User>();

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
