﻿namespace JPEGVIEW
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file1 = new System.Windows.Forms.ToolStripMenuItem();
            this.open1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.window1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hTile1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vTile1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cascade1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIcons1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.open2 = new System.Windows.Forms.ToolStripButton();
            this.close2 = new System.Windows.Forms.ToolStripButton();
            this.resize2 = new System.Windows.Forms.ToolStripButton();
            this.stretch2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file1,
            this.window1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.window1;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file1
            // 
            this.file1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open1,
            this.toolStripMenuItem2,
            this.exit1});
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(37, 20);
            this.file1.Text = "&File";
            // 
            // open1
            // 
            this.open1.Name = "open1";
            this.open1.Size = new System.Drawing.Size(103, 22);
            this.open1.Text = "&Open";
            this.open1.Click += new System.EventHandler(this.open1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 6);
            // 
            // exit1
            // 
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(103, 22);
            this.exit1.Text = "E&xit";
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // window1
            // 
            this.window1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTile1,
            this.vTile1,
            this.cascade1,
            this.arrangeIcons1});
            this.window1.Name = "window1";
            this.window1.Size = new System.Drawing.Size(63, 20);
            this.window1.Text = "&Window";
            // 
            // hTile1
            // 
            this.hTile1.Name = "hTile1";
            this.hTile1.Size = new System.Drawing.Size(180, 22);
            this.hTile1.Text = "&HTile";
            this.hTile1.Click += new System.EventHandler(this.hTile1_Click);
            // 
            // vTile1
            // 
            this.vTile1.Name = "vTile1";
            this.vTile1.Size = new System.Drawing.Size(180, 22);
            this.vTile1.Text = "&VTile";
            this.vTile1.Click += new System.EventHandler(this.hTile1_Click);
            // 
            // cascade1
            // 
            this.cascade1.Name = "cascade1";
            this.cascade1.Size = new System.Drawing.Size(180, 22);
            this.cascade1.Text = "&Cascade";
            this.cascade1.Click += new System.EventHandler(this.hTile1_Click);
            // 
            // arrangeIcons1
            // 
            this.arrangeIcons1.Name = "arrangeIcons1";
            this.arrangeIcons1.Size = new System.Drawing.Size(180, 22);
            this.arrangeIcons1.Text = "&Arrange Icons";
            this.arrangeIcons1.Click += new System.EventHandler(this.hTile1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Images|*.jpg;*.jpeg";
            this.openFileDialog1.Title = "Открытие файла";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open2,
            this.close2,
            this.resize2,
            this.stretch2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // open2
            // 
            this.open2.AutoSize = false;
            this.open2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.open2.Image = ((System.Drawing.Image)(resources.GetObject("open2.Image")));
            this.open2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open2.Name = "open2";
            this.open2.Size = new System.Drawing.Size(50, 22);
            this.open2.Text = "Open";
            this.open2.Click += new System.EventHandler(this.open1_Click);
            // 
            // close2
            // 
            this.close2.AutoSize = false;
            this.close2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.close2.Enabled = false;
            this.close2.Image = ((System.Drawing.Image)(resources.GetObject("close2.Image")));
            this.close2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(50, 22);
            this.close2.Text = "Close";
            this.close2.Click += new System.EventHandler(this.close2_Click);
            // 
            // resize2
            // 
            this.resize2.AutoSize = false;
            this.resize2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resize2.Enabled = false;
            this.resize2.Image = ((System.Drawing.Image)(resources.GetObject("resize2.Image")));
            this.resize2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resize2.Name = "resize2";
            this.resize2.Size = new System.Drawing.Size(50, 22);
            this.resize2.Text = "Resize";
            this.resize2.Click += new System.EventHandler(this.resize2_Click);
            // 
            // stretch2
            // 
            this.stretch2.AutoSize = false;
            this.stretch2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stretch2.Enabled = false;
            this.stretch2.Image = ((System.Drawing.Image)(resources.GetObject("stretch2.Image")));
            this.stretch2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stretch2.Name = "stretch2";
            this.stretch2.Size = new System.Drawing.Size(50, 22);
            this.stretch2.Text = "Stretch";
            this.stretch2.Click += new System.EventHandler(this.stretch2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JPEG Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem open1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exit1;
        private System.Windows.Forms.ToolStripMenuItem hTile1;
        private System.Windows.Forms.ToolStripMenuItem vTile1;
        private System.Windows.Forms.ToolStripMenuItem cascade1;
        private System.Windows.Forms.ToolStripMenuItem arrangeIcons1;
        internal System.Windows.Forms.ToolStripMenuItem window1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton open2;
        internal System.Windows.Forms.ToolStripButton stretch2;
        internal System.Windows.Forms.ToolStripButton close2;
        internal System.Windows.Forms.ToolStripButton resize2;
    }
}

