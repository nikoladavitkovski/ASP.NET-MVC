using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BookApp.Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }
    }
}
