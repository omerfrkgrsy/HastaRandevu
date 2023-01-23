using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Service.Abstract;
using HastaRandevuSistemi.Service.Dto;
using Microsoft.Extensions.DependencyInjection;

namespace HastaRandevuSistemi.FormUI
{
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();
        }

        private void sekreterLoginBtn_Click(object sender, EventArgs e)
        {
            using (var sekreterGirisForm = Program.ServiceProvider.GetRequiredService<SekreterGirisForm>())
            {
                Login.ActiveForm.Hide();
                sekreterGirisForm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var doktorGirisForm = Program.ServiceProvider.GetRequiredService<DoktorGiris>())
            {
                Login.ActiveForm.Hide();
                doktorGirisForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.Close();
        }
    }
}