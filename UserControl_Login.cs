﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class UserControl_Login : UserControl
    {
        public event EventHandler OnSwitchToHome;
        public UserControl_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (OnSwitchToHome != null)
            {
                OnSwitchToHome(this, EventArgs.Empty);
            }
        }
    }
}