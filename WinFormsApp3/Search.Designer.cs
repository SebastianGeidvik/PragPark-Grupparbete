
namespace WinFormsApp3
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_SearchText = new System.Windows.Forms.TextBox();
            this.button_Return = new System.Windows.Forms.Button();
            this.listBox_SearchResult = new System.Windows.Forms.ListBox();
            this.comboBox_SearchOption = new System.Windows.Forms.ComboBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(240, 366);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(173, 29);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_SearchText
            // 
            this.textBox_SearchText.Location = new System.Drawing.Point(240, 324);
            this.textBox_SearchText.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SearchText.Name = "textBox_SearchText";
            this.textBox_SearchText.Size = new System.Drawing.Size(173, 23);
            this.textBox_SearchText.TabIndex = 2;
            this.textBox_SearchText.Visible = false;
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(125, 506);
            this.button_Return.Margin = new System.Windows.Forms.Padding(2);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(78, 25);
            this.button_Return.TabIndex = 6;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // listBox_SearchResult
            // 
            this.listBox_SearchResult.BackColor = System.Drawing.Color.White;
            this.listBox_SearchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_SearchResult.ForeColor = System.Drawing.Color.Black;
            this.listBox_SearchResult.FormattingEnabled = true;
            this.listBox_SearchResult.ItemHeight = 15;
            this.listBox_SearchResult.Location = new System.Drawing.Point(262, 408);
            this.listBox_SearchResult.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_SearchResult.Name = "listBox_SearchResult";
            this.listBox_SearchResult.Size = new System.Drawing.Size(126, 75);
            this.listBox_SearchResult.TabIndex = 4;
            // 
            // comboBox_SearchOption
            // 
            this.comboBox_SearchOption.FormattingEnabled = true;
            this.comboBox_SearchOption.Items.AddRange(new object[] {
            "License plate",
            "Owner name"});
            this.comboBox_SearchOption.Location = new System.Drawing.Point(240, 281);
            this.comboBox_SearchOption.Name = "comboBox_SearchOption";
            this.comboBox_SearchOption.Size = new System.Drawing.Size(173, 23);
            this.comboBox_SearchOption.TabIndex = 1;
            this.comboBox_SearchOption.Text = "Choose Option";
            this.comboBox_SearchOption.SelectedIndexChanged += new System.EventHandler(this.comboBox_SearchOption_SelectedIndexChanged);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(285, 506);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(78, 25);
            this.button_Reset.TabIndex = 5;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-207, -14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(240, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 506);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 796);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.comboBox_SearchOption);
            this.Controls.Add(this.listBox_SearchResult);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.textBox_SearchText);
            this.Controls.Add(this.button_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Vehicle";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_SearchText;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.ListBox listBox_SearchResult;
        private System.Windows.Forms.ComboBox comboBox_SearchOption;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}