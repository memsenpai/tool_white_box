namespace tool_white_box
{
    partial class MainFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.cbCss = new System.Windows.Forms.CheckBox();
            this.cbJS = new System.Windows.Forms.CheckBox();
            this.cbHtml = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCELxsltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btRun = new MetroFramework.Controls.MetroTile();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabCss = new MetroFramework.Controls.MetroTabPage();
            this.tabJs = new MetroFramework.Controls.MetroTabPage();
            this.tabHtml = new MetroFramework.Controls.MetroTabPage();
            this.ChoiceFolder1 = new tool_white_box.ChoiceFolder();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCss
            // 
            this.cbCss.AutoSize = true;
            this.cbCss.Location = new System.Drawing.Point(43, 160);
            this.cbCss.Name = "cbCss";
            this.cbCss.Size = new System.Drawing.Size(43, 17);
            this.cbCss.TabIndex = 1;
            this.cbCss.Text = "Css";
            this.cbCss.UseVisualStyleBackColor = true;
            // 
            // cbJS
            // 
            this.cbJS.AutoSize = true;
            this.cbJS.Location = new System.Drawing.Point(43, 181);
            this.cbJS.Name = "cbJS";
            this.cbJS.Size = new System.Drawing.Size(79, 17);
            this.cbJS.TabIndex = 1;
            this.cbJS.Text = "Javascripts";
            this.cbJS.UseVisualStyleBackColor = true;
            // 
            // cbHtml
            // 
            this.cbHtml.AutoSize = true;
            this.cbHtml.Location = new System.Drawing.Point(43, 204);
            this.cbHtml.Name = "cbHtml";
            this.cbHtml.Size = new System.Drawing.Size(47, 17);
            this.cbHtml.TabIndex = 1;
            this.cbHtml.Text = "Html";
            this.cbHtml.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 3;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.eXCELxsltToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // eXCELxsltToolStripMenuItem
            // 
            this.eXCELxsltToolStripMenuItem.Name = "eXCELxsltToolStripMenuItem";
            this.eXCELxsltToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.eXCELxsltToolStripMenuItem.Text = "EXCEL(*.xslt)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // btRun
            // 
            this.btRun.ActiveControl = null;
            this.btRun.BackColor = System.Drawing.Color.LimeGreen;
            this.btRun.Location = new System.Drawing.Point(275, 171);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(106, 50);
            this.btRun.TabIndex = 4;
            this.btRun.Text = "Run";
            this.btRun.UseCustomBackColor = true;
            this.btRun.UseSelectable = true;
            this.btRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCss);
            this.tabControl1.Controls.Add(this.tabJs);
            this.tabControl1.Controls.Add(this.tabHtml);
            this.tabControl1.Location = new System.Drawing.Point(7, 227);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 556);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.UseSelectable = true;
            // 
            // tabCss
            // 
            this.tabCss.HorizontalScrollbarBarColor = true;
            this.tabCss.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCss.HorizontalScrollbarSize = 10;
            this.tabCss.Location = new System.Drawing.Point(4, 38);
            this.tabCss.Name = "tabCss";
            this.tabCss.Size = new System.Drawing.Size(435, 514);
            this.tabCss.TabIndex = 0;
            this.tabCss.Text = "Css";
            this.tabCss.VerticalScrollbarBarColor = true;
            this.tabCss.VerticalScrollbarHighlightOnWheel = false;
            this.tabCss.VerticalScrollbarSize = 10;
            // 
            // tabJs
            // 
            this.tabJs.HorizontalScrollbarBarColor = true;
            this.tabJs.HorizontalScrollbarHighlightOnWheel = false;
            this.tabJs.HorizontalScrollbarSize = 10;
            this.tabJs.Location = new System.Drawing.Point(4, 38);
            this.tabJs.Name = "tabJs";
            this.tabJs.Size = new System.Drawing.Size(435, 514);
            this.tabJs.TabIndex = 1;
            this.tabJs.Text = "Javascripts";
            this.tabJs.VerticalScrollbarBarColor = true;
            this.tabJs.VerticalScrollbarHighlightOnWheel = false;
            this.tabJs.VerticalScrollbarSize = 10;
            // 
            // tabHtml
            // 
            this.tabHtml.HorizontalScrollbarBarColor = true;
            this.tabHtml.HorizontalScrollbarHighlightOnWheel = false;
            this.tabHtml.HorizontalScrollbarSize = 10;
            this.tabHtml.Location = new System.Drawing.Point(4, 38);
            this.tabHtml.Name = "tabHtml";
            this.tabHtml.Size = new System.Drawing.Size(435, 514);
            this.tabHtml.TabIndex = 2;
            this.tabHtml.Text = "Html";
            this.tabHtml.VerticalScrollbarBarColor = true;
            this.tabHtml.VerticalScrollbarHighlightOnWheel = false;
            this.tabHtml.VerticalScrollbarSize = 10;
            // 
            // ChoiceFolder1
            // 
            this.ChoiceFolder1.Location = new System.Drawing.Point(43, 107);
            this.ChoiceFolder1.Name = "ChoiceFolder1";
            this.ChoiceFolder1.Size = new System.Drawing.Size(341, 79);
            this.ChoiceFolder1.TabIndex = 0;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 829);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.cbHtml);
            this.Controls.Add(this.cbJS);
            this.Controls.Add(this.cbCss);
            this.Controls.Add(this.ChoiceFolder1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrom";
            this.Resizable = false;
            this.Text = "White~Box~Team~1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ChoiceFolder ChoiceFolder1;
        private System.Windows.Forms.CheckBox cbCss;
        private System.Windows.Forms.CheckBox cbJS;
        private System.Windows.Forms.CheckBox cbHtml;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCELxsltToolStripMenuItem;
        private MetroFramework.Controls.MetroTile btRun;
        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage tabCss;
        private MetroFramework.Controls.MetroTabPage tabJs;
        private MetroFramework.Controls.MetroTabPage tabHtml;
    }
}

