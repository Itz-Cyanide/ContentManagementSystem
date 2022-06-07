using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManagementSystemUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public  string MakeBlogPost()
        {
            string title, date, post;
            title = titleTxtBox.Text.ToString();
            date = dateTimePicker1.Value.ToString();
            post = blogTxtBox.Text.ToString();
            return $"Title: {title}\n\n" + $"{" "}" +
                $"Date: {date}\n\n" + $"{" "}" + $"{post}";

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Method to put it in the Blog TextBox
            blogPostBox.Text= MakeBlogPost();
           
            //Forground Color
            if (comboBox1.SelectedIndex == 0)
            {
                blogTxtBox.ForeColor = Color.Black;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                blogPostBox.ForeColor = Color.White;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                blogPostBox.ForeColor = Color.Red;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                blogPostBox.ForeColor = Color.Orange;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                blogPostBox.ForeColor = Color.LightBlue;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                blogPostBox.ForeColor = Color.Pink;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                blogPostBox.ForeColor = Color.Green;
            }

            //Background Color
            if (comboBox2.SelectedIndex == 0)
            {
                blogPostBox.BackColor = Color.White;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                blogPostBox.BackColor = Color.Black;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                blogPostBox.BackColor = Color.Red;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                blogPostBox.BackColor = Color.Orange;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                blogPostBox.BackColor = Color.LightBlue;
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                blogPostBox.BackColor = Color.Pink;
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                blogPostBox.BackColor = Color.Green;
            }


          
        }
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //if(comboBox1.SelectedIndex == 0)
           // {
           //     blogTxtBox.ForeColor = Color.Black;
           // }
           //else if(comboBox1.SelectedIndex == 1)
           // {
           //     blogPostBox.ForeColor = Color.White;
           // }
           // else if (comboBox1.SelectedIndex == 1)
           // {
           //     blogPostBox.ForeColor = Color.Red;
           // }
           // else if (comboBox1.SelectedIndex == 1)
           // {
           //     blogPostBox.ForeColor = Color.Orange;
           // }
           // else if (comboBox1.SelectedIndex == 1)
           // {
           //     blogPostBox.ForeColor = Color.LightBlue;
           // }
           // else if (comboBox1.SelectedIndex == 1)
           // {
           //     blogPostBox.ForeColor = Color.Pink;
           // }
           // else if (comboBox1.SelectedIndex == 1)
           // {
           //     blogPostBox.ForeColor = Color.Green;
           // }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BackGround Color
            //if (comboBox2.SelectedIndex == 0)
            //{
            //    blogPostBox.BackColor = Color.White;
            //}
            //else if (comboBox2.SelectedIndex == 1)
            //{
            //    blogPostBox.BackColor = Color.Black;
            //}
            //else if (comboBox2.SelectedIndex == 2)
            //{
            //    blogPostBox.BackColor = Color.Red;
            //}
            //else if (comboBox2.SelectedIndex == 3)
            //{
            //    blogPostBox.BackColor = Color.Orange;
            //}
            //else if (comboBox2.SelectedIndex == 4)
            //{
            //    blogPostBox.BackColor = Color.LightBlue;
            //}
            //else if (comboBox2.SelectedIndex == 5)
            //{
            //    blogPostBox.BackColor = Color.Pink;
            //}
            //else if (comboBox2.SelectedIndex == 6)
            //{
            //    blogPostBox.BackColor = Color.Green;
            //}
        }

        private void blogPostBox_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
