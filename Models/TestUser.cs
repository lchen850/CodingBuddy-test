// A practice class (POCO - Plain old CLR object) that makes a fake test user to test routing etc. with
// Just has a few properties (no methods) representing state

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingBuddy.Models
{
    public class TestUser
    {
        // Properties - store state of the application
        public int Id { get; set; }
        public string Name { get; set; }
    }
}