namespace tool_white_box
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCss = new System.Windows.Forms.TabPage();
            this.tabJS = new System.Windows.Forms.TabPage();
            this.cbCss = new System.Windows.Forms.CheckBox();
            this.csJS = new System.Windows.Forms.CheckBox();
            this.btRun = new System.Windows.Forms.Button();
            this.ChoiceFolder1 = new tool_white_box.ChoiceFolder();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCss);
            this.tabControl1.Controls.Add(this.tabJS);
            this.tabControl1.Location = new System.Drawing.Point(0, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(451, 269);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCss
            // 
            this.tabCss.Location = new System.Drawing.Point(4, 22);
            this.tabCss.Name = "tabCss";
            this.tabCss.Padding = new System.Windows.Forms.Padding(3);
            this.tabCss.Size = new System.Drawing.Size(443, 243);
            this.tabCss.TabIndex = 0;
            this.tabCss.Text = "Css";
            this.tabCss.UseVisualStyleBackColor = true;
            // 
            // tabJS
            // 
            this.tabJS.Location = new System.Drawing.Point(4, 22);
            this.tabJS.Name = "tabJS";
            this.tabJS.Padding = new System.Windows.Forms.Padding(3);
            this.tabJS.Size = new System.Drawing.Size(443, 243);
            this.tabJS.TabIndex = 1;
            this.tabJS.Text = "Javascripts";
            this.tabJS.UseVisualStyleBackColor = true;
            // 
            // cbCss
            // 
            this.cbCss.AutoSize = true;
            this.cbCss.Location = new System.Drawing.Point(103, 45);
            this.cbCss.Name = "cbCss";
            this.cbCss.Size = new System.Drawing.Size(43, 17);
            this.cbCss.TabIndex = 1;
            this.cbCss.Text = "Css";
            this.cbCss.UseVisualStyleBackColor = true;
            // 
            // csJS
            // 
            this.csJS.AutoSize = true;
            this.csJS.Location = new System.Drawing.Point(103, 66);
            this.csJS.Name = "csJS";
            this.csJS.Size = new System.Drawing.Size(79, 17);
            this.csJS.TabIndex = 1;
            this.csJS.Text = "Javascripts";
            this.csJS.UseVisualStyleBackColor = true;
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(383, 45);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 28);
            this.btRun.TabIndex = 2;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChoiceFolder1
            // 
            this.ChoiceFolder1.Location = new System.Drawing.Point(48, 12);
            this.ChoiceFolder1.Name = "ChoiceFolder1";
            this.ChoiceFolder1.Size = new System.Drawing.Size(341, 79);
            this.ChoiceFolder1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 359);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.csJS);
            this.Controls.Add(this.cbCss);
            this.Controls.Add(this.ChoiceFolder1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCss;
        private System.Windows.Forms.TabPage tabJS;
        private ChoiceFolder ChoiceFolder1;
        private System.Windows.Forms.CheckBox cbCss;
        private System.Windows.Forms.CheckBox csJS;
        private System.Windows.Forms.Button btRun;
    }
}

