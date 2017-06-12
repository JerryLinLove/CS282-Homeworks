using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyMathLibrary;

namespace GuessABGame
{
    public partial class mainForm : Form
    {
        private bingoForm bingoForm = new bingoForm();

        public mainForm()
        {
            InitializeComponent();
            PcSelect();
        }

        private void PcSelect()
        {
            //=== 取得PC所產生的數字 (pcSelectNumber[])===//
            RandomGenerator random = new RandomGenerator();

            List<string> numbers = new List<string>();

            for (int index = 0; index < 10; index++)
                numbers.Add(index.ToString());
            for (int count = 1; count <= 4; count++)
            {
                int index = random.Next(0, numbers.Count);
                pcSelectNumber.Add(numbers[index]);
                numbers.Remove(numbers[index]);
            }
        }

        private List<string> pcSelectNumber = new List<string>();

        private List<string> keyinNumber = new List<string>();

        private void no1Button_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count < 4)
            {
                if (checkDuplicate("1") == false)
                {
                    keyinNumber.Add("1");
                    ShowNumber();
                }
            }
        }

        private void no2Button_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count < 4)
            {
                if (checkDuplicate("2") == false)
                {
                    keyinNumber.Add("2");
                    ShowNumber();
                }
            }
        }

        private void no3Button_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count < 4)
            {
                if (checkDuplicate("3") == false)
                {
                    keyinNumber.Add("3");
                    ShowNumber();
                }
            }
        }

        private void no4Button_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count < 4)
            {
                if (checkDuplicate("4") == false)
                {
                    keyinNumber.Add("4");
                    ShowNumber();
                }
            }
        }

        private void no5Button_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count < 4)
            {
                if (checkDuplicate("5") == false)
                {
                    keyinNumber.Add("5");
                    ShowNumber();
                }
            }
        }

        private void no6Button_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count < 4)
            {
                if (checkDuplicate("6") == false)
                {
                    keyinNumber.Add("6");
                    ShowNumber();
                }
            }
        }

        private void no7Button_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count < 4)
            {
                if (checkDuplicate("7") == false)
                {
                    keyinNumber.Add("7");
                    ShowNumber();
                }
            }
        }

        private void no8Button_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count < 4)
            {
                if (checkDuplicate("8") == false)
                {
                    keyinNumber.Add("8");
                    ShowNumber();
                }
            }
        }

        private void no9Button_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count < 4)
            {
                if (checkDuplicate("9") == false)
                {
                    keyinNumber.Add("9");
                    ShowNumber();
                }
            }
        }

        private void no0Button_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count < 4)
            {
                if (checkDuplicate("0") == false)
                {
                    keyinNumber.Add("0");
                    ShowNumber();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count > 0)
            {
                keyinNumber.Remove(keyinNumber[(keyinNumber.Count - 1)]);
            }
            ShowNumber();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (keyinNumber.Count >= 4)
            {
                int resultA, resultB;
                resultA = checkA();
                resultB = checkB();
                guessCount++;
                ShowResult(resultA, resultB, guessCount);
                keyinNumber.RemoveAll(it => true);
                ShowNumber();
                if (resultA == 4)
                {
                    this.bingoForm.DataInt = guessCount;
                    this.bingoForm.ShowCount();
                    bingoForm.ShowDialog(this);

                    if (bingoForm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                    {
                        //若使用者在bingoForm按下了Cancel或者直接點選X關閉視窗，都會進入這個判斷式
                        bingoForm.Dispose();
                        this.Close();
                    }
                }
            }
        }

        private void ShowNumber()
        {
            if (keyinNumber.Count == 0)
            {
                no1Label.Text = "-";
                no2Label.Text = "-";
                no3Label.Text = "-";
                no4Label.Text = "-";
            }
            else if (keyinNumber.Count == 1)
            {
                no1Label.Text = keyinNumber[0];
                no2Label.Text = "-";
                no3Label.Text = "-";
                no4Label.Text = "-";
            }
            else if (keyinNumber.Count == 2)
            {
                no1Label.Text = keyinNumber[0];
                no2Label.Text = keyinNumber[1];
                no3Label.Text = "-";
                no4Label.Text = "-";
            }
            else if (keyinNumber.Count == 3)
            {
                no1Label.Text = keyinNumber[0];
                no2Label.Text = keyinNumber[1];
                no3Label.Text = keyinNumber[2];
                no4Label.Text = "-";
            }
            else if (keyinNumber.Count == 4)
            {
                no1Label.Text = keyinNumber[0];
                no2Label.Text = keyinNumber[1];
                no3Label.Text = keyinNumber[2];
                no4Label.Text = keyinNumber[3];
            }
        }

        private int guessCount = 0;

        public int GuessCount { get => guessCount; }

        private void ShowResult(int a, int b, int r)
        {
            resultLabel.Text += "第 " + r.ToString() + " 次 ==> 輸入 : " +
                keyinNumber[0] + keyinNumber[1] + keyinNumber[2] + keyinNumber[3] + " ,結果 ==> " +
                a.ToString() + "A" +
                b.ToString() + "B";
            resultLabel.Text += Environment.NewLine;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
        }

        private bool checkDuplicate(string number)
        {
            bool duplicateStatus = false;
            if (this.keyinNumber.Count > 0)
            {
                for (var index = 0; index < this.keyinNumber.Count; index++)
                {
                    if (this.keyinNumber[index] == number)
                    {
                        duplicateStatus = true;
                    }
                }
            }
            return (duplicateStatus);
        }

        private int checkA()
        {
            int countA = 0;

            for (var index = 0; index < 4; index++)
            {
                if (keyinNumber[index] == pcSelectNumber[index])
                    countA++;
            }
            return (countA);
        }

        private int checkB()
        {
            int countB = 0;

            if (keyinNumber[0] == pcSelectNumber[1])
                countB++;
            if (keyinNumber[0] == pcSelectNumber[2])
                countB++;
            if (keyinNumber[0] == pcSelectNumber[3])
                countB++;
            if (keyinNumber[1] == pcSelectNumber[0])
                countB++;
            if (keyinNumber[1] == pcSelectNumber[2])
                countB++;
            if (keyinNumber[1] == pcSelectNumber[3])
                countB++;
            if (keyinNumber[2] == pcSelectNumber[0])
                countB++;
            if (keyinNumber[2] == pcSelectNumber[1])
                countB++;
            if (keyinNumber[2] == pcSelectNumber[3])
                countB++;
            if (keyinNumber[3] == pcSelectNumber[0])
                countB++;
            if (keyinNumber[3] == pcSelectNumber[1])
                countB++;
            if (keyinNumber[3] == pcSelectNumber[2])
                countB++;
            return (countB);
        }
    }
}