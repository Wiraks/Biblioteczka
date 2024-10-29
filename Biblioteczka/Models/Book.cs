using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteczka.Models
{
    public class Book
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Author { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string PublishingHouse { get; set; }
        [Range(1900, 2025)]
        public int ReleaseDate { get; set; }
        [Range(0, 3000)]
        public int NumberOfPages { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string BookBinding { get; set; }
        [StringLength(13, MinimumLength = 10)]
        public string ISBN { get; set; }
        public int OwnerID { get; set; }
    }

    public class BookDBContext : DbContext
    {
        public BookDBContext()
        { }
        public DbSet<Book> Books { get; set; }
    }
}