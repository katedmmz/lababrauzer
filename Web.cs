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
    public partial class Web : Form
    {
        bool mark = false;
        int i = 0;
        public Web()
        {
            InitializeComponent();
        }
        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

    private void goforwardButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabs.SelectedTab.Controls[0]).GoForward();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabs.SelectedTab.Controls[0]).Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabs.SelectedTab.Controls[0]).Stop();
        }

        private void history_Click(object sender, EventArgs e)
        {
            History form = new History();
            form.Show();
        }

        private void searchbox_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                File.AppendAllText("history.txt", "https://www." + searchbox.Text + "\n");
                ((WebBrowser)tabs.SelectedTab.Controls[0]).Navigate(searchbox.Text);
                tabs.SelectedTab.Text = searchbox.Text;
            }
        }

        private void like_Click(object sender, EventArgs e)
        {
            mark = true;
            string url = tabs.SelectedTab.Text;
            File.AppendAllText("mark.txt", url + "\n");
        }

        private void dislike_Click(object sender, EventArgs e)
        {
            string url = tabs.SelectedTab.Text;
            string[] Lines = File.ReadAllLines("mark.txt");
            File.WriteAllText("mark.txt", "");
            for (int i = 0; i < Lines.Length; i++)
            {
                if (Lines[i] != url && Lines[i] != "")
                {
                    File.AppendAllText("mark.txt", Lines[i] + "\n");

                }
                else
                {
                    mark = true;
                }
            }
        }

        private void marks_Click(object sender, EventArgs e)
        {
            if (mark)
            {
                int n = File.ReadAllLines("mark.txt").Length;
                marks.DropDownItems.Clear();
                string[] Marks1 = File.ReadAllLines("mark.txt");
                
                marks.AutoSize = true;
                for (int j = 0; j < n; j++)
                {
                    marks.DropDownItems.Add(Marks1[j]);
                    marks.DropDownItems[j].Click += (s, t) =>
                    {
                        ToolStripMenuItem st = s as ToolStripMenuItem;
                        File.AppendAllText("history.txt", "https://www." + st.Text + "\n");
                        WebBrowser web1 = new WebBrowser();
                        web1.Visible = true;
                        web1.ScriptErrorsSuppressed = true;
                        web1.Dock = DockStyle.Fill;
                        web1.DocumentCompleted += Web_DocumentCompleted;//проверяет реализованный метод после загрузки
                        tabs.TabPages.Add(st.Text);
                        tabs.SelectTab(i);
                        tabs.SelectedTab.Controls.Add(web1);
                        i += 1;
                        ((WebBrowser)tabs.SelectedTab.Controls[0]).Navigate(st.Text);
                    };
                }

            }
            mark = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabs.ContextMenuStrip = contextMenuStrip1;
            tabs.TabPages.Add("google.ru");
            tabs.SelectTab(i);
            tabs.SelectedTab.Controls.Add(web);
            //i += 1;
            i++;
            ((WebBrowser)tabs.SelectedTab.Controls[0]).Navigate("https://www.google.ru");
            int count = File.ReadAllLines("mark.txt").Length;
            marks.DropDownItems.Clear();
            string[] Marks1 = File.ReadAllLines("mark.txt");
            marks.AutoSize = true;
            for (int j = 0; j < count; j++)
            {
                marks.DropDownItems.Add(Marks1[j]);
                marks.DropDownItems[j].Click += (s, t) =>
                {
                    ToolStripMenuItem st = s as ToolStripMenuItem;
                    File.AppendAllText("history.txt", "https://www." + st.Text + "\n");
                    WebBrowser web1 = new WebBrowser();
                    web1.Visible = true;
                    web1.ScriptErrorsSuppressed = true;
                    web1.Dock = DockStyle.Fill;
                    web1.DocumentCompleted += Web_DocumentCompleted;
                    tabs.TabPages.Add(st.Text);
                    tabs.SelectTab(i);
                    tabs.SelectedTab.Controls.Add(web1);
                    i += 1;
                    ((WebBrowser)tabs.SelectedTab.Controls[0]).Navigate(st.Text);
                };
            }
        }

        private void сохранитьНаДискеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabs.SelectedTab.Controls[0]).ShowSaveAsDialog();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchbox.Text))
            {
                File.AppendAllText("history.txt", "https://www." + searchbox.Text + "\n");
                ((WebBrowser)tabs.SelectedTab.Controls[0]).Navigate(searchbox.Text);
                tabs.SelectedTab.Text = searchbox.Text;
            }
        }

        private void gobackButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabs.SelectedTab.Controls[0]).GoBack();
        }

        private void newtabButton_Click(object sender, EventArgs e)
        {
            var web = new WebBrowser();
            web.Visible = true;
            web.Dock = DockStyle.Fill;
            tabs.TabPages.Add("Новая вкладка");
            tabs.SelectTab(i);
            tabs.SelectedTab.Controls.Add(web);
            i++;
        }
    }
}
