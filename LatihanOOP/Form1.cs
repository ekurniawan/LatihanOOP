
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LatihanOOP.MyClass;

namespace LatihanOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World !");
        }

        private void btnObject_Click(object sender, EventArgs e)
        {
            Dosen dsn1 = new Dosen
            {
                Nik = "889988",
                Nama = "Erick Kurniawan",
                Email = "erick.kurniawan@gmail.com"
            };

            DosenTerbang dsn2 = new DosenTerbang
            {
                Nik = "88899444",
                Nama = "Budi",
                Email = "budi@gmail.com",
                TiketPesawat = "Lion TT4345"
            };
            DosenTamu dsn3 = new DosenTamu
            {
                Nik = "11122234",
                Nama = "Joko",
                Email = "joko@gmail.com",
                Asal = "Surabaya"
            };

            Dosen dsn4 = new DosenTamu
            {
                Nik = "445566",
                Nama = "Bejo",
                Email = "bejo@gmail.com",
                Asal = "Yogyakarta"
            };

            Kucing kucing1 = new KucingPersia
            {
                Nama = "Catty",
                Jenis = "Persia"
            };
            string suara =  kucing1.GetSuara("persia");

            IMamalia objMamalia = new Binatang();
            IBird objBird = new Binatang();


            if(dsn4 is DosenTamu)
            {
                DosenTamu dsnTamu1 = (DosenTamu)dsn4;
                MessageBox.Show(dsnTamu1.Asal);
            }
            MessageBox.Show("Dosen 4 : " + dsn4.Nik + " " + dsn4.Nama + " " + dsn4.Email);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox myTxt = (TextBox)ctr;
                    myTxt.Enabled = false;
                }
                else if(ctr is Button)
                {
                    Button myBtn = (Button)ctr;
                    myBtn.Enabled = false;
                }
            }


        }
    }
}
