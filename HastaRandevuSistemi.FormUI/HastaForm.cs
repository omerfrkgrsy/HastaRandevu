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
    public partial class HastaForm : Form
    {
        private readonly IHastaService _hastaService;
        public HastaForm(IHastaService hastaService)
        {
            _hastaService = hastaService;
            
            InitializeComponent();
        }


        private void HastaForm_Load(object sender, EventArgs e)
        {
            loadData();
            idTxt.Text = "0";
        }
        private async void loadData()
        {
            hastaDataGrid.DataSource = await _hastaService.List();
        }
        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            saveData();
            loadData();
        }

        private async void silBtn_Click(object sender, EventArgs e)
        {
            HastaDto hastaDto = new HastaDto();
            hastaDto.Id = Convert.ToInt32(idTxt.Text);
            hastaDto.Ad = adTextBox.Text;
            hastaDto.Soyad = soyadTextBox.Text;
            try
            {
                await _hastaService.Delete(hastaDto.Id);
                setDefaultData();
                loadData();
                MessageBox.Show(hastaDto.Ad + " " + hastaDto.Soyad + " adlı hasta Silindi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            setDefaultData();
        }

        private async void saveData()
        {

            HastaDto hastaDto = new HastaDto();
            hastaDto.Id = Convert.ToInt32(idTxt.Text);
            hastaDto.Ad = adTextBox.Text;
            hastaDto.Soyad = soyadTextBox.Text;
            hastaDto.TCKN = tcknTextBox.Text;
            hastaDto.TelefonNo = telefonNoTextBox.Text;

            try
            {
                var isExist = await _hastaService.CheckTckn(hastaDto.TCKN);
                if (isExist)
                {
                    MessageBox.Show("Hasta Kaydedilemedi. Bu TCKN zaten kayıtlıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                HastaDto saveModel;
                if (hastaDto.Id != 0 && hastaDto.Id != null)
                {

                    saveModel = await _hastaService.Update(hastaDto);
                    setDefaultData();
                    MessageBox.Show(saveModel.Ad + " " + saveModel.Soyad + " adlı Hastanın Bilgileri Güncellendi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    saveModel = await _hastaService.Add(hastaDto);
                    setDefaultData();
                    MessageBox.Show(saveModel.Ad + " " + saveModel.Soyad + " adlı Hasta Eklendi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta Kaydedilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void setDefaultData()
        {
            idTxt.Text = "0";
            adTextBox.Text = "";
            soyadTextBox.Text = "";
            tcknTextBox.Text = "";
            telefonNoTextBox.Text = "";
            iptalBtn.Enabled = false;
            idTxt.Visible = false;
            idLabel.Visible = false;
            silBtn.Enabled = false;
        }

        private void hastaDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTxt.Text = hastaDataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            adTextBox.Text = hastaDataGrid.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
            soyadTextBox.Text = hastaDataGrid.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
            tcknTextBox.Text = hastaDataGrid.Rows[e.RowIndex].Cells["TCKN"].Value.ToString();
            telefonNoTextBox.Text = hastaDataGrid.Rows[e.RowIndex].Cells["TelefonNo"].Value.ToString();
            iptalBtn.Enabled = true;
            idTxt.Visible = true;
            idLabel.Visible = true;
            silBtn.Enabled = true;
        }

    }
}
