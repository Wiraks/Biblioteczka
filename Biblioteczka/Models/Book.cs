using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteczka.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public int ReleaseDate { get; set; }
        public int NumberOfPages { get; set; }
        public string BookBinding { get; set; }
        public string ISBN { get; set; }
        public int OwnerID { get; set; }
    }
}