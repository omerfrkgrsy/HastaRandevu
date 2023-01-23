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
    public partial class DoktorGiris : Form
    {
        private readonly IDoktorService _doktorService;
        public DoktorGiris(IDoktorService doktorService)
        {
            _doktorService = doktorService;
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var isExist = await _doktorService.Login(kullaniciAdiTxt.Text, sifreTxt.Text);
                if (isExist)
                {
                    MessageBox.Show("Giriş Başarılı", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var authUser = await _doktorService.GetIdByUsername(kullaniciAdiTxt.Text);
                    AuthenticationUser.Ad = authUser.Ad + " " + authUser.Soyad;
                    AuthenticationUser.Id = authUser.Id;
                    AuthenticationUser.KullaniciAdi = authUser.KullaniciAdi;
                    using (var doktorMenu = Program.ServiceProvider.GetRequiredService<DoktorMenu>())
                    {
                        SekreterGirisForm.ActiveForm.Hide();
                        doktorMenu.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı ve şifrenizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş Yapılamadı Sistemsel Hata!Daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            SekreterGirisForm.ActiveForm.Hide();
            login.ShowDialog();
        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            sifreTxt.PasswordChar = '*';
        }
    }
}
