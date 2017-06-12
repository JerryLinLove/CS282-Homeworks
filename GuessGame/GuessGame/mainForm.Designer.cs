namespace GuessABGame
{
    partial class mainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.displayPanel = new System.Windows.Forms.Panel();
            this.no4Label = new System.Windows.Forms.Label();
            this.no3Label = new System.Windows.Forms.Label();
            this.no2Label = new System.Windows.Forms.Label();
            this.no1Label = new System.Windows.Forms.Label();
            this.no1Button = new System.Windows.Forms.Button();
            this.no2Button = new System.Windows.Forms.Button();
            this.no3Button = new System.Windows.Forms.Button();
            this.no4Button = new System.Windows.Forms.Button();
            this.no5Button = new System.Windows.Forms.Button();
            this.no6Button = new System.Windows.Forms.Button();
            this.no7Button = new System.Windows.Forms.Button();
            this.no8Button = new System.Windows.Forms.Button();
            this.no9Button = new System.Windows.Forms.Button();
            this.no0Button = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.displayPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayPanel
            // 
            this.displayPanel.Controls.Add(this.no4Label);
            this.displayPanel.Controls.Add(this.no3Label);
            this.displayPanel.Controls.Add(this.no2Label);
            this.displayPanel.Controls.Add(this.no1Label);
            this.displayPanel.Location = new System.Drawing.Point(55, 12);
            this.displayPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(160, 40);
            this.displayPanel.TabIndex = 0;
            // 
            // no4Label
            // 
            this.no4Label.AutoSize = true;
            this.no4Label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no4Label.Location = new System.Drawing.Point(123, 0);
            this.no4Label.Name = "no4Label";
            this.no4Label.Size = new System.Drawing.Size(27, 34);
            this.no4Label.TabIndex = 0;
            this.no4Label.Text = "-";
            // 
            // no3Label
            // 
            this.no3Label.AutoSize = true;
            this.no3Label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no3Label.Location = new System.Drawing.Point(83, 0);
            this.no3Label.Name = "no3Label";
            this.no3Label.Size = new System.Drawing.Size(27, 34);
            this.no3Label.TabIndex = 0;
            this.no3Label.Text = "-";
            // 
            // no2Label
            // 
            this.no2Label.AutoSize = true;
            this.no2Label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no2Label.Location = new System.Drawing.Point(43, 0);
            this.no2Label.Name = "no2Label";
            this.no2Label.Size = new System.Drawing.Size(27, 34);
            this.no2Label.TabIndex = 0;
            this.no2Label.Text = "-";
            // 
            // no1Label
            // 
            this.no1Label.AutoSize = true;
            this.no1Label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no1Label.Location = new System.Drawing.Point(3, 0);
            this.no1Label.Name = "no1Label";
            this.no1Label.Size = new System.Drawing.Size(27, 34);
            this.no1Label.TabIndex = 0;
            this.no1Label.Text = "-";
            // 
            // no1Button
            // 
            this.no1Button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no1Button.Location = new System.Drawing.Point(3, 3);
            this.no1Button.Name = "no1Button";
            this.no1Button.Size = new System.Drawing.Size(50, 50);
            this.no1Button.TabIndex = 1;
            this.no1Button.Text = "1";
            this.no1Button.UseVisualStyleBackColor = true;
            this.no1Button.Click += new System.EventHandler(this.no1Button_Click);
            // 
            // no2Button
            // 
            this.no2Button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no2Button.Location = new System.Drawing.Point(59, 3);
            this.no2Button.Name = "no2Button";
            this.no2Button.Size = new System.Drawing.Size(50, 50);
            this.no2Button.TabIndex = 1;
            this.no2Button.Text = "2";
            this.no2Button.UseVisualStyleBackColor = true;
            this.no2Button.Click += new System.EventHandler(this.no2Button_Click);
            // 
            // no3Button
            // 
            this.no3Button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no3Button.Location = new System.Drawing.Point(115, 3);
            this.no3Button.Name = "no3Button";
            this.no3Button.Size = new System.Drawing.Size(50, 50);
            this.no3Button.TabIndex = 1;
            this.no3Button.Text = "3";
            this.no3Button.UseVisualStyleBackColor = true;
            this.no3Button.Click += new System.EventHandler(this.no3Button_Click);
            // 
            // no4Button
            // 
            this.no4Button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no4Button.Location = new System.Drawing.Point(3, 59);
            this.no4Button.Name = "no4Button";
            this.no4Button.Size = new System.Drawing.Size(50, 50);
            this.no4Button.TabIndex = 1;
            this.no4Button.Text = "4";
            this.no4Button.UseVisualStyleBackColor = true;
            this.no4Button.Click += new System.EventHandler(this.no4Button_Click);
            // 
            // no5Button
            // 
            this.no5Button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no5Button.Location = new System.Drawing.Point(59, 59);
            this.no5Button.Name = "no5Button";
            this.no5Button.Size = new System.Drawing.Size(50, 50);
            this.no5Button.TabIndex = 1;
            this.no5Button.Text = "5";
            this.no5Button.UseVisualStyleBackColor = true;
            this.no5Button.Click += new System.EventHandler(this.no5Button_Click);
            // 
            // no6Button
            // 
            this.no6Button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no6Button.Location = new System.Drawing.Point(115, 59);
            this.no6Button.Name = "no6Button";
            this.no6Button.Size = new System.Drawing.Size(50, 50);
            this.no6Button.TabIndex = 1;
            this.no6Button.Text = "6";
            this.no6Button.UseVisualStyleBackColor = true;
            this.no6Button.Click += new System.EventHandler(this.no6Button_Click);
            // 
            // no7Button
            // 
            this.no7Button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no7Button.Location = new System.Drawing.Point(3, 115);
            this.no7Button.Name = "no7Button";
            this.no7Button.Size = new System.Drawing.Size(50, 50);
            this.no7Button.TabIndex = 1;
            this.no7Button.Text = "7";
            this.no7Button.UseVisualStyleBackColor = true;
            this.no7Button.Click += new System.EventHandler(this.no7Button_Click);
            // 
            // no8Button
            // 
            this.no8Button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no8Button.Location = new System.Drawing.Point(59, 115);
            this.no8Button.Name = "no8Button";
            this.no8Button.Size = new System.Drawing.Size(50, 50);
            this.no8Button.TabIndex = 1;
            this.no8Button.Text = "8";
            this.no8Button.UseVisualStyleBackColor = true;
            this.no8Button.Click += new System.EventHandler(this.no8Button_Click);
            // 
            // no9Button
            // 
            this.no9Button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no9Button.Location = new System.Drawing.Point(115, 115);
            this.no9Button.Name = "no9Button";
            this.no9Button.Size = new System.Drawing.Size(50, 50);
            this.no9Button.TabIndex = 1;
            this.no9Button.Text = "9";
            this.no9Button.UseVisualStyleBackColor = true;
            this.no9Button.Click += new System.EventHandler(this.no9Button_Click);
            // 
            // no0Button
            // 
            this.no0Button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no0Button.Location = new System.Drawing.Point(59, 171);
            this.no0Button.Name = "no0Button";
            this.no0Button.Size = new System.Drawing.Size(50, 50);
            this.no0Button.TabIndex = 1;
            this.no0Button.Text = "0";
            this.no0Button.UseVisualStyleBackColor = true;
            this.no0Button.Click += new System.EventHandler(this.no0Button_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.backButton.Location = new System.Drawing.Point(3, 171);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.enterButton.Location = new System.Drawing.Point(115, 171);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(50, 50);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "OK";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.no1Button);
            this.panel1.Controls.Add(this.enterButton);
            this.panel1.Controls.Add(this.no2Button);
            this.panel1.Controls.Add(this.no0Button);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.no3Button);
            this.panel1.Controls.Add(this.no4Button);
            this.panel1.Controls.Add(this.no9Button);
            this.panel1.Controls.Add(this.no5Button);
            this.panel1.Controls.Add(this.no8Button);
            this.panel1.Controls.Add(this.no6Button);
            this.panel1.Controls.Add(this.no7Button);
            this.panel1.Location = new System.Drawing.Point(403, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 224);
            this.panel1.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(3, 3);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 2;
            // 
            // inputPanel
            // 
            this.inputPanel.AutoScroll = true;
            this.inputPanel.Controls.Add(this.resultLabel);
            this.inputPanel.Location = new System.Drawing.Point(19, 84);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(360, 224);
            this.inputPanel.TabIndex = 5;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 338);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayPanel);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.Text = "GuessNumber";
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label no4Label;
        private System.Windows.Forms.Label no3Label;
        private System.Windows.Forms.Label no2Label;
        private System.Windows.Forms.Label no1Label;
        private System.Windows.Forms.Button no1Button;
        private System.Windows.Forms.Button no2Button;
        private System.Windows.Forms.Button no3Button;
        private System.Windows.Forms.Button no4Button;
        private System.Windows.Forms.Button no5Button;
        private System.Windows.Forms.Button no6Button;
        private System.Windows.Forms.Button no7Button;
        private System.Windows.Forms.Button no8Button;
        private System.Windows.Forms.Button no9Button;
        private System.Windows.Forms.Button no0Button;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Panel inputPanel;
    }
}

