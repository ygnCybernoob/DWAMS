using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DWAMS
{
    public partial class FrmAboutUs : Form
    {
        public FrmAboutUs()
        {
            InitializeComponent();
        }
        

        private void linkNayTunLin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAboutDeveloper dv = new FrmAboutDeveloper();
            dv.Link("Nay Tun Linn", "\"Auto သိတယ္\" ဆုိေသာ စကားကုိ လက္၀ယ္ထားသုံးသူ\nေခၚၾကတယ္   -   ကုိေအာ္တုိ", "09 967116108", "https://www.facebook.com/nay.tunlinn.129", "Nay Tun Linn", "https://www.facebook.com/Code-Killer-823645761354007/", "Code Killer");
            dv.ShowDialog();
        }

        private void linkCKK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAboutDeveloper dv = new FrmAboutDeveloper();
            dv.Link("Chit Ko Ko", "\"အစက စမယ္\" ဆုိေသာ စကားကုိ လက္၀ယ္ထားသုံးသူ\nေခၚၾကတယ္   -   ကုိအစ","09 792692958", "https://www.facebook.com/profile.php?id=100012646692971", "Chit Ko Ko", "https://www.facebook.com/ProgrammingProjectMM/", "Programming Project");
            dv.ShowDialog();
        }

        private void linkKNP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAboutDeveloper dv = new FrmAboutDeveloper();
            dv.Link("Kyaw Nyein Phyo", "\"တဟားဟား\" ရယ္ျခင္းကုိ လက္ကိုင္ထားသူ\nေခၚၾကတယ္   -   ကုိဟားဟား", "09 76166 8727", "https://www.facebook.com/kyawgyi16.kg", "Kyaw Nyein Phyo", "https://www.facebook.com/The-Geek-225370248008884/", "THE GEEK");
            dv.ShowDialog();
        }

        private void linkSWP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAboutDeveloper dv = new FrmAboutDeveloper();
            dv.Link("Saung Wai Phyo", "\"မဟုတ္ဘူး\" ဆုိေသာ စကားကုိ လက္၀ယ္ထားသုံးသူ\nေခၚၾကတယ္   -   မ မဟုတ္", "09 428831475", "https://www.facebook.com/saung.waiphyo.188", "Saung Wai Phyo", "https://www.facebook.com/ZTH-Computer-Training-179563696005323/", "ZTH Computer Training");
            dv.ShowDialog();
        }

        private void lnklblVisit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Code-Hunters-1642268175858570/");
        }


    }
}