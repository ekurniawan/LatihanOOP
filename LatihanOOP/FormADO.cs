using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using MySql.Data.MySqlClient;
using System.Configuration;
using LatihanOOP.Models;

namespace LatihanOOP
{
    public partial class FormADO : Form
    {
        //membuat object koneksi
        //private MySqlConnection conn;
        //private MySqlCommand cmd;
        //private List<Pelanggan> lstPelanggan;

        public FormADO()
        {
            InitializeComponent();
            //string strConn = "Server=localhost;Database=posdb;Uid=root;Pwd=;";
            //string strConn = ConfigurationManager.ConnectionStrings["MysqlConnectionString"]
            //    .ConnectionString;
            //conn = new MySqlConnection(strConn);
        }

        private void btnKonek_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    lstPelanggan = new List<Pelanggan>();
            //    string strSql = @"select * from pelanggan 
            //                      order by Nama asc";
            //    cmd = new MySqlCommand(strSql, conn);
            //    conn.Open();
            //    MySqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //            lstPelanggan.Add(new Pelanggan
            //            {
            //                KodePelanggan = Convert.ToInt32(dr["KodePelanggan"]),
            //                Nama = dr["Nama"].ToString(),
            //                Alamat = dr["Alamat"].ToString(),
            //                Email = dr["Email"].ToString(),
            //                Telp = dr["Telp"].ToString()
            //            });
            //        }
            //    }
            //    dr.Close();

            //    dgvPelanggan.DataSource = lstPelanggan;
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    cmd.Dispose();
            //    conn.Close();
            //}
        }
    }
}
