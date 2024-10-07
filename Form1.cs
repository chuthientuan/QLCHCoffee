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
    public partial class Form1 : Form
    {
        UserControl_Login userControl_Login;
        UserControl_Home userControl_Home;
        public Form1()
        {
            InitializeComponent();
            userControl_Login = new UserControl_Login();
            userControl_Home = new UserControl_Home();

            userControl_Login.Dock = DockStyle.Fill;
            userControl_Home.Dock = DockStyle.Fill;

            userControl_Login.OnSwitchToHome += UserControl_Login_OnSwitchToHome;
            userControl_Home.OnSwitchToLogin += UserControl_Home_OnSwitchToLogin;

            this.Controls.Add(userControl_Login);
        }
        private void UserControl_Login_OnSwitchToHome(object sender, EventArgs e)
        {
            // Chuyển sang trang Home
            this.Controls.Clear();
            this.Controls.Add(userControl_Home);
        }

        private void UserControl_Home_OnSwitchToLogin(object sender, EventArgs e)
        {
            // Chuyển sang trang Login
            this.Controls.Clear();
            this.Controls.Add(userControl_Login);
        }
    }
}
