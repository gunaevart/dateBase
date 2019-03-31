using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dateBase
{
    class Db
    {
        public string DateBase(string login, string pass)
        {
            if(login == "Владимир" && pass == "123" )
            {
                return login;
            }
            else
            {
                string err = "Такого пользователя не существует";
                return err;
            }

        }
    }
}
