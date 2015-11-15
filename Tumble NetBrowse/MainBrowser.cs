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
    public partial class tumblenet : Form
    {
        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        public tumblenet()
        {
            InitializeComponent();
            webBrowser.DocumentTitleChanged +=
            new EventHandler(webBrowser_DocumentTitleChanged);
            webBrowser.StatusTextChanged +=
            new EventHandler(webBrowser_StatusTextChanged);
            //webBrowser.ProgressChanged += 
            //new EventHandler(webBrowser_ProgressChanged);

            Navigate(Properties.Settings.Default.homePage);
        }

        private void webBrowser_ProgressChanged(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlBox.Text = webBrowser.Url.ToString();
        }

        private void urlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(urlBox.Text);
            }
        }

        private void webBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            if (webBrowser.DocumentTitle != "") {
                this.Text = webBrowser.DocumentTitle + " - Tumble NetBrowse";
            }
        }

        private void webBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = webBrowser.StatusText;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void refreshButon_Click(object sender, EventArgs e)
        {
            if (!webBrowser.Url.Equals("about:blank"))
            {
                webBrowser.Refresh();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Navigate(Properties.Settings.Default.homePage);
        }

        private void aboutTumbleNetBrowseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }
    }
}
