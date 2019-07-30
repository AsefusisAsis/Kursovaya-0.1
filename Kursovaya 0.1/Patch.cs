using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_0._1
{
    public partial class Patch : Form
    {
        public Patch()
        {
            InitializeComponent();
        }

        private void Patch_Load(object sender, EventArgs e)
        {

            Uri uri = new Uri(PatchVal.patch);
            webBrowser1.Url = uri;
            panel1.Width = this.Width;
            panel1.Height = this.Height;
            panel1.Top = 0;
            panel1.Left = 0;
            webBrowser1.Height = this.Height + 72;
            webBrowser1.Top = -72;
            webBrowser1.Left = 0;
            label1.Left = this.Width - label1.Width - 20;
            label1.Top = this.Height - label1.Height - 10;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
            
            
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
