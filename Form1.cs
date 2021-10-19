using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd_str = "select * from myuser where user_name= '"+textBox1.Text+"'and pass_word='"+textBox2.Text+"' ";
            DataTable dt = new DataTable();
            DBclass dbclass = new DBclass(cmd_str);
            string error = dbclass.error_msg;
            dt = dbclass.search_info();

            if (error == "")
            {
                if (dt.Rows.Count > 0)
                {
                   
                   int type= (int)dt.Rows[0]["type"];
                    if (type == 1)
                    {

                        Form2 form2 = new Form2(textBox1.Text.ToString());
                        form2.Show();
                    }
                    else if (type==2)
                    {
                        Form3 form3 = new Form3(textBox1.Text.ToString());
                        form3.Show();
                    }
                    else
                    {
                        Form4 form4 = new Form4(textBox1.Text.ToString());
                        form4.Show();
                    }
                }
                else
                {
                    MessageBox.Show(" your user name or password is wrong please try again");
                }
            }
            else
            {
                MessageBox.Show("error in searching process" + error);
                
            }


        }
    }
}
