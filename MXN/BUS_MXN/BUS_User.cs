using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_MXN;
using System.Data;
using System.Data.SqlClient;

namespace BUS_MXN
{
    public class BUS_User
    {
        DAL_User daUser = new DAL_User();
        public DataTable getUsers()
        {
            return daUser.getUsers();
        }
        /*public DataTable getUser(String un)
        {
            return daUser.getUser(un);
        }
        public Boolean ktdn(String un,String pwd)
        {
            return daUser.ktdn(un, pwd);
        }*/
        public DataTable ktdn(String un, String pwd)
        {
            return daUser.ktdn(un, pwd);
        }
    }
}
