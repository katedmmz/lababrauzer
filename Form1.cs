using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lababrauzer
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var web = new WebBrowser();
            web.Visible = true;
            web.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add("Новая вкладка");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i++;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(searchbox.Text))
            {
                File.AppendAllText("history.txt", "https://www." + searchbox.Text + "\n");
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(searchbox.Text);
                tabControl1.SelectedTab.Text = searchbox.Text;
            }

        }

        private void goforwardButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Stop();
        }

       /* private void searchbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                File.AppendAllText("history.txt", "https://www." + searchbox.Text + "\n");
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(searchbox.Text);
                tabControl1.SelectedTab.Text = searchbox.Text;
            }
        }*/

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void history_Click(object sender, EventArgs e)
        {
            History form = new History();
            form.Show();
        }

        private void searchbox_Click(object sender, EventArgs e)
        {

        }

        private void searchbox_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                File.AppendAllText("history.txt", "https://www." + searchbox.Text + "\n");
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(searchbox.Text);
                tabControl1.SelectedTab.Text = searchbox.Text;
            }
        }
    }
}
