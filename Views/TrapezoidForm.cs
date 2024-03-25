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
    public partial class TrapezoidForm : Form
    {
        public TrapezoidForm()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            labelHasil.Text = "?";

            if (!ValidationUtils.checkIsEmpty(textA) || !ValidationUtils.checkIsEmpty(textB) || !ValidationUtils.checkIsEmpty(textTinggi))
            {
                MessageBox.Show("Inputan tidak boleh kosong!", "Alert");
                return;
            }

            if (!ValidationUtils.checkIsNumber(textA) || !ValidationUtils.checkIsNumber(textB) || !ValidationUtils.checkIsNumber(textTinggi))
            {
                MessageBox.Show("Inputan hanya boleh angka!", "Alert");
                return;
            }

            Trapezoid model = new Trapezoid();
            model.a = int.Parse(textA.Text);
            model.b = int.Parse(textB.Text);
            model.t = int.Parse(textTinggi.Text);

            labelHasil.Text = model.Width().ToString();
        }
    }
}
