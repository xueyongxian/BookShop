﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            PercentageLbl.Text = startpos + "%";
            //PercentageLbl.Text = startpos + "%";
            Myprogress.Value = startpos;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }
        }

        private void jiazhai_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
