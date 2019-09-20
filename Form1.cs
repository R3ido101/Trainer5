using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainer5
{
    public partial class Form1 : Form
    {
        float rainbowProgress;
        BackgroundWorker rainbowWorker = new BackgroundWorker();
        public Mem memlib = new Mem();
        public List<int> lgbtTowers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void hookGame()
        {
            if(MessageBox.Show("This program is constantly scanning BTD5's memory in the background. This can hog CPU. Click 'Ok' to hook Bloons TD 5", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) { return; } 
            try
            {
                memlib.OpenProcess("BTD5-Win");
                towerScanner.startScanners(memlib);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to inject into game (is it running?) (do you have admin?) (Is this the right version?)");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hookGame();
            rainbowWorker.DoWork += rainbows;
            rainbowWorker.RunWorkerAsync();
        }

        //Rainbow stuff
        //Write rainbow
        private void rainbows(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                rainbowProgress += 0.01F;
                Thread.Sleep(5);
                if (lgbtHoverBox.Checked)
                {
                    int hoveredTowers = towerScanner.getHoveredTower();
                    if (hoveredTowers != 0)
                    {
                        int towerRed = hoveredTowers + 0x108;
                        int towerGreen = hoveredTowers + 0x109;
                        int towerBlue = hoveredTowers + 0x10A;
                        memlib.writeMemory(towerRed.ToString("X"), "byte", Rainbow(rainbowProgress).R.ToString("X"));
                        memlib.writeMemory(towerGreen.ToString("X"), "byte", Rainbow(rainbowProgress).G.ToString("X"));
                        memlib.writeMemory(towerBlue.ToString("X"), "byte", Rainbow(rainbowProgress).B.ToString("X"));
                    }
                }
                if (lgbtTowers.Count > 0)
                {
                    foreach (int tower in lgbtTowers)
                    {
                        int toRead = tower + 0x12C;
                        int towerRed = tower + 0x108;
                        int towerGreen = tower + 0x109;
                        int towerBlue = tower + 0x10A;
                        memlib.writeMemory(towerRed.ToString("X"), "byte", Rainbow(rainbowProgress).R.ToString("X"));
                        memlib.writeMemory(towerGreen.ToString("X"), "byte", Rainbow(rainbowProgress).G.ToString("X"));
                        memlib.writeMemory(towerBlue.ToString("X"), "byte", Rainbow(rainbowProgress).B.ToString("X"));
                    }
                }
                if(lgbtHoverBox.Checked)
                {
                    foreach (int cachedHovered in towerScanner.hoveredCache)
                    {
                        int hoverTower = cachedHovered + 0x215;
                        if (!lgbtTowers.Contains(hoverTower))
                        {
                            int hoverCheck = memlib.readByte(hoverTower.ToString("X"));
                            if (hoverCheck < 1)
                            {
                                int towerRed = cachedHovered + 0x108;
                                int towerGreen = cachedHovered + 0x109;
                                int towerBlue = cachedHovered + 0x10A;
                                memlib.writeMemory(towerRed.ToString("X"), "byte", "0xFF");
                                memlib.writeMemory(towerGreen.ToString("X"), "byte", "0xFF");
                                memlib.writeMemory(towerBlue.ToString("X"), "byte", "0xFF");
                            }
                        }
                    }
                }
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
                if (!memlib.writeMemory("BTD5-Win.exe+008844B0,0xC4,0x90", "double", value.ToString()))
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
                if (!memlib.writeMemory("BTD5-Win.exe+008844B0,0xD4,0x18,0x0,0x58,0x118", "int", value.ToString()))
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
                if (!memlib.writeMemory("BTD5-Win.exe+00884274,0x5C,0xC8,0x88", "int", value.ToString()))
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
                if (!memlib.writeMemory("BTD5-Win.exe+008844B0,0xD4,0x18,0x0,0x58,0x120", "int", value.ToString()))
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
                    if (!memlib.writeMemory("BTD5-Win.exe+2452E1", "int", "952012031"))
                    {
                        MessageBox.Show("Failed to write to game!");
                    }
                }
                else
                {
                    if (!memlib.writeMemory("BTD5-Win.exe+2452E1", "int", "952009983"))
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
                if (!memlib.writeMemory("BTD5-Win.exe+008844B0,0xF0,0x0,0xC4,0x20", "int", value.ToString()))
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
                if (!memlib.writeMemory("BTD5-Win.exe+008844B0,0xD4,0x18,0x0,0x58,0x28", "double", value.ToString()))
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
                if (!memlib.writeMemory("BTD5-Win.exe+008844B0,0xC0,0x250,0x8,0x80,0x14", "int", value.ToString()))
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
            try
            {
                foreach(int selected in towerScanner.selectedTowers)
                {
                    if (!lgbtTowers.Contains(selected))
                    {
                        lgbtTowers.Add(selected);
                    }
                    Clipboard.SetText(lgbtTowers[0].ToString("X"));
                }
            } catch (ArgumentOutOfRangeException) { }
        }

        private void CopySelectedButton_Click(object sender, EventArgs e)
        {
            int count = towerScanner.selectedTowers.Count;
            if(count > 0)
            {
                Clipboard.SetText(towerScanner.selectedTowers.Last().ToString("X"));
            }
        }

        private void colorResetButton_Click(object sender, EventArgs e)
        {
            foreach(int tower in towerScanner.selectedTowers)
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

        private void TeleportButton_Click(object sender, EventArgs e)
        {
            try
            {
                TeleportForm tpf = new TeleportForm(towerScanner.selectedTowers.Last(), memlib);
                tpf.Show();
            }
            catch (InvalidOperationException) { }
        }

        private void FixSelsButton_Click(object sender, EventArgs e)
        {
            foreach(int tower in towerScanner.selectedTowers)
            {
                int towerSel = tower + 0xF0;
                memlib.writeMemory(towerSel.ToString("X"), "byte", "0x0");
            }
        }

        private void BetterTextBox_CheckedChanged(object sender, EventArgs e)
        {
            if(betterTextBox.Checked)
            {
                //Change co-op text
                List<long> coop = memlib.AoBScan("43 6F 2D 6F 70 00 00 00 00 00 00 00 00 00 00 00 05 00 00 00", true, true).Result.ToList();
                if (coop.Count > 0)
                {
                    memlib.writeMemory("0x" + coop[0].ToString("X"), "bytes", "0x44 0x6F 0x6E 0x27 0x74 0x20 0x62 0x65 0x20 0x73 0x63 0x75 0x6D 0x00 0x00 0x00 0x0D");
                }

                //Change new game text
                List<long> ng = memlib.AoBScan("4E 65 77 0A 47 61 6D 65 00 00 00 00 00 00 00 00 08", true, true).Result.ToList();
                if (ng.Count > 0)
                {
                    memlib.writeMemory("0x" + ng[0].ToString("X"), "bytes", "0x53 0x65 0x6E 0x64 0x0A 0x4E 0x75 0x64 0x65 0x73 0x00 0x00 0x00 0x00 0x00 0x00 0x0A");
                }

                //Change odessy text
                List<long> odessy = memlib.AoBScan("4F 64 79 73 73 65 79 00 00 00 00 00 00 00 00 00 07", true, true).Result.ToList();
                if (odessy.Count > 0)
                {
                    memlib.writeMemory("0x" + odessy[0].ToString("X"), "bytes", "0x4E 0x6F 0x74 0x0A 0x4D 0x61 0x72 0x69 0x6F 0x0A 0x4F 0x64 0x79 0x73 0x73 0x65 0x79 0x0A");
                }
            } else
            {
                //Change co-op text
                List<long> coop = memlib.AoBScan("44 6F 6E 27 74 20 62 65 20 73 63 75 6D 00 00 00 0D", true, true).Result.ToList();
                if (coop.Count > 0)
                {
                    memlib.writeMemory("0x" + coop[0].ToString("X"), "bytes", "0x43 0x6F 0x2D 0x6F 0x70 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x05");
                }

                //Change new game text
                List<long> ng = memlib.AoBScan("53 65 6E 64 0A 4E 75 64 65 73 00 00 00 00 00 00 0A", true, true).Result.ToList();
                if (ng.Count > 0)
                {
                    memlib.writeMemory("0x" + ng[0].ToString("X"), "bytes", "0x4E 0x65 0x77 0x0A 0x47 0x61 0x6D 0x65 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x08");
                }

                //Change odessy text
                List<long> odessy = memlib.AoBScan("4E 6F 74 0A 4D 61 72 69 6F 0A 4F 64 79 73 73 65 79 0A", true, true).Result.ToList();
                if (odessy.Count > 0)
                {
                    memlib.writeMemory("0x" + odessy[0].ToString("X"), "bytes", "0x4F 0x64 0x79 0x73 0x73 0x65 0x79 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x07A 0x0");
                }
            }
        }
    }
}
