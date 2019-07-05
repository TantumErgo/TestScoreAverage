namespace Test_Score_Average
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.test1Label = new System.Windows.Forms.Label();
            this.test2Label = new System.Windows.Forms.Label();
            this.test3Label = new System.Windows.Forms.Label();
            this.averageNameLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.test3TextBox);
            this.groupBox1.Controls.Add(this.test2TextBox);
            this.groupBox1.Controls.Add(this.test1TextBox);
            this.groupBox1.Controls.Add(this.averageLabel);
            this.groupBox1.Controls.Add(this.averageNameLabel);
            this.groupBox1.Controls.Add(this.test3Label);
            this.groupBox1.Controls.Add(this.test2Label);
            this.groupBox1.Controls.Add(this.test1Label);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Three Test Scores";
            // 
            // test1Label
            // 
            this.test1Label.AutoSize = true;
            this.test1Label.Location = new System.Drawing.Point(50, 19);
            this.test1Label.Name = "test1Label";
            this.test1Label.Size = new System.Drawing.Size(75, 13);
            this.test1Label.TabIndex = 0;
            this.test1Label.Text = "Test Score #1";
            // 
            // test2Label
            // 
            this.test2Label.AutoSize = true;
            this.test2Label.Location = new System.Drawing.Point(50, 59);
            this.test2Label.Name = "test2Label";
            this.test2Label.Size = new System.Drawing.Size(75, 13);
            this.test2Label.TabIndex = 1;
            this.test2Label.Text = "Test Score #2";
            // 
            // test3Label
            // 
            this.test3Label.AutoSize = true;
            this.test3Label.Location = new System.Drawing.Point(50, 102);
            this.test3Label.Name = "test3Label";
            this.test3Label.Size = new System.Drawing.Size(75, 13);
            this.test3Label.TabIndex = 2;
            this.test3Label.Text = "Test Score #3";
            // 
            // averageNameLabel
            // 
            this.averageNameLabel.AutoSize = true;
            this.averageNameLabel.Location = new System.Drawing.Point(50, 137);
            this.averageNameLabel.Name = "averageNameLabel";
            this.averageNameLabel.Size = new System.Drawing.Size(47, 13);
            this.averageNameLabel.TabIndex = 3;
            this.averageNameLabel.Text = "Average";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(134, 137);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(100, 23);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(137, 16);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.test1TextBox.TabIndex = 5;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(137, 56);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 20);
            this.test2TextBox.TabIndex = 6;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(137, 99);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 20);
            this.test3TextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(65, 198);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 52);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(149, 198);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(149, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label averageNameLabel;
        private System.Windows.Forms.Label test3Label;
        private System.Windows.Forms.Label test2Label;
        private System.Windows.Forms.Label test1Label;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

