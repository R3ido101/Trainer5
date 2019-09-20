namespace Trainer5
{
    partial class TeleportForm
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.fineXBox = new System.Windows.Forms.TextBox();
            this.fineXLabel = new System.Windows.Forms.Label();
            this.gridXBox = new System.Windows.Forms.TextBox();
            this.gridXLabel = new System.Windows.Forms.Label();
            this.fineYBox = new System.Windows.Forms.TextBox();
            this.fineYLabel = new System.Windows.Forms.Label();
            this.gridYBox = new System.Windows.Forms.TextBox();
            this.gridYLabel = new System.Windows.Forms.Label();
            this.teleportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(13, 13);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(251, 25);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Teleporting - XXXXXXXX";
            // 
            // fineXBox
            // 
            this.fineXBox.Location = new System.Drawing.Point(61, 58);
            this.fineXBox.Name = "fineXBox";
            this.fineXBox.Size = new System.Drawing.Size(271, 20);
            this.fineXBox.TabIndex = 1;
            // 
            // fineXLabel
            // 
            this.fineXLabel.AutoSize = true;
            this.fineXLabel.Location = new System.Drawing.Point(15, 61);
            this.fineXLabel.Name = "fineXLabel";
            this.fineXLabel.Size = new System.Drawing.Size(40, 13);
            this.fineXLabel.TabIndex = 2;
            this.fineXLabel.Text = "Fine X:";
            // 
            // gridXBox
            // 
            this.gridXBox.Location = new System.Drawing.Point(61, 85);
            this.gridXBox.Name = "gridXBox";
            this.gridXBox.Size = new System.Drawing.Size(271, 20);
            this.gridXBox.TabIndex = 1;
            // 
            // gridXLabel
            // 
            this.gridXLabel.AutoSize = true;
            this.gridXLabel.Location = new System.Drawing.Point(15, 88);
            this.gridXLabel.Name = "gridXLabel";
            this.gridXLabel.Size = new System.Drawing.Size(39, 13);
            this.gridXLabel.TabIndex = 2;
            this.gridXLabel.Text = "Grid X:";
            // 
            // fineYBox
            // 
            this.fineYBox.Location = new System.Drawing.Point(61, 111);
            this.fineYBox.Name = "fineYBox";
            this.fineYBox.Size = new System.Drawing.Size(271, 20);
            this.fineYBox.TabIndex = 1;
            // 
            // fineYLabel
            // 
            this.fineYLabel.AutoSize = true;
            this.fineYLabel.Location = new System.Drawing.Point(15, 114);
            this.fineYLabel.Name = "fineYLabel";
            this.fineYLabel.Size = new System.Drawing.Size(40, 13);
            this.fineYLabel.TabIndex = 2;
            this.fineYLabel.Text = "Fine Y:";
            // 
            // gridYBox
            // 
            this.gridYBox.Location = new System.Drawing.Point(61, 137);
            this.gridYBox.Name = "gridYBox";
            this.gridYBox.Size = new System.Drawing.Size(271, 20);
            this.gridYBox.TabIndex = 1;
            // 
            // gridYLabel
            // 
            this.gridYLabel.AutoSize = true;
            this.gridYLabel.Location = new System.Drawing.Point(15, 140);
            this.gridYLabel.Name = "gridYLabel";
            this.gridYLabel.Size = new System.Drawing.Size(39, 13);
            this.gridYLabel.TabIndex = 2;
            this.gridYLabel.Text = "Grid Y:";
            // 
            // teleportButton
            // 
            this.teleportButton.BackColor = System.Drawing.Color.Black;
            this.teleportButton.Location = new System.Drawing.Point(257, 175);
            this.teleportButton.Name = "teleportButton";
            this.teleportButton.Size = new System.Drawing.Size(75, 23);
            this.teleportButton.TabIndex = 3;
            this.teleportButton.Text = "Teleport";
            this.teleportButton.UseVisualStyleBackColor = false;
            this.teleportButton.Click += new System.EventHandler(this.TeleportButton_Click);
            // 
            // TeleportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(344, 210);
            this.Controls.Add(this.teleportButton);
            this.Controls.Add(this.gridYLabel);
            this.Controls.Add(this.fineYLabel);
            this.Controls.Add(this.gridXLabel);
            this.Controls.Add(this.gridYBox);
            this.Controls.Add(this.fineYBox);
            this.Controls.Add(this.gridXBox);
            this.Controls.Add(this.fineXLabel);
            this.Controls.Add(this.fineXBox);
            this.Controls.Add(this.statusLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TeleportForm";
            this.Text = "TeleportForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TeleportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox fineXBox;
        private System.Windows.Forms.Label fineXLabel;
        private System.Windows.Forms.TextBox gridXBox;
        private System.Windows.Forms.Label gridXLabel;
        private System.Windows.Forms.TextBox fineYBox;
        private System.Windows.Forms.Label fineYLabel;
        private System.Windows.Forms.TextBox gridYBox;
        private System.Windows.Forms.Label gridYLabel;
        private System.Windows.Forms.Button teleportButton;
    }
}