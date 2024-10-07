using Guna.UI2.WinForms;
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
        private Guna2CircleButton currentButton;
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
        

        private void HighlightButton(Guna2CircleButton selectedButton)
        {
            if (currentButton != null)
            {
                // Reset màu của button trước đó
                currentButton.FillColor = Color.Transparent;
            }

            // Đổi màu của button hiện tại
            selectedButton.FillColor = Color.FromArgb(45, 45, 86);
            currentButton = selectedButton;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            HighlightButton(guna2CircleButton1);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            HighlightButton(guna2CircleButton2);
        }
    }
}
