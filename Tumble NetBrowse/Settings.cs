using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tumble_NetBrowse
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            homePageBox.Text = Properties.Settings.Default.homePage;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButon_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.homePage = homePageBox.Text;
            Close();
        }
    }
}
