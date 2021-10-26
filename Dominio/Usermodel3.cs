using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Usermodel3
    {
        UserDadmin userDadmin = new UserDadmin();
        public bool LoginUser(int Ci, string pass)
        {
            return userDadmin.Login(Ci, pass);
        }
    }
}

