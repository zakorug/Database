using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class User
    {
        private int id { get; set; }

        private string email, name, surname, middlename;

        private int phoneNumber, dateOfbirth;

        public User() { }

        public User(string email, string surname, string name, string middlename)
        {
            this.email = email;
            this.surname = surname;
            this.name = name;
            this.middlename = middlename;
        }

    }
}
