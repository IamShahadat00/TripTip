﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TRIPTIP
{
    public partial class TripTip : Form
    {
        public TripTip()
        {
            InitializeComponent();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();

        }
    }
}
