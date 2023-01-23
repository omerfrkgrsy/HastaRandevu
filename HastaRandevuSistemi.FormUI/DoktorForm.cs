using HastaRandevuSistemi.Service.Abstract;
using HastaRandevuSistemi.Service.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaRandevuSistemi.FormUI
{
    public partial class DoktorForm : Form
    {
        private readonly IDoktorService _doktorService;
        private readonly IBransService _bransService;
        private readonly IRandevuSaatService _randevuSaatService;
        public DoktorForm(IDoktorService doktorService, IBransService bransService,IRandevuSaatService randevuSaatService)
        {
            _doktorService = doktorService;
            _bransService = bransService;
            _randevuSaatService = randevuSaatService;
            InitializeComponent();
        }

        private async void DoktorForm_Load(object sender, EventArgs e)
        {
            idTxt.Text = "0";
            loadData();
            bransComboBox.DataSource = await _bransService.List();
            bransComboBox.ValueMember = "Id";
            bransComboBox.DisplayMember = "Ad";

            

        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            saveData();
            loadData();
        }

        private async void saveData()
        {
            DoktorDto doktorDto = new DoktorDto();
            doktorDto.Id = Convert.ToInt32(idTxt.Text);
            doktorDto.Ad = adTextBox.Text;
            doktorDto.Soyad = soyadTextBox.Text;
            doktorDto.KullaniciAdi = kullaniciAdiTextBox.Text;
            doktorDto.Sifre = sifreTextBox.Text;
            doktorDto.TelefonNo = telefonNoTextBox.Text;
            doktorDto.BransId = Convert.ToInt32(bransComboBox.SelectedValue.ToString());

            try
            {
                var isExist = await _doktorService.CheckUserName(doktorDto.KullaniciAdi);
                if (isExist)
                {
                    MessageBox.Show("Doktor Kaydedilemedi. Kullanıcı Adı Kullanımda", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DoktorDto saveModel;
                if (doktorDto.Id != 0 && doktorDto.Id != null)
                {

                    saveModel = await _doktorService.Update(doktorDto);
                    setDefaultData();
                    MessageBox.Show(saveModel.Ad + " " + saveModel.Soyad + " adlı Doktorun Bilgileri Güncellendi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    saveModel = await _doktorService.Add(doktorDto);
                    setDefaultData();
                    MessageBox.Show(saveModel.Ad + " " + saveModel.Soyad + " adlı Doktor Eklendi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor Kaydedilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void loadData()
        {
            doktorDataGrid.DataSource = await _doktorService.List();
        }

        private void doktorDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTxt.Text = doktorDataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            adTextBox.Text = doktorDataGrid.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
            soyadTextBox.Text = doktorDataGrid.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
            sifreTextBox.Text = doktorDataGrid.Rows[e.RowIndex].Cells["Sifre"].Value.ToString();
            kullaniciAdiTextBox.Text = doktorDataGrid.Rows[e.RowIndex].Cells["KullaniciAdi"].Value.ToString();
            telefonNoTextBox.Text = doktorDataGrid.Rows[e.RowIndex].Cells["TelefonNo"].Value.ToString();
            bransComboBox.SelectedValue= doktorDataGrid.Rows[e.RowIndex].Cells["BransId"].Value;
            iptalBtn.Enabled = true;
            idTxt.Visible = true;
            idLabel.Visible = true;
            silBtn.Enabled = true;
        }

        private void setDefaultData()
        {
            idTxt.Text = "0";
            adTextBox.Text = "";
            soyadTextBox.Text = "";
            kullaniciAdiTextBox.Text = "";
            sifreTextBox.Text = "";
            telefonNoTextBox.Text = "";
            bransComboBox.SelectedIndex = 0;
            iptalBtn.Enabled = false;
            idTxt.Visible = false;
            idLabel.Visible = false;
            silBtn.Enabled = false;
        }

        private async void silBtn_Click(object sender, EventArgs e)
        {
            DoktorDto doktorDto = new DoktorDto();
            doktorDto.Id = Convert.ToInt32(idTxt.Text);
            doktorDto.Ad = adTextBox.Text;
            doktorDto.Soyad = soyadTextBox.Text;
            try
            {
                await _doktorService.Delete(doktorDto.Id);
                setDefaultData();
                loadData();
                MessageBox.Show(doktorDto.Ad + " " + doktorDto.Soyad + " adlı Doktor Silindi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            setDefaultData();
        }
    }
}
