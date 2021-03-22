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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("history.txt");
        }
        private void delethistory_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            File.WriteAllText("history.txt", "");
        }
    }
}
