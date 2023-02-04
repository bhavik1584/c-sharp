using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace mvc_type__app
{
    internal class Class1
    {

        public static SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\bhavi\\Documents\\VIP.mdf;Integrated Security=True;Connect Timeout=30");
        
        public static string arraystr;
        public static string str;


        //done

        public static string insert(string tname,string[]args)
        {

            //normal version

            /* string str = "INSERT INTO '" + tname + "' VALUES(";

             for(int i=0;i<args.Length;i++)
             {
                 str += args[i]+",";
             }

             str +=")";

             return str;

             */
           

          //refiendment version

             arraystr = string.Join(",", args);

             str = $"INSERT INTO {tname} VALUES();";

             str=str.Insert(str.IndexOf('(')+1, arraystr);


                SqlDataAdapter da = new SqlDataAdapter(str, sc);
                DataTable dt = new DataTable();
                da.Fill(dt);

            MessageBox.Show("data insert sucessfully");

            return str;

        }


        //done

        public static string selectAllData(string tname)
        {
            str = $"SELECT * FROM {tname}";

            SqlDataAdapter da = new SqlDataAdapter(str, sc);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return str;
        }


        //done
        public static string selectParticulerData(string tname,int id)
        {
            str = $"SELECT * FROM {tname} WHERE id={id}";

            SqlDataAdapter da = new SqlDataAdapter(str, sc);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return str;
        }


        //some issue
        public static string update(string tname, int id ,string[] Fargs,string[] Uargs)
        {

             str = $"UPDATE {tname} SET  WHERE id = {id}";
             
            

             arraystr = string.Join($"={Uargs},", Fargs);

             str=str.Insert(str.LastIndexOf('T')+2,arraystr);

            

            return str;
        }

       
       // done
        public static string delete(string tname,int id)
        {
            str = $"DELETE FROM {tname} WHERE id = {id}";

            SqlDataAdapter da = new SqlDataAdapter(str, sc);
            DataTable dt = new DataTable();
            da.Fill(dt);


            return str;

        }

    }
}
