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
    public partial class DoktorMenu : Form
    {
        private readonly IRandevuService _randevuService;
        public DoktorMenu(IRandevuService randevuService)
        {
            _randevuService = randevuService;
            InitializeComponent();
        }

        private void DoktorMenu_Load(object sender, EventArgs e)
        {
            userLabel.Text = "Hoşgeldiniz Dr. " + AuthenticationUser.Ad;
            loadData();
        }

        public async void loadData()
        {

            randevuDataGrid.DataSource = await _randevuService.List(AuthenticationUser.Id);
        }

        private void randevuDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RandevuListDto dto = new RandevuListDto();
            dto.Id = Convert.ToInt32(randevuDataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            dto.RandevuNotu = randevuDataGrid.Rows[e.RowIndex].Cells["RandevuNotu"].Value.ToString() ?? "";
            dto.Sekreter = randevuDataGrid.Rows[e.RowIndex].Cells["Sekreter"].Value.ToString();
            dto.Doktor = randevuDataGrid.Rows[e.RowIndex].Cells["Doktor"].Value.ToString();
            dto.Hasta = randevuDataGrid.Rows[e.RowIndex].Cells["Hasta"].Value.ToString();
            dto.RandevuSaat = randevuDataGrid.Rows[e.RowIndex].Cells["RandevuSaat"].Value.ToString();
            dto.isCompleted = randevuDataGrid.Rows[e.RowIndex].Cells["isCompleted"].Value.ToString() =="False" ? false:true;
            dto.RandevuTarihi = Convert.ToDateTime(randevuDataGrid.Rows[e.RowIndex].Cells["RandevuTarihi"].Value.ToString());

            using (var randevuDetay = Program.ServiceProvider.GetRequiredService<RandevuDetay>())
            {
                randevuDetay.selectedRandevu = dto;
                DoktorMenu.ActiveForm.Hide();
                randevuDetay.ShowDialog();
            }


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            using (var doktorGiris = Program.ServiceProvider.GetRequiredService<DoktorGiris>())
            {
                this.Hide();
                doktorGiris.ShowDialog();
            }
        }
    }
}
