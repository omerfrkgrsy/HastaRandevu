using HastaRandevuSistemi.Service.Abstract;
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
    public partial class SekreterMenu : Form
    {
        private readonly IRandevuService _randevuService;
        private int id;
        public SekreterMenu(IRandevuService randevuService)
        {
            _randevuService = randevuService;
            InitializeComponent();
        }

        private void randevuBtn_Click(object sender, EventArgs e)
        {
            using (var randevu = Program.ServiceProvider.GetRequiredService<RandevuForm>())
            {
                randevu.ShowDialog();
            }
        }

        private void sekreterBtn_Click(object sender, EventArgs e)
        {
            using (var sekreterForm = Program.ServiceProvider.GetRequiredService<SekreterForm>())
                sekreterForm.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            using (var sekreterGiris = Program.ServiceProvider.GetRequiredService<SekreterGirisForm>())
            {
                SekreterMenu.ActiveForm.Hide();
                sekreterGiris.ShowDialog();
            }
                
        }

        private void hastaBtn_Click(object sender, EventArgs e)
        {
            using (var hastaForm = Program.ServiceProvider.GetRequiredService<HastaForm>())
                hastaForm.ShowDialog();
        }

        private void doktorBtn_Click(object sender, EventArgs e)
        {
            using (var doktorForm = Program.ServiceProvider.GetRequiredService<DoktorForm>())
                doktorForm.ShowDialog();
        }

        private void SekreterMenu_Load(object sender, EventArgs e)
        {
            userLabel.Text = "Hoşgeldiniz " + AuthenticationUser.Ad;
            loadData();
        }

        private async void loadData()
        {
            var model = await _randevuService.List();
            
            randevuDataGrid.DataSource = model;
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void randevuDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            randevuIptalBtn.Visible = true;
            iptalBtn.Visible = true;
            id= Convert.ToInt32(randevuDataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
        }

        private async void randevuIptalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await _randevuService.Delete(id);
                randevuIptalBtn.Visible = false;
                iptalBtn.Visible = false;
                loadData();
                MessageBox.Show("Randevu Silindi", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            randevuIptalBtn.Visible = false;
            iptalBtn.Visible = false;
        }
    }
}
