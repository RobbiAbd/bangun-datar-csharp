﻿using BangunDatar.Controllers;
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
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            labelHasil.Text = "?";

            if (!ValidationUtils.checkIsEmpty(textAlas) || !ValidationUtils.checkIsEmpty(textTinggi))
            {
                MessageBox.Show("Inputan tidak boleh kosong!", "Alert");
                return;
            }

            if (!ValidationUtils.checkIsNumber(textAlas) || !ValidationUtils.checkIsNumber(textTinggi))
            {
                MessageBox.Show("Inputan hanya boleh angka!", "Alert");
                return;
            }

            Triangle model = new Triangle();
            model.a = int.Parse(textAlas.Text);
            model.t = int.Parse(textTinggi.Text);

            labelHasil.Text = model.Width().ToString();
        }
    }
}
