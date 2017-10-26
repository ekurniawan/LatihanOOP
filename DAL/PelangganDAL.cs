using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using BO;

namespace DAL
{
    public class PelangganDAL : ICrud<Pelanggan>
    {
        private string strConn = ConfigurationManager
            .ConnectionStrings["MysqlConnectionString"].ConnectionString;

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pelanggan> GetAll()
        {
            using(MySqlConnection conn = new MySqlConnection(strConn))
            {
                List<Pelanggan> lstPelanggan = new List<Pelanggan>();
                string strSql = @"select * from pelanggan 
                                      order by Nama asc";
                MySqlCommand cmd = new MySqlCommand(strSql, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lstPelanggan.Add(new Pelanggan
                            {
                                KodePelanggan = Convert.ToInt32(dr["KodePelanggan"]),
                                Nama = dr["Nama"].ToString(),
                                Alamat = dr["Alamat"].ToString(),
                                Email = dr["Email"].ToString(),
                                Telp = dr["Telp"].ToString()
                            });
                        }
                    }
                    dr.Close();

                    return lstPelanggan;
                }
                catch (MySqlException mysqlEx)
                {
                    throw new Exception(mysqlEx.Message);
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }

        public Pelanggan GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Pelanggan obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Pelanggan obj)
        {
            throw new NotImplementedException();
        }
    }
}
