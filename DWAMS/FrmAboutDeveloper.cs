using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DWAMS
{
    public partial class FrmAboutDeveloper : Form
    {
        private string link;
        private string page_link;

        public FrmAboutDeveloper()
        {
            InitializeComponent();
        }
        public void Link(string labName, string nickname, string labPhone, string link, string linkName, string page_link , string page_name)
        {
            this.Text = "ေဆာ့ဖ္၀ဲလ္ေရးေနစဉ္..."+labName +" ၏ သမိုင္း...";
            lblName.Text = labName;
            lblnickname.Text = nickname;
            lblPhone.Text = labPhone;
            linkFacebook.Text = linkName;
            this.link = link;

            this.page_link = page_link;
            link_lbl_page.Text = page_name;

            switch (labName)
            {
                case"Nay Tun Linn":
                    picDeveloper.Image = Properties.Resources.NayTunLin;
                    break;

                case "Chit Ko Ko":
                    picDeveloper.Image = Properties.Resources.CKK;
                    break;

                case"Kyaw Nyein Phyo":
                    picDeveloper.Image = Properties.Resources.KyawNyeinPhyo;
                    break;

                case"Saung Wai Phyo":
                    picDeveloper.Image = Properties.Resources.SWP;
                    break;
            }


        }

        private void FrmDeveloperAbout_Load(object sender, EventArgs e)
        {

        }

        private void linkFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link);
        }

        private void link_lbl_page_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(page_link);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}