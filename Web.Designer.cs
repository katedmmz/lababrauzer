namespace lababrauzer
{
    partial class Web
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Web));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gobackButton = new System.Windows.Forms.ToolStripButton();
            this.goforwardButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.searchbox = new System.Windows.Forms.ToolStripTextBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.newtabButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.marks = new System.Windows.Forms.ToolStripDropDownButton();
            this.history = new System.Windows.Forms.ToolStripButton();
            this.like = new System.Windows.Forms.ToolStripButton();
            this.dislike = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.savedriver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.marks,
            this.history,
            this.like,
            this.dislike});
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
            // marks
            // 
            this.marks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.marks.Image = ((System.Drawing.Image)(resources.GetObject("marks.Image")));
            this.marks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.marks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(64, 54);
            this.marks.Text = "добавить в закладки";
            this.marks.Click += new System.EventHandler(this.marks_Click);
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
            // like
            // 
            this.like.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.like.Image = ((System.Drawing.Image)(resources.GetObject("like.Image")));
            this.like.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.like.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(54, 54);
            this.like.Text = "Сохранить закладку";
            this.like.Click += new System.EventHandler(this.like_Click);
            // 
            // dislike
            // 
            this.dislike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dislike.Image = ((System.Drawing.Image)(resources.GetObject("dislike.Image")));
            this.dislike.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dislike.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dislike.Name = "dislike";
            this.dislike.Size = new System.Drawing.Size(44, 54);
            this.dislike.Text = "Удалить из закладок";
            this.dislike.Click += new System.EventHandler(this.dislike_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 393);
            this.tabControl1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedriver});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 28);
            // 
            // savedriver
            // 
            this.savedriver.Name = "savedriver";
            this.savedriver.Size = new System.Drawing.Size(216, 24);
            this.savedriver.Text = "Сохранить на диске";
            this.savedriver.Click += new System.EventHandler(this.сохранитьНаДискеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Web";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton history;
        private System.Windows.Forms.ToolStripButton like;
        private System.Windows.Forms.ToolStripButton dislike;
        private System.Windows.Forms.ToolStripDropDownButton marks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem savedriver;
    }
}

