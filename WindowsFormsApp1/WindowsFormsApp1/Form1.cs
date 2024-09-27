using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hata_oldumu=0;
            if (textBox1.Text!="admin")
            {
                hata_oldumu = 1;
                label4.Visible = true;
                MessageBox.Show("kullanıcı adı hatalı");
            }

            if (textBox2.Text!="admin123")
            {
                hata_oldumu = 2;
                label4.Visible = true;
                MessageBox.Show("kullanıcı adı hatalı");
            }
            if (textBox1.Text=="admin")
            {
                label4.Visible = false;
                MessageBox.Show("başarılı giriş");
            }
            if (textBox2.Text == "admin123")
            {
                MessageBox.Show("başarılı giriş");
            }  
     
          
             
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
