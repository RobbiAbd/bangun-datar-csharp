using BangunDatar.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangunDatar
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public void loadForm(object form)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersegi_Click(object sender, EventArgs e)
        {
            labelTitle.Text = (sender as Button).Text;
            loadForm(new SquareForm());
        }        

        private void btnPersegiPanjang_Click(object sender, EventArgs e)
        {
            labelTitle.Text = (sender as Button).Text;
            loadForm(new RectangleForm());
        }

        private void btnSegitiga_Click(object sender, EventArgs e)
        {
            labelTitle.Text = (sender as Button).Text;
            loadForm(new TriangleForm()); 
        }

        private void btnLingkaran_Click(object sender, EventArgs e)
        {
            labelTitle.Text = (sender as Button).Text;
            loadForm(new CircleForm());
        }

        private void btnTrapesium_Click(object sender, EventArgs e)
        {
            labelTitle.Text = (sender as Button).Text;
            loadForm(new TrapezoidForm());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            labelTitle.Text = (sender as Button).Text;
            loadForm(new AboutForm());
        }
    }    
}
