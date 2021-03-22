namespace lababrauzer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gobackButton = new System.Windows.Forms.ToolStripButton();
            this.goforwardButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.searchbox = new System.Windows.Forms.ToolStripTextBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.newtabButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.history = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gobackButton,
            this.goforwardButton,
            this.stopButton,
            this.searchbox,
            this.goButton,
            this.newtabButton,
            this.updateButton,
            this.toolStripButton1,
            this.history});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(913, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // gobackButton
            // 
            this.gobackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gobackButton.Image = ((System.Drawing.Image)(resources.GetObject("gobackButton.Image")));
            this.gobackButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gobackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gobackButton.Name = "gobackButton";
            this.gobackButton.Size = new System.Drawing.Size(54, 54);
            this.gobackButton.Text = "назад";
            this.gobackButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // goforwardButton
            // 
            this.goforwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goforwardButton.Image = ((System.Drawing.Image)(resources.GetObject("goforwardButton.Image")));
            this.goforwardButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.goforwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goforwardButton.Name = "goforwardButton";
            this.goforwardButton.Size = new System.Drawing.Size(54, 54);
            this.goforwardButton.Text = "вперед";
            this.goforwardButton.Click += new System.EventHandler(this.goforwardButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(54, 54);
            this.stopButton.Text = "стоп";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(300, 57);
            this.searchbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchbox_KeyUp_1);
            this.searchbox.Click += new System.EventHandler(this.searchbox_Click);
            // 
            // goButton
            // 
            this.goButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(54, 54);
            this.goButton.Text = "поиск";
            this.goButton.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // newtabButton
            // 
            this.newtabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newtabButton.Image = ((System.Drawing.Image)(resources.GetObject("newtabButton.Image")));
            this.newtabButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newtabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newtabButton.Name = "newtabButton";
            this.newtabButton.Size = new System.Drawing.Size(54, 54);
            this.newtabButton.Text = "новая вкладка";
            this.newtabButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // updateButton
            // 
            this.updateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(54, 54);
            this.updateButton.Text = "обновить";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton1.Text = "добавить в закладки";
            // 
            // history
            // 
            this.history.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.history.Image = ((System.Drawing.Image)(resources.GetObject("history.Image")));
            this.history.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.history.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(54, 54);
            this.history.Text = "посмотреть историю";
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 393);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(899, 358);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newtabButton;
        private System.Windows.Forms.ToolStripButton gobackButton;
        private System.Windows.Forms.ToolStripButton goforwardButton;
        private System.Windows.Forms.ToolStripTextBox searchbox;
        private System.Windows.Forms.ToolStripButton goButton;
        private System.Windows.Forms.ToolStripButton updateButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton history;
    }
}

