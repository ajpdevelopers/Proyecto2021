﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(int Ci, string pass)
        {
            return userDao.Login(Ci, pass);
        }
    }
}


    
