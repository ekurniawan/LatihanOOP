using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BO;
using Dapper;
using System.Configuration;

namespace DAL
{
    public class BarangDAL:ICrud<Barang>
    {
        private SqlConnection conn;

        private string strConn = ConfigurationManager
            .ConnectionStrings["MysqlConnectionString"].ConnectionString;

        public BarangDAL()
        {
            conn = new SqlConnection(strConn);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Barang> GetAll()
        {
            string strSql = @"select * from Barang 
                              order NamaBarang asc";
            var results = conn.Query<Barang>(strSql);
            return results;
        }

        public Barang GetById(string id)
        {
            string strSql = @"select * from Barang where KodeBarang=@KodeBarang";
            var param = new { KodeBarang = id };
            var result = conn.QuerySingleOrDefault<Barang>(strSql, param);

            return result;
        }

        public void Insert(Barang obj)
        {
            string strSql = @"insert into Barang(KodeBarang,NamaBarang,Stok,HargaBeli,HargaJual) 
                              values(@KodeBarang,@NamaBarang,@Stok,@HargaBeli,@HargaJual)";
            var param = new
            {
                KodeBarang = obj.KodeBarang,
                NamaBarang = obj.NamaBarang,
                Stok = obj.Stok,
                HargaBeli = obj.HargaBeli,
                HargaJual = obj.HargaJual
            };

            try
            {
                conn.Execute(strSql, param);
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public void Update(Barang obj)
        {
            throw new NotImplementedException();
        }
    }
}
