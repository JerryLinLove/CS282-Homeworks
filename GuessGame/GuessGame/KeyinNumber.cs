using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class KeyinNumber
    {
        private List<string> keyinData = new List<string>();

        //        public List<string> KeyinData { get => keyinData; set => keyinData = value; }
        public List<string> KeyinData
        {
            get => keyinData;
            set => this.keyinData.Add(value.ToString());
        }

        public int Length()
        {
            return (this.KeyinData.Count);
        }

        public bool checkDuplicate(string number)
        {
            int duplicateStatus = 0;
            if (this.KeyinData.Count > 0)
            {
                for (var index = 0; index < this.KeyinData.Count; index++)
                {
                    if (this.KeyinData[index] == number)
                    {
                        duplicateStatus = 1;
                    }
                }
            }

            if (duplicateStatus == 1)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}