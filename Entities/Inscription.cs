using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUCA.Entities
{
    public class Inscription
    {
        public Inscription(string FullName, string Email, string PhoneNumber)
        {
            this.FullName = FullName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Course Course { get; set; }
    }
}
