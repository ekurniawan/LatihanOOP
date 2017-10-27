using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using BO;

namespace DAL
{
    public class PelangganDAL : ICrud<Pelanggan>
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        private string strConn = ConfigurationManager
            .ConnectionStrings["MysqlConnectionString"].ConnectionString;

        public PelangganDAL()
        {
            conn = new SqlConnection(strConn);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pelanggan> GetAll()
        {
            List<Pelanggan> lstPelanggan = new List<Pelanggan>();
            string strSql = @"select * from pelanggan 
                                      order by Nama asc";
            SqlCommand cmd = new SqlCommand(strSql, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
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
            catch (SqlException mysqlEx)
            {
                throw new Exception(mysqlEx.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

        }

        public Pelanggan GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Pelanggan obj)
        {
            string strSql = @"insert into Pelanggan(Nama,Alamat,Email,Telp) 
                                  values(@Nama,@Alamat,@Email,@Telp)";
            SqlCommand cmd = new SqlCommand(strSql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nama", obj.Nama);
            cmd.Parameters.AddWithValue("@Alamat", obj.Alamat);
            cmd.Parameters.AddWithValue("@Email", obj.Email);
            cmd.Parameters.AddWithValue("@Telp", obj.Telp);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error : " + sqlEx.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public void Update(Pelanggan obj)
        {
            string strSql = @"update Pelanggan set Nama=@Nama,Alamat=@Alamat,Email=@Email,Telp=@Telp
                              where KodePelanggan=@KodePelanggan";
            SqlCommand cmd = new SqlCommand(strSql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nama", obj.Nama);
            cmd.Parameters.AddWithValue("@Alamat", obj.Alamat);
            cmd.Parameters.AddWithValue("@Email", obj.Email);
            cmd.Parameters.AddWithValue("@Telp", obj.Telp);
            cmd.Parameters.AddWithValue("KodePelanggan", obj.KodePelanggan);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}
