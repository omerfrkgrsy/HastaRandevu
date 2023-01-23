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
    public partial class SekreterForm : Form
    {
        private readonly ISekreterService _sekreterService;
        public SekreterForm(ISekreterService sekreterService)
        {
            _sekreterService = sekreterService;
            InitializeComponent();
        }

        private void SekreterForm_Load(object sender, EventArgs e)
        {
            loadData();
            idTxt.Text = "0";
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            saveData();
            loadData();
        }

        private async void loadData()
        {
            sekreterDataGrid.DataSource = await _sekreterService.List();
        }

        private async void saveData()
        {

            SekreterDto sekreterDto = new SekreterDto();
            sekreterDto.Id = Convert.ToInt32(idTxt.Text);
            sekreterDto.Ad = adTextBox.Text;
            sekreterDto.Soyad = soyadTextBox.Text;
            sekreterDto.KullaniciAdi = kullaniciAdiTextBox.Text;
            sekreterDto.Sifre = sifreTextBox.Text;
            sekreterDto.TelefonNo = telefonNoTextBox.Text;

            try
            {
                var isExist = await _sekreterService.CheckUserName(sekreterDto.KullaniciAdi);
                if (isExist)
                {
                    MessageBox.Show("Sekreter Kaydedilemedi. Kullanıcı Adı Kullanımda", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SekreterDto saveModel;
                if (sekreterDto.Id !=0 && sekreterDto.Id != null)
                {

                    saveModel = await _sekreterService.Update(sekreterDto);
                    setDefaultData();
                    MessageBox.Show(saveModel.Ad + " " + saveModel.Soyad + " adlı sekreterin Bilgileri Güncellendi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    saveModel = await _sekreterService.Add(sekreterDto);
                    setDefaultData();
                    MessageBox.Show(saveModel.Ad + " " + saveModel.Soyad + " adlı sekreter Eklendi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sekreter Kaydedilemedi","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            setDefaultData();
        }

        private void setDefaultData()
        {
            idTxt.Text = "0";
            adTextBox.Text = "";
            soyadTextBox.Text = "";
            kullaniciAdiTextBox.Text = "";
            sifreTextBox.Text = "";
            telefonNoTextBox.Text = "";
            iptalBtn.Visible = false;
            idTxt.Visible = false;
            idLabel.Visible = false;
            silBtn.Visible = false;
        }
        private void sekreterDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTxt.Text = sekreterDataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            adTextBox.Text = sekreterDataGrid.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
            soyadTextBox.Text = sekreterDataGrid.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
            kullaniciAdiTextBox.Text = sekreterDataGrid.Rows[e.RowIndex].Cells["KullaniciAdi"].Value.ToString();
            sifreTextBox.Text = sekreterDataGrid.Rows[e.RowIndex].Cells["Sifre"].Value.ToString();
            telefonNoTextBox.Text = sekreterDataGrid.Rows[e.RowIndex].Cells["TelefonNo"].Value.ToString();
            iptalBtn.Visible = true;
            idTxt.Visible = true;
            idLabel.Visible = true;
            silBtn.Visible = true;
        }

        private async void silBtn_Click(object sender, EventArgs e)
        {
            SekreterDto sekreterDto = new SekreterDto();
            sekreterDto.Id = Convert.ToInt32(idTxt.Text);
            sekreterDto.Ad = adTextBox.Text;
            sekreterDto.Soyad = soyadTextBox.Text;
            try
            {
                await _sekreterService.Delete(sekreterDto.Id);
                setDefaultData();
                loadData();
                MessageBox.Show(sekreterDto.Ad + " " + sekreterDto.Soyad + " adlı sekreter Silindi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sekreter Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
