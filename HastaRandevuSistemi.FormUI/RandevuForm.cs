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
    public partial class RandevuForm : Form
    {
        private readonly IRandevuSaatService _randevuTarihService;
        private readonly IHastaService _hastaService;
        private readonly IDoktorService _doktorService;
        private readonly IBransService _bransService;
        private readonly IRandevuService _randevuService;
        public RandevuForm(IRandevuSaatService randevuTarihService, IHastaService hastaService, IDoktorService doktorService, IBransService bransService,IRandevuService randevuService)
        {
            _randevuTarihService = randevuTarihService;
            _hastaService = hastaService;
            _doktorService = doktorService;
            _bransService = bransService;
            _randevuService = randevuService;
            InitializeComponent();
        }

        private async void randevuTarihDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime tarih=randevuTarihDatePicker.Value;
            DoktorDto doktor = (DoktorDto)doktorCombo.SelectedItem;
            randevuSaatCombo.DataSource=await _randevuTarihService.GetRandevuSaatList(tarih, doktor.Id);
            randevuSaatCombo.ValueMember = "Id";
            randevuSaatCombo.DisplayMember = "Saat";
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private async void RandevuForm_Load(object sender, EventArgs e)
        {
            hastaCombo.DataSource = await _hastaService.List();
            hastaCombo.ValueMember = "Id";
            bolumCombo.DataSource = await _bransService.List();
            bolumCombo.ValueMember = "Id";
            bolumCombo.DisplayMember = "Ad";
            randevuTarihDatePicker.Value = DateTime.Today;
            randevuTarihDatePicker.MinDate = DateTime.Today;
            randevuTarihDatePicker.MaxDate = DateTime.Today.AddDays(7);
        }

        private void hastaCombo_Format(object sender, ListControlConvertEventArgs e)
        {
            string tckn = ((HastaDto)e.ListItem).TCKN;
            string name = ((HastaDto)e.ListItem).Ad  + " " + ((HastaDto)e.ListItem).Soyad;
            e.Value = tckn + " - " + name;
        }

        private void bolumCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void bolumCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            BransDto selectedBolum = (BransDto)bolumCombo.SelectedItem;
            doktorCombo.SelectedValue = "";
            doktorCombo.DataSource = await _doktorService.GetDoktorsByBolum(selectedBolum.Id);
            doktorCombo.ValueMember = "Id";
        }

        private void doktorCombo_Format(object sender, ListControlConvertEventArgs e)
        {
            string name = ((DoktorDto)e.ListItem).Ad + " " + ((DoktorDto)e.ListItem).Soyad;
            e.Value = name;
        }

        private async void saveData()
        {
            DoktorDto doktor = (DoktorDto)doktorCombo.SelectedItem;
            HastaDto hasta = (HastaDto)hastaCombo.SelectedItem;
            RandevuSaatDto randevuSaat = (RandevuSaatDto)randevuSaatCombo.SelectedItem;
            if (doktor==null)
            {
                MessageBox.Show("Randevu Kaydedilemedi,Lütfen Doktor Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hasta == null)
            {
                MessageBox.Show("Randevu Kaydedilemedi,Lütfen Hasta Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (randevuSaat == null)
            {
                MessageBox.Show("Randevu Kaydedilemedi,Lütfen Randevu Saati Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RandevuDto randevuDto = new RandevuDto();
            randevuDto.DoktorId = doktor.Id;
            randevuDto.SekreterId = 1;
            randevuDto.HastaId = hasta.Id;
            randevuDto.RandevuTarihi = randevuTarihDatePicker.Value;
            randevuDto.RandevuSaatId = randevuSaat.Id;

            try
            {

                RandevuDto saveModel;
                saveModel = await _randevuService.Add(randevuDto);
                RandevuForm.ActiveForm.Hide();
                //setDefaultData();
                MessageBox.Show("Randevu Kaydedildi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu Kaydedilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void doktorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            randevuTarihDatePicker.Value = DateTime.Today;
        }
    }
}
