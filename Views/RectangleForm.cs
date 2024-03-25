using BangunDatar.Controllers;
using BangunDatar.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangunDatar.Views
{
    public partial class RectangleForm : Form
    {
        public RectangleForm()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            labelHasil.Text = "?";

            if (!ValidationUtils.checkIsEmpty(textPanjang) || !ValidationUtils.checkIsEmpty(textLebar))
            {
                MessageBox.Show("Inputan tidak boleh kosong!", "Alert");
                return;
            }

            if (!ValidationUtils.checkIsNumber(textPanjang) || !ValidationUtils.checkIsNumber(textLebar))
            {
                MessageBox.Show("Inputan hanya boleh angka!", "Alert");
                return;
            }

            Controllers.Rectangle model = new Controllers.Rectangle();
            model.p = int.Parse(textPanjang.Text);
            model.l = int.Parse(textPanjang.Text);

            labelHasil.Text = model.Area().ToString();
        }
    }
}
