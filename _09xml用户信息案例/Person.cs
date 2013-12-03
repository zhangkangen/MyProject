using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09xml用户信息案例
{
    public class Person
    {
        string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
