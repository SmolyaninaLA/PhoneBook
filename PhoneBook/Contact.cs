using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class Contact
    {
        public Contact(string name, string lastName, long phoneNumber, String email)  
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}
