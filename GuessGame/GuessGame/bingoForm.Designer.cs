namespace GuessABGame
{
    partial class bingoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.completeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.completeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.completeLabel);
            this.panel1.Location = new System.Drawing.Point(80, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 93);
            this.panel1.TabIndex = 0;
            // 
            // completeLabel
            // 
            this.completeLabel.AutoSize = true;
            this.completeLabel.Location = new System.Drawing.Point(2, 0);
            this.completeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.completeLabel.Name = "completeLabel";
            this.completeLabel.Size = new System.Drawing.Size(0, 20);
            this.completeLabel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.completeButton);
            this.panel2.Location = new System.Drawing.Point(41, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 41);
            this.panel2.TabIndex = 1;
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(55, 3);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(75, 32);
            this.completeButton.TabIndex = 1;
            this.completeButton.Text = "確定";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // bingoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 199);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "bingoForm";
            this.Text = "Bingo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label completeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button completeButton;
    }
}