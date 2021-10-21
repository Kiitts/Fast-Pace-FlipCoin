
namespace F_P_Flip_coin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flipButton = new System.Windows.Forms.Button();
            this.flipCounts = new System.Windows.Forms.ComboBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flipButton
            // 
            this.flipButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flipButton.Location = new System.Drawing.Point(52, 12);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(75, 23);
            this.flipButton.TabIndex = 0;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // flipCounts
            // 
            this.flipCounts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flipCounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flipCounts.FormattingEnabled = true;
            this.flipCounts.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.flipCounts.Location = new System.Drawing.Point(52, 41);
            this.flipCounts.Name = "flipCounts";
            this.flipCounts.Size = new System.Drawing.Size(75, 23);
            this.flipCounts.TabIndex = 1;
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resultBox.Location = new System.Drawing.Point(52, 70);
            this.resultBox.MaximumSize = new System.Drawing.Size(74, 347);
            this.resultBox.MinimumSize = new System.Drawing.Size(75, 347);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(75, 347);
            this.resultBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "H = 0\r\nT = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.flipCounts);
            this.Controls.Add(this.flipButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(198, 468);
            this.MinimumSize = new System.Drawing.Size(198, 468);
            this.Name = "Form1";
            this.Text = "FP-FC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.ComboBox flipCounts;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label1;
    }
}

