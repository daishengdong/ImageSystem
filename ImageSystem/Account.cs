using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageSystem
{
    public class Account
    {
        public Account()
        {
        }

        public Account(string name, string password, string authority)
        {
            this.name = name;
            this.password = password;
            this.authority = authority;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string Authority
        {
            get
            {
                return authority;
            }
            set
            {
                authority = value;
            }
        }

        private string name;
        private string password;
        private string authority;
    }
}
