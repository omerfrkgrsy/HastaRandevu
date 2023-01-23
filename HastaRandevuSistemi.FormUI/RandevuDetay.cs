using HastaRandevuSistemi.Service.Abstract;
using HastaRandevuSistemi.Service.Dto;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class RandevuDetay : Form
    {
        private readonly IRandevuService _randevuService;
        public RandevuListDto selectedRandevu;
        public RandevuDetay(IRandevuService randevuService)
        {
            _randevuService = randevuService;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void randevuBitirBtn_Click(object sender, EventArgs e)
        {
            completeRandevu();
        }
        private async void completeRandevu()
        {
            try
            {
                RandevuDto saveModel;
                if (selectedRandevu.Id != 0 && selectedRandevu.Id != null)
                {

                    saveModel = await _randevuService.CompleteRandevu(selectedRandevu.Id, notRichTxt.Text);
                    MessageBox.Show("Randevu Tamamlandı.", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (var doktorDetay = Program.ServiceProvider.GetRequiredService<DoktorMenu>())
                    {
                        doktorDetay.loadData();
                        this.Hide();

                        doktorDetay.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu Tamamlanamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void RandevuDetay_Load(object sender, EventArgs e)
        {
            hastaTxt.Text = selectedRandevu.Hasta;
            doktorTxt.Text = selectedRandevu.Doktor;
            tarihTxt.Text = selectedRandevu.RandevuTarihi.ToString();
            saatTxt.Text = selectedRandevu.RandevuSaat;
            durumTxt.Text = !selectedRandevu.isCompleted ? "Aktif":"Tamamlandı";
            notRichTxt.Text = selectedRandevu.RandevuNotu;
            if(selectedRandevu.isCompleted)
            {
                notRichTxt.ReadOnly = true;
            }
            hastaTxt.ReadOnly = true;
            doktorTxt.ReadOnly = true;
            tarihTxt.ReadOnly = true;
            saatTxt.ReadOnly = true;
            durumTxt.ReadOnly = true;
            if (selectedRandevu.isCompleted)
            {
                randevuBitirBtn.Visible = false;
            }
        }

        private void RandevuDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var doktorDetay = Program.ServiceProvider.GetRequiredService<DoktorMenu>())
            {

                doktorDetay.loadData();
                this.Hide();
                doktorDetay.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
