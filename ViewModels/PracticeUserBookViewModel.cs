using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using CodingBuddy.Models;

namespace CodingBuddy.ViewModels
{
    public class PracticeUserBookViewModel
    {
        public TestUser TestUser { get; set; }
        public List<Book> Books { get; set; }

    }
}