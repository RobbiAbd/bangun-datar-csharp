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
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            labelHasil.Text = "?";

            if (!ValidationUtils.checkIsEmpty(textJariJari))
            {
                MessageBox.Show("Inputan tidak boleh kosong!", "Alert");
                return;
            }

            if (!ValidationUtils.checkIsNumber(textJariJari))
            {
                MessageBox.Show("Inputan hanya boleh angka!", "Alert");
                return;
            }

            Circle model = new Circle();
            model.r = int.Parse(textJariJari.Text);
            labelHasil.Text = model.Width().ToString();
        }
    }
}
