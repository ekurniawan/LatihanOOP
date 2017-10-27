using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BL
{
    public class BarangBL
    {
        private BarangDAL barangDAL;
        public BarangBL()
        {
            barangDAL = new BarangDAL();
        }

        public IEnumerable<Barang> GetAll()
        {
            return barangDAL.GetAll();
        }

        public Barang GetById(string id)
        {
            return barangDAL.GetById(id);
        }

        public void Insert(Barang obj)
        {
            try
            {
                barangDAL.Insert(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
