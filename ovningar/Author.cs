using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovningar
{
    class Author
    {
        private string name;
        private string email;
        private char gender;

        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public string getName()
        {
            return name;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public char getGender()
        {
            return gender;
        }

        public override string ToString()
        {
            return "Name: " + name + ", Email: " + email + ", Gender: " + gender;
        }
    }



}
