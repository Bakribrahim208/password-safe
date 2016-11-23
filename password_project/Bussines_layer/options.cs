using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace password_project.Bussines_layer
{

    class options
    {
        Data_Access_layer.Data_access_layer dl = new Data_Access_layer.Data_access_layer();

      public     void insert_account(string Account_name, string Web_address, string username, string password,string desc)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Account_name", SqlDbType.VarChar, 50);
            param[0].Value = Account_name;
            param[1] = new SqlParameter("@Web_address", SqlDbType.VarChar, 50);
            param[1].Value = Web_address;

            param[2] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[2].Value = username;
            param[3] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[3].Value = password;
            param[4] = new SqlParameter("@desc", SqlDbType.VarChar, 1000);
             param[4].Value = desc;
            dl.open();
            dl.ExecuteCommand("Add_account", param);
            dl.close();


        }

      public DataTable all_account()
      {
          dl.open();
          DataTable dt = new DataTable();
          dt = dl.select("ALL_ACCOUNT", null);
          dl.close();
          return dt;
      }

      public void Delete_account(int ID)
      {
          SqlParameter[] param = new SqlParameter[1];
          param[0] = new SqlParameter("@ID", SqlDbType.Int);
          param[0].Value = ID;
          
          dl.open();
          dl.ExecuteCommand("Delete_account", param);
          dl.close();


      }
      public void Edite_Account(string Account_name, string Web_address, string username, string password, string desc,int ID)
      {
          SqlParameter[] param = new SqlParameter[6];
          param[0] = new SqlParameter("@Account_name", SqlDbType.VarChar, 50);
          param[0].Value = Account_name;
          param[1] = new SqlParameter("@Web_address", SqlDbType.VarChar, 50);
          param[1].Value = Web_address;
          param[2] = new SqlParameter("@username", SqlDbType.VarChar, 50);
          param[2].Value = username;
          param[3] = new SqlParameter("@password", SqlDbType.VarChar, 50);
          param[3].Value = password;
          param[4] = new SqlParameter("@desc", SqlDbType.VarChar, 1000);
          param[4].Value = desc;
          param[5] = new SqlParameter("@Id", SqlDbType.Int);
          param[5].Value = ID;
          dl.open();
          dl.ExecuteCommand("Edite_Account", param);
          dl.close();


      }
    }
}
