namespace tool_white_box
{
    partial class ChoiceFolder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new MetroFramework.Controls.MetroTile();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.ActiveControl = null;
            this.button.Location = new System.Drawing.Point(232, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(106, 50);
            this.button.TabIndex = 3;
            this.button.Text = "Select Folder";
            this.button.UseSelectable = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(0, 11);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PromptText = "Path";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(211, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseCustomBackColor = true;
            this.textBox1.UseCustomForeColor = true;
            this.textBox1.UseSelectable = true;
            this.textBox1.UseStyleColors = true;
            this.textBox1.WaterMark = "Path";
            this.textBox1.WaterMarkColor = System.Drawing.SystemColors.Control;
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(1)), true);
            // 
            // ChoiceFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button);
            this.Name = "ChoiceFolder";
            this.Size = new System.Drawing.Size(341, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile button;
        private MetroFramework.Controls.MetroTextBox textBox1;
    }
}
