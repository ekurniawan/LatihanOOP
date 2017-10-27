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

        private void InisialisasiSave()
        {
            AddDataBinding();
            foreach (var ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox myTxt = (TextBox)ctr;
                    myTxt.Enabled = false;
                }
                else if (ctr is Button)
                {
                    Button myBtn = (Button)ctr;
                    myBtn.Enabled = true;
                }
            }
            btnSave.Enabled = false;
            isNew = false;
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

        private void InisialisasiEdit()
        {
            ClearBinding();
            foreach (var ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox myTxt = (TextBox)ctr;
                    myTxt.Enabled = true;
                }
                else if (ctr is Button)
                {
                    Button myBtn = (Button)ctr;
                    myBtn.Enabled = false;
                }
                txtKodePelanggan.Enabled = false;
            }
            btnSave.Enabled = true;
            txtKodePelanggan.Enabled = false;
            txtNama.Focus();
            isNew = false;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                //tambah data
                try
                {
                    Pelanggan newPelanggan = new Pelanggan
                    {
                        Nama=txtNama.Text,
                        Alamat=txtAlamat.Text,
                        Email=txtEmail.Text,
                        Telp=txtTelp.Text
                    };
                    pelangganBL.Insert(newPelanggan);
                    IsiData();
                    InisialisasiSave();
                    MessageBox.Show("Tambah data pelanggan berhasil !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan : " + ex.Message);
                }
            }
            else
            {
                try
                {
                    Pelanggan editPelanggan = new Pelanggan
                    {
                        KodePelanggan=Convert.ToInt32(txtKodePelanggan.Text),
                        Nama=txtNama.Text,
                        Alamat=txtAlamat.Text,
                        Email=txtEmail.Text,
                        Telp=txtTelp.Text
                    };
                    pelangganBL.Update(editPelanggan);
                    IsiData();
                    InisialisasiSave();
                    MessageBox.Show("Data Pelanggan berhasil diedit !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan:" + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            InisialisasiEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin untuk mendelete data pelanggan?","Keterangan",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    ClearBinding();
                    pelangganBL.Delete(txtKodePelanggan.Text);
                    MessageBox.Show("Data pelanggan berhasil didelete !");
                    IsiData();
                    InisialisasiAwal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal didelete, " + ex.Message);
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
    }
}
