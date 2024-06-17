using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_hinhchunhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.chieucao = Double.Parse(txtCao.Text);
            hcn.chieurong = Double.Parse(txtRong.Text);
            txtKetqua.Text = hcn.tinhdientich().ToString();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.chieucao = Double.Parse(txtCao.Text);
            hcn.chieurong = Double.Parse(txtRong.Text);
            txtKetqua.Text = hcn.tinhchuvi().ToString();
        }
    }
}
