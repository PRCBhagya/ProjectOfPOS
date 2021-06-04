using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPosSystem_Software
{
    class StaffSetGetData
    {

        private String UserName;

        public void SetUserName(string UserName)
        {
            this.UserName = UserName;
        }

        public string GetUserName()
        {
            return UserName;
        }

    }
}
