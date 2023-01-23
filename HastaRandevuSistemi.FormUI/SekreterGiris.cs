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
    public partial class SekreterGirisForm : Form
    {
        private readonly ISekreterService _sekreterService;
        public SekreterGirisForm(ISekreterService sekreterService )
        {
            _sekreterService = sekreterService;
            InitializeComponent();
        }

        private void SekreterGiris_Load(object sender, EventArgs e)
        {

            sifreTxt.PasswordChar = '*';
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            SekreterGirisForm.ActiveForm.Hide();
            login.ShowDialog();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var isExist =await _sekreterService.Login(kullaniciAdiTxt.Text, sifreTxt.Text);
                if (isExist)
                {
                    MessageBox.Show("Giriş Başarılı", "Baraşılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    var authUser = await _sekreterService.GetIdByUsername(kullaniciAdiTxt.Text);
                    AuthenticationUser.Ad = authUser.Ad + " " + authUser.Soyad;
                    AuthenticationUser.Id = authUser.Id;
                    AuthenticationUser.KullaniciAdi = authUser.KullaniciAdi;
                    using (var sekreterMenu = Program.ServiceProvider.GetRequiredService<SekreterMenu>())
                    {
                        SekreterGirisForm.ActiveForm.Hide();
                        sekreterMenu.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı ve şifrenizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Giriş Yapılamadı Sistemsel Hata!Daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
