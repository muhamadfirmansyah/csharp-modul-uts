using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Copyright UTS GENAP 2018 by Muhamad Firmansyah | RPL X-2
namespace Allhamdulillah_UTS_Genap_Firmansyah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Semua data harus diisi!!!", "Peringatan!!");
            }
            else{
                fungsi fs=new fungsi();
                if(fs.statusLogin(textBox1.Text,textBox2.Text)==true)
                {
                    this.Hide();
                    Home hm=new Home();
                    hm.Show();
                }
                else{
                    MessageBox.Show("Maaf Username/Password Salah, Coba Cek Kembali", "Informasi");
                }
            }
        }
    }
}