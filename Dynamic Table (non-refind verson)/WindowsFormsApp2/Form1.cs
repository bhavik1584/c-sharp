using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Runtime.InteropServices.ComTypes;
using System.Data.Common;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int a=0;
        static int v = 0;
       
      
        string queryall;
        SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\naimi\\OneDrive\\Documents\\t_data.mdf;Integrated Security=True;Connect Timeout=30");


        private void addtextbox()
        {
            string name = textBoxn.Text;
            int f = Convert.ToInt32(textBoxf.Text);

            for (int i = 0; i < (f * 3); i++)
            {
                TextBox t1 = new TextBox();
                t1.Top = i * 27;
                t1.Left = 100;
                t1.Name = "textbox" + i;
                flowLayoutPanel1.Controls.Add(t1);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            addtextbox();
            //  textBoxf.Text= string.Empty;
            // textBoxn.Text= string.Empty;
            flowLayoutPanel1.Controls[0].Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f = Convert.ToInt32(textBoxf.Text);
            string name = textBoxn.Text;
            fetchdata(f, name);
        }


        private void fetchdata(int f, string name)
        {
            string[] s1 = new string[f * 3];

            string[] str = new string[f];

           

            for (int i = 0; i < s1.Length; i++)
            {
                s1[i] = flowLayoutPanel1.Controls[i].Text;

                
                
            }

            for (int j = 0; j < str.Length; j++)
            {
                str[j] = $"{s1[a]} {s1[++a].ToUpper()}({s1[++a]}),";
                a++;
            }



            string queryall = $"CREATE TABLE {name}(";


            for (int i = 0; i < str.Length; i++)
            {


                queryall += str[i];

                if(i==str.Length-1)
                {
                   
                    queryall+=")";
                }

            }



            MessageBox.Show(queryall);


            SqlDataAdapter da = new SqlDataAdapter(queryall,sc);

             DataTable dt = new DataTable();
            da.Fill(dt);

        }







               
            
          
        
    }


}
