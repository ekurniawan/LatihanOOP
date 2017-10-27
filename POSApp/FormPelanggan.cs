using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BO;

namespace POSApp
{
    public partial class FormPelanggan : Form
    {
        private PelangganBL pelangganBL;
        private List<Pelanggan> listPelanggan;
        private BindingSource bs;

        public FormPelanggan()
        {
            InitializeComponent();
            pelangganBL = new PelangganBL();
        }

        #region MyMethod

        private void IsiData()
        {
            listPelanggan = pelangganBL.GetAll().ToList();
            bs = new BindingSource();
            bs.DataSource = listPelanggan;
            dgvPelanggan.DataSource = bs;
        }

        #endregion

        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            IsiData();
        }
    }
}
