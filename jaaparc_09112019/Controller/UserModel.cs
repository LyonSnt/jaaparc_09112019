using Common.Cache;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UserModel
    {

        UserDao userDao = new UserDao();

        public bool LoginUser(string user, string password)
        {
            return userDao.Login(user,password);
        }

        public void EditarPasword(int user, string pass)
        {
            if (user == UserLoginCache.IdUsuario)
            {

            }
        }
    }
}
