using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvc_type__app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string[] data = {$"'{textBox1.Text}'",$"'{textBox2.Text}'",$"'{textBox3.Text}'" };

            Class1.insert("stud",data);
            

            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tname = "hello";
            string[] Fargs = { "h1", "h2", "h3", "h4", "h5", "h6" };
            string[] Uargs = { "A", "B", "C", "D", "E", "F" };
            string result = Class1.update(tname, 1, Fargs, Uargs);


            MessageBox.Show(result);
        }
    }
}
