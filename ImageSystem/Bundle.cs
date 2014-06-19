using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageSystem
{
    public class Bundle
    {
        public Bundle(Account account, LoginFrm loginFrm)
        {
            this.account = account;
            this.loginFrm = loginFrm;
        }

        public Account _Account
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
            }
        }

        public LoginFrm LoginFrm
        {
            get
            {
                return loginFrm;
            }
            set
            {
                loginFrm = value;
            }
        }

        private Account account;
        private LoginFrm loginFrm;
    }
}
