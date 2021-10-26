using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class UserModel2
    {
        UserDoc userDoc = new UserDoc();
        public bool LoginUser(int Ci, string pass)
        {
            return userDoc.Login(Ci, pass);
        }
}
}
