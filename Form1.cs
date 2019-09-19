using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainer5
{
    public partial class Form1 : Form
    {
        float rainbowProgress;
        public Mem memlib = new Mem();
        public List<int> lgbtTowers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void hookGame()
        {
            try
            {
                memlib.OpenProcess("BTD5-Win");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to inject into game (is it running?) (do you have admin?)");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hookGame();
            Timer lgbtTimer = new Timer();
            lgbtTimer.Tick += rainbows;
            lgbtTimer.Interval = 50;
            lgbtTimer.Start();
        }

        //Rainbow stuff
        //Write rainbow
        private void rainbows(object sender, EventArgs e)
        {
            if(lgbtTowers.Count < 0)
            {
                return;
            }
            foreach(int tower in lgbtTowers)
            {
                int toRead = tower + 0x12C;
                Random rand = new Random();
                int towerRed = tower + 0x108;
                int towerGreen = tower + 0x109;
                int towerBlue = tower + 0x10A;
                memlib.writeMemory(towerRed.ToString("X"), "byte", Rainbow(rainbowProgress).R.ToString("X"));
                memlib.writeMemory(towerGreen.ToString("X"), "byte", Rainbow(rainbowProgress).G.ToString("X"));
                memlib.writeMemory(towerBlue.ToString("X"), "byte", Rainbow(rainbowProgress).B.ToString("X"));
                rainbowProgress += 0.01F;
            }
        }
        //Color gen
        public static Color Rainbow(float progress)
        {
            float div = (Math.Abs(progress % 1) * 6);
            int ascending = (int)((div % 1) * 255);
            int descending = 255 - ascending;

            switch ((int)div)
            {
                case 0:
                    return Color.FromArgb(255, 255, ascending, 0);
                case 1:
                    return Color.FromArgb(255, descending, 255, 0);
                case 2:
                    return Color.FromArgb(255, 0, 255, ascending);
                case 3:
                    return Color.FromArgb(255, 0, descending, 255);
                case 4:
                    return Color.FromArgb(255, ascending, 0, 255);
                default: // case 5:
                    return Color.FromArgb(255, 255, 0, descending);
            }
        }

        private void HookGameButton_Click(object sender, EventArgs e)
        {
            hookGame();
        }

        private void SetMoneyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Int32.Parse(moneyBox.Text);
                if (memlib.writeMemory("BTD5-Win.exe+008844B0,0xC4,0x90", "double", value.ToString()))
                {
                }
                else
                {
                    MessageBox.Show("Failed to write to game!");
                }
            }
            catch (Exception)
            {
            }
        }

        private void SetMonkeyMoneyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Int32.Parse(monkeyMoneyBox.Text);
                if (memlib.writeMemory("BTD5-Win.exe+008844B0,0xD4,0x18,0x0,0x58,0x118", "int", value.ToString()))
                {
                }
                else
                {
                    MessageBox.Show("Failed to write to game!");
                }
            }
            catch (Exception)
            {
            }
        }

        private void SetHealthButton_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Int32.Parse(healthBox.Text);
                if (memlib.writeMemory("BTD5-Win.exe+00884274,0x5C,0xC8,0x88", "int", value.ToString()))
                {
                }
                else
                {
                    MessageBox.Show("Failed to write to game!");
                }
            }
            catch (Exception)
            {
            }
        }

        private void SetTokensButton_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Int32.Parse(tokenBox.Text);
                if (memlib.writeMemory("BTD5-Win.exe+008844B0,0xD4,0x18,0x0,0x58,0x120", "int", value.ToString()))
                {
                }
                else
                {
                    MessageBox.Show("Failed to write to game!");
                }
            }
            catch (Exception)
            {
            }
        }

        private void downgradeCheckChanged(object sender, EventArgs e)
        {
            try
            {
                if(DowngradeCheckbox.Checked)
                {
                    if (memlib.writeMemory("BTD5-Win.exe+2452E1", "int", "952012031"))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Failed to write to game!");
                    }
                }
                else
                {
                    if (memlib.writeMemory("BTD5-Win.exe+2452E1", "int", "952009983"))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Failed to write to game!");
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void SetRankButton_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Int32.Parse(rankBox.Text);
                if (memlib.writeMemory("BTD5-Win.exe+008844B0,0xF0,0x0,0xC4,0x20", "int", value.ToString()))
                {
                }
                else
                {
                    MessageBox.Show("Failed to write to game!");
                }
            }
            catch (Exception)
            {
            }
        }

        private void SetXpButton_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Int32.Parse(xpBox.Text);
                if (memlib.writeMemory("BTD5-Win.exe+008844B0,0xD4,0x18,0x0,0x58,0x28", "double", value.ToString()))
                {
                }
                else
                {
                    MessageBox.Show("Failed to write to game!");
                }
            }
            catch (Exception)
            {
            }
        }

        private void SetRoundButton_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Int32.Parse(roundBox.Text);
                if (memlib.writeMemory("BTD5-Win.exe+008844B0,0xC0,0x250,0x8,0x80,0x14", "int", value.ToString()))
                {
                }
                else
                {
                    MessageBox.Show("Failed to write to game!");
                }
            }
            catch (Exception)
            {
            }
        }

        private void lgbtButton_Click(object sender, EventArgs e)
        {
            lgbtTowers.AddRange(getSelectedTowers());
            Clipboard.SetText(lgbtTowers[0].ToString("X"));
        }

        public List<int> getSelectedTowers()
        {
            List<long> scanResult = memlib.AoBScan("01 01 00 01 01 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ??", true, true).Result.ToList();
            List<int> returnResult = new List<int>();
            foreach (long result in scanResult)
            {
                try
                {
                    int baseV = (int)result & int.MaxValue;
                    string hexS = baseV.ToString("X");
                    int hexI = int.Parse(hexS, System.Globalization.NumberStyles.HexNumber);
                    hexI -= 0xF0;
                    int soldCheck = hexI+0x12C;
                    if(memlib.readByte(soldCheck.ToString("X")) < 1) {
                        returnResult.Add(hexI);
                    }
                }
                catch (OverflowException) { }
            }
            return returnResult;
        }
        public List<int> getAllTowers()
        {
            List<long> scanResult = memlib.AoBScan("01 01 00 01 01 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ??", true, true).Result.ToList();
            List<int> returnResult = new List<int>();
            foreach (long result in scanResult)
            {
                try
                {
                    int baseV = (int)result & int.MaxValue;
                    string hexS = baseV.ToString("X");
                    int hexI = int.Parse(hexS, System.Globalization.NumberStyles.HexNumber);
                    hexI -= 0xF0;
                    int soldCheck = hexI + 0x12C;
                    if (memlib.readByte(soldCheck.ToString("X")) < 1)
                    {
                        returnResult.Add(hexI);
                    }
                }
                catch (OverflowException) { }
            }
            return returnResult;
        }

        private void CopySelectedButton_Click(object sender, EventArgs e)
        {
            int count = getSelectedTowers().Count;
            if(count > 0)
            {
                Clipboard.SetText(getSelectedTowers().Last().ToString("X"));
            }
        }

        private void colorResetButton_Click(object sender, EventArgs e)
        {
            foreach(int tower in getSelectedTowers())
            {
                lgbtTowers.Remove(tower);
                int towerRed = tower + 0x108;
                int towerGreen = tower + 0x109;
                int towerBlue = tower + 0x10A;
                memlib.writeMemory(towerRed.ToString("X"), "byte", "0xFF");
                memlib.writeMemory(towerGreen.ToString("X"), "byte", "0xFF");
                memlib.writeMemory(towerBlue.ToString("X"), "byte", "0xFF");
            }
        }
    }
}
