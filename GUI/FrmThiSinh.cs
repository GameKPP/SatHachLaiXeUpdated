﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachBangLaiXe
{
    public partial class FrmThiSinh : MetroFramework.Forms.MetroForm
    {
        public FrmThiSinh()
        {
            InitializeComponent();
        }

        private void FrmThiSinh_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
