using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerce2.Models
{
    public class UserInfoModel
    {
        public UserInformation GetUserInformation(string guId)
        {
            E_Commerce2Entities4 db = new E_Commerce2Entities4();
            var info = (from x in db.UserInformation
                        where x.GUID == guId
                        select x).FirstOrDefault();
            return info;
        }

        public void InsertUserDetail(UserInformation info)
        {
            E_Commerce2Entities4 db = new E_Commerce2Entities4();
            db.UserInformation.Add(info);
            db.SaveChanges();
        }
    }
}