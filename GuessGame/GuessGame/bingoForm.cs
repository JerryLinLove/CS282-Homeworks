using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessABGame
{
    public partial class bingoForm : Form
    {
        private int dataInt;
        public int DataInt { set => dataInt = value; }

        public bingoForm()
        {
            InitializeComponent();
            completeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public void ShowCount()
        {
            this.completeLabel.Text = "恭喜，猜對了";
            this.completeLabel.Text += Environment.NewLine;
            completeLabel.Text += "總共猜 " + this.dataInt.ToString() + " 次";
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}