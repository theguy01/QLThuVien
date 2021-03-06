using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using quanly.lopdulieu;
using quanly.doituong;

namespace quanly.frm
{
    public partial class Frdangnhap : Form
    {
        public Frdangnhap()
        {
            InitializeComponent();
        }
        public static NhanVien nv ;
        private void Load_SavedPass()
        {
            try
            {
                string file_name = "Luudangnhap.txt";
                StreamReader rd = File.OpenText(file_name);
                tbten.Text = rd.ReadLine();
                tbMatKhau.Text = rd.ReadLine();
                rd.Close();
                tbten.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static string strtendn="",strMatKhaudn ="",strtensv="",strMatKhausv="";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            strtendn = tbten.Text;
            strMatKhaudn = tbMatKhau.Text;
            string file_name = "Luudangnhap.txt";
            if (chkSavePass.Checked)
            {

                StreamWriter sw = new StreamWriter(file_name);
                sw.WriteLine(tbten.Text);
                sw.WriteLine(tbMatKhau.Text);
                sw.Close();

            }
            else
            {
                StreamWriter sw = new StreamWriter(file_name);
                sw.Flush();
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frdangnhap_Load(object sender, EventArgs e)
        {
            Frmmain.tt = true;
            Load_SavedPass();
        }

        private void Frdangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frmmain.tt = false;
        }
    }
}