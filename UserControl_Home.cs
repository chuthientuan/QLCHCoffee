using System;
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
    public partial class UserControl_Home : UserControl
    {
        public event EventHandler OnSwitchToLogin;
        public UserControl_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnSwitchToLogin != null)
            {
                OnSwitchToLogin(this, EventArgs.Empty);
            }
        }
    }
}
