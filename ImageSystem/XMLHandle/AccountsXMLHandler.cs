using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;
using ImageSystem.CommonStaticVar;

namespace ImageSystem.XMLHandle
{
    class AccountsXMLHandler
    {
        private XmlDocument accounts = null;
        private XmlElement curAccount = null;
        private XmlElement curElem = null;
        private XmlElement root = null;
        
        public AccountsXMLHandler() {
            accounts = new XmlDocument();
            accounts.Load(CommonStaticVariables.accountsFilePath);
            root = accounts.DocumentElement;
        }

        public void reload()
        {
            accounts = new XmlDocument();
            accounts.Load(CommonStaticVariables.accountsFilePath);
            root = accounts.DocumentElement;
        }

        public List<string> getAllAccount()
        {
            XmlNodeList allAccounts = root.ChildNodes;
            List<string> allAccountList = new List<string>();
            foreach (XmlElement name in allAccounts)
            {
                if (!allAccountList.Contains(name.GetElementsByTagName("name").Item(0).InnerText))
                {
                    allAccountList.Add(name.GetElementsByTagName("name").Item(0).InnerText);
                }
            }
            return allAccountList;
        }

        public void update(Account newAccount)
        {
            string searchString = "/accounts/user[name='" + newAccount.Name + "']";
            curAccount = (XmlElement)root.SelectSingleNode( searchString );

            curAccount.GetElementsByTagName("name").Item(0).InnerText = newAccount.Name;
            curAccount.GetElementsByTagName("password").Item(0).InnerText = newAccount.Password;
            curAccount.GetElementsByTagName("authority").Item(0).InnerText = newAccount.Authority.ToString();

            save();
        }

        public bool exits(string name)
        {
            string searchString = "/accounts/user[name='" + name + "']";
            curAccount = (XmlElement)root.SelectSingleNode( searchString );

            if (curAccount == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Account search(string name, string password)
        {
            string searchString = "/accounts/user[name='" + name + "' and password='" + password + "']";
            curAccount = (XmlElement)root.SelectSingleNode(searchString);
            if (curAccount == null)
            {
                return null;
            }

            Account retAccount = new Account();
            retAccount.Name = curAccount.GetElementsByTagName("name").Item(0).InnerText;
            retAccount.Password = curAccount.GetElementsByTagName("password").Item(0).InnerText;
            retAccount.Authority = curAccount.GetElementsByTagName("authority").Item(0).InnerText;

            return retAccount;
        }

        public void remove(string name)
        {
            string searchString = "/accounts/user[name='" + name + "']";
            curAccount = (XmlElement)root.SelectSingleNode(searchString);
            curAccount.ParentNode.RemoveChild(curAccount);

            save();
        }

        public void add( Account newAccount )
        {
            curAccount = accounts.CreateElement("user");

            curElem = accounts.CreateElement("name");
            curElem.InnerText = newAccount.Name;
            curAccount.AppendChild(curElem);

            curElem = accounts.CreateElement("password");
            curElem.InnerText = newAccount.Password;
            curAccount.AppendChild(curElem);

            curElem = accounts.CreateElement("authority");
            curElem.InnerText = newAccount.Authority.ToString();
            curAccount.AppendChild(curElem);

            root.AppendChild(curAccount);

            save();
        }

        private void save()
        {
            accounts.Save(CommonStaticVariables.accountsFilePath);
        }
    }
}
