using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BL
{
    public class PelangganBL
    {
        private PelangganDAL pelangganDAL;

        public PelangganBL()
        {
            pelangganDAL = new PelangganDAL();
        }

        public IEnumerable<Pelanggan> GetAll()
        {
            return pelangganDAL.GetAll();
        }

        public void Insert(Pelanggan obj)
        {
            //validasi
            if (obj.Nama == string.Empty)
            {
                throw new Exception("Field nama harus diisi");
            }
            try
            {
                pelangganDAL.Insert(obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Kesalahan:"+ex.Message);
            }
        }


        public void Update(Pelanggan obj)
        {
            try
            {
                pelangganDAL.Update(obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Kesalahan : "+ex.Message);
            }
        }

        public void Delete(string id)
        {
            try
            {
                pelangganDAL.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Kesalahan : " + ex.Message);
            }
        }
    }
}
