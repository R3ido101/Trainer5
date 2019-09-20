using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainer5
{
    public partial class TeleportForm : Form
    {
        int address = 0;
        Mem memlib;
        public TeleportForm(int address, Mem memlib)
        {
            InitializeComponent();
            this.address = address;
            this.memlib = memlib;
        }

        private void TeleportForm_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "Teleporting - " + address.ToString("X");
            int fineXByte = address + 0x92;
            int gridXByte = address + 0x96;
            int fineYByte = address + 0x93;
            int gridYByte = address + 0x97;
            int fineX = memlib.readByte(fineXByte.ToString("X"));
            int gridX = memlib.readByte(gridXByte.ToString("X"));
            int fineY = memlib.readByte(fineYByte.ToString("X"));
            int gridY = memlib.readByte(gridYByte.ToString("X"));
            fineXBox.Text = fineX.ToString();
            gridXBox.Text = gridX.ToString();
            fineYBox.Text = fineY.ToString();
            gridYBox.Text = gridY.ToString();
        }

        private void TeleportButton_Click(object sender, EventArgs e)
        {
            int fineX = int.Parse(fineXBox.Text);
            int gridX = int.Parse(gridXBox.Text);
            int fineY = int.Parse(fineYBox.Text);
            int gridY = int.Parse(gridYBox.Text);
            int fineXByte = address + 0x92;
            int gridXByte = address + 0x96;
            int fineYByte = address + 0x93;
            int gridYByte = address + 0x97;
            if(fineX > 255 | gridX > 255 | fineY > 255 | gridY > 255)
            {
                MessageBox.Show("Maximum input value is 255!");
                return;
            }
            memlib.writeMemory(fineXByte.ToString("X"), "byte", fineX.ToString("X"));
            memlib.writeMemory(gridXByte.ToString("X"), "byte", gridX.ToString("X"));
            memlib.writeMemory(fineYByte.ToString("X"), "byte", fineY.ToString("X"));
            memlib.writeMemory(gridYByte.ToString("X"), "byte", gridY.ToString("X"));
        }
    }
}
