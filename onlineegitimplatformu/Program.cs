using System;
using System.Windows.Forms;

namespace OnlineEgitimPlatformu
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GirisForm girisForm = new GirisForm();
            if (girisForm.ShowDialog() == DialogResult.OK)
            {
                if (girisForm.GirisYapanOgrenci != null)
                {
                    // Öğrenci girişi
                    Application.Run(new MainForm(girisForm.GirisYapanOgrenci.OgrenciID, girisForm.GirisYapanOgrenci.AdSoyad));


                }
                else
                {
                    // Öğretmen girişi
                    Application.Run(new OgretmenForm());
                }
            }
        }
    }
}