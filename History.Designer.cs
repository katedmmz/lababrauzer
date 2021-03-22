namespace lababrauzer
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.delethistory = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // delethistory
            // 
            this.delethistory.BackColor = System.Drawing.Color.CadetBlue;
            this.delethistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delethistory.Location = new System.Drawing.Point(0, 392);
            this.delethistory.Name = "delethistory";
            this.delethistory.Size = new System.Drawing.Size(800, 58);
            this.delethistory.TabIndex = 0;
            this.delethistory.Text = "Удалить историю";
            this.delethistory.UseVisualStyleBackColor = false;
            this.delethistory.Click += new System.EventHandler(this.delethistory_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 392);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
          
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.delethistory);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delethistory;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}