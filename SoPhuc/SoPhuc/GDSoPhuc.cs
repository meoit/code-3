using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoPhuc
{
    public partial class GDSoPhuc : Form
    {
        public GDSoPhuc()
        {
            InitializeComponent();
        }

        private void bntTinh_Click(object sender, EventArgs e)
        {
            
   
            int  thuc1= int.Parse(this.textBox1.Text);
            int  ao1= int.Parse(this.textBox2.Text);
            int  thuc2= int.Parse(this.textBox3.Text);
            int  ao2= int.Parse(this.textBox4.Text);
            SoPhuc a =new SoPhuc(thuc1,ao1);
            SoPhuc b=new SoPhuc(thuc2,ao2);
            SoPhuc p;
            if(radioButton1.Checked)
                p = a + b;
            else if(radioButton1.Checked)
                p = a - b;
            else if(radioButton1.Checked)
                p = a * b;
            else p = a / b;
            textBox5.Text = p.Thuc.ToString();
            textBox6.Text = p.Ao.ToString();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
           
            
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       



        
    }
}