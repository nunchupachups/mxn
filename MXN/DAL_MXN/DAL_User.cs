using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_MXN
{
    public class DAL_User:DBConnection
    {
        public DataTable getUsers()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Account", con);
            DataTable dalUser = new DataTable();
            da.Fill(dalUser);
            dalUser.Columns.Add("Ord");
            for (int i = 1; i <= dalUser.Rows.Count; i++)
                dalUser.Rows[i - 1]["Ord"] = i.ToString();
            return dalUser;
        }
        /*public DataTable getUser(String un)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Account where username='"+un+"'", con);
            DataTable dalUser = new DataTable();
            da.Fill(dalUser);
            return dalUser;
        }
        public Boolean ktdn(String un, String pwd)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Account where username='"+un+"' and password='"+pwd+"'", con);
            DataTable kq = new DataTable();
            da.Fill(kq);
            if (kq.Rows.Count > 0) return true;
            else return false;
        }*/
        public DataTable ktdn(String un, String pwd)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Account where username='" + un + "' and password='" + pwd + "'", con);
            DataTable kq = new DataTable();
            da.Fill(kq);
            
            return kq;
        }
    }
}
