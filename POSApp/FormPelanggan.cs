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
        private bool isNew = false;

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

        private void ClearBinding()
        {
            txtKodePelanggan.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtNama.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtTelp.DataBindings.Clear();
        }

        private void AddDataBinding()
        {
            ClearBinding();
            txtKodePelanggan.DataBindings.Add("Text", bs, "KodePelanggan");
            txtNama.DataBindings.Add("Text", bs, "Nama");
            txtAlamat.DataBindings.Add("Text", bs, "Alamat");
            txtEmail.DataBindings.Add("Text", bs, "Email");
            txtTelp.DataBindings.Add("Text", bs, "Telp");
        }

        private void InisialisasiAwal()
        {
            foreach(var ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    TextBox myTxt = (TextBox)ctr;
                    myTxt.Enabled = false;
                }
                else if(ctr is Button)
                {
                    Button myBtn = (Button)ctr;
                    myBtn.Enabled = true;
                }
            }
            btnSave.Enabled = false;
        }

        private void InisialisasiNew()
        {
            ClearBinding();
            foreach (var ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox myTxt = (TextBox)ctr;
                    myTxt.Enabled = true;
                    myTxt.Text = string.Empty;
                }
                else if (ctr is Button)
                {
                    Button myBtn = (Button)ctr;
                    myBtn.Enabled = false;
                }
                txtKodePelanggan.Enabled = false;
            }
            btnSave.Enabled = true;
            txtNama.Focus();
            isNew = true;
        }

        #endregion

        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            IsiData();
            AddDataBinding();
            InisialisasiAwal();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InisialisasiNew();
        }
    }
}
