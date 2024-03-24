using System;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Back button
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        // Forward button
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        // Go button
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        // Url text box
        private void UrlKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(sender, e);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = webBrowser1.DocumentTitle;
        }
    }
}
