namespace Trainer5
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.setMoneyButton = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Label();
            this.monkeyMoneyLabel = new System.Windows.Forms.Label();
            this.monkeyMoneyBox = new System.Windows.Forms.TextBox();
            this.setMonkeyMoney = new System.Windows.Forms.Button();
            this.healthLabel = new System.Windows.Forms.Label();
            this.healthBox = new System.Windows.Forms.TextBox();
            this.setHealthBox = new System.Windows.Forms.Button();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.setTokensButton = new System.Windows.Forms.Button();
            this.DowngradeCheckbox = new System.Windows.Forms.CheckBox();
            this.rankLabel = new System.Windows.Forms.Label();
            this.rankBox = new System.Windows.Forms.TextBox();
            this.setRankButton = new System.Windows.Forms.Button();
            this.xpLabel = new System.Windows.Forms.Label();
            this.xpBox = new System.Windows.Forms.TextBox();
            this.setXpBox = new System.Windows.Forms.Button();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundBox = new System.Windows.Forms.TextBox();
            this.setRoundButton = new System.Windows.Forms.Button();
            this.hookGameButton = new System.Windows.Forms.Button();
            this.gameVerLabel = new System.Windows.Forms.Label();
            this.lgbtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Poplar Std", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(161, 57);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Trainer5";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.Color.White;
            this.moneyLabel.Location = new System.Drawing.Point(23, 72);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(130, 20);
            this.moneyLabel.TabIndex = 1;
            this.moneyLabel.Text = "In Game Money: ";
            // 
            // moneyBox
            // 
            this.moneyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyBox.Location = new System.Drawing.Point(159, 72);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(210, 20);
            this.moneyBox.TabIndex = 2;
            this.moneyBox.Text = "0";
            // 
            // setMoneyButton
            // 
            this.setMoneyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setMoneyButton.Location = new System.Drawing.Point(386, 70);
            this.setMoneyButton.Name = "setMoneyButton";
            this.setMoneyButton.Size = new System.Drawing.Size(75, 23);
            this.setMoneyButton.TabIndex = 3;
            this.setMoneyButton.Text = "set";
            this.setMoneyButton.UseVisualStyleBackColor = true;
            this.setMoneyButton.Click += new System.EventHandler(this.SetMoneyButton_Click);
            // 
            // credits
            // 
            this.credits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.ForeColor = System.Drawing.Color.White;
            this.credits.Location = new System.Drawing.Point(10, 417);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(241, 25);
            this.credits.TabIndex = 4;
            this.credits.Text = "Made by DisabledMallis";
            // 
            // monkeyMoneyLabel
            // 
            this.monkeyMoneyLabel.AutoSize = true;
            this.monkeyMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monkeyMoneyLabel.ForeColor = System.Drawing.Color.White;
            this.monkeyMoneyLabel.Location = new System.Drawing.Point(23, 105);
            this.monkeyMoneyLabel.Name = "monkeyMoneyLabel";
            this.monkeyMoneyLabel.Size = new System.Drawing.Size(123, 20);
            this.monkeyMoneyLabel.TabIndex = 1;
            this.monkeyMoneyLabel.Text = "Monkey Money: ";
            // 
            // monkeyMoneyBox
            // 
            this.monkeyMoneyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monkeyMoneyBox.Location = new System.Drawing.Point(159, 105);
            this.monkeyMoneyBox.Name = "monkeyMoneyBox";
            this.monkeyMoneyBox.Size = new System.Drawing.Size(210, 20);
            this.monkeyMoneyBox.TabIndex = 2;
            this.monkeyMoneyBox.Text = "0";
            // 
            // setMonkeyMoney
            // 
            this.setMonkeyMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setMonkeyMoney.Location = new System.Drawing.Point(386, 104);
            this.setMonkeyMoney.Name = "setMonkeyMoney";
            this.setMonkeyMoney.Size = new System.Drawing.Size(75, 23);
            this.setMonkeyMoney.TabIndex = 3;
            this.setMonkeyMoney.Text = "set";
            this.setMonkeyMoney.UseVisualStyleBackColor = true;
            this.setMonkeyMoney.Click += new System.EventHandler(this.SetMonkeyMoneyButton_Click);
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(23, 139);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(64, 20);
            this.healthLabel.TabIndex = 1;
            this.healthLabel.Text = "Health: ";
            // 
            // healthBox
            // 
            this.healthBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.healthBox.Location = new System.Drawing.Point(159, 139);
            this.healthBox.Name = "healthBox";
            this.healthBox.Size = new System.Drawing.Size(210, 20);
            this.healthBox.TabIndex = 2;
            this.healthBox.Text = "0";
            // 
            // setHealthBox
            // 
            this.setHealthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setHealthBox.Location = new System.Drawing.Point(386, 138);
            this.setHealthBox.Name = "setHealthBox";
            this.setHealthBox.Size = new System.Drawing.Size(75, 23);
            this.setHealthBox.TabIndex = 3;
            this.setHealthBox.Text = "set";
            this.setHealthBox.UseVisualStyleBackColor = true;
            this.setHealthBox.Click += new System.EventHandler(this.SetHealthButton_Click);
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenLabel.ForeColor = System.Drawing.Color.White;
            this.tokenLabel.Location = new System.Drawing.Point(23, 175);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(69, 20);
            this.tokenLabel.TabIndex = 1;
            this.tokenLabel.Text = "Tokens: ";
            // 
            // tokenBox
            // 
            this.tokenBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenBox.Location = new System.Drawing.Point(159, 175);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(210, 20);
            this.tokenBox.TabIndex = 2;
            this.tokenBox.Text = "0";
            // 
            // setTokensButton
            // 
            this.setTokensButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setTokensButton.Location = new System.Drawing.Point(386, 174);
            this.setTokensButton.Name = "setTokensButton";
            this.setTokensButton.Size = new System.Drawing.Size(75, 23);
            this.setTokensButton.TabIndex = 3;
            this.setTokensButton.Text = "set";
            this.setTokensButton.UseVisualStyleBackColor = true;
            this.setTokensButton.Click += new System.EventHandler(this.SetTokensButton_Click);
            // 
            // DowngradeCheckbox
            // 
            this.DowngradeCheckbox.AutoSize = true;
            this.DowngradeCheckbox.ForeColor = System.Drawing.Color.White;
            this.DowngradeCheckbox.Location = new System.Drawing.Point(180, 12);
            this.DowngradeCheckbox.Name = "DowngradeCheckbox";
            this.DowngradeCheckbox.Size = new System.Drawing.Size(119, 17);
            this.DowngradeCheckbox.TabIndex = 5;
            this.DowngradeCheckbox.Text = "Downgrade Towers";
            this.DowngradeCheckbox.UseVisualStyleBackColor = true;
            this.DowngradeCheckbox.CheckStateChanged += new System.EventHandler(this.downgradeCheckChanged);
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankLabel.ForeColor = System.Drawing.Color.White;
            this.rankLabel.Location = new System.Drawing.Point(23, 210);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(55, 20);
            this.rankLabel.TabIndex = 1;
            this.rankLabel.Text = "Rank: ";
            // 
            // rankBox
            // 
            this.rankBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rankBox.Location = new System.Drawing.Point(159, 210);
            this.rankBox.Name = "rankBox";
            this.rankBox.Size = new System.Drawing.Size(210, 20);
            this.rankBox.TabIndex = 2;
            this.rankBox.Text = "0";
            // 
            // setRankButton
            // 
            this.setRankButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setRankButton.Location = new System.Drawing.Point(386, 209);
            this.setRankButton.Name = "setRankButton";
            this.setRankButton.Size = new System.Drawing.Size(75, 23);
            this.setRankButton.TabIndex = 3;
            this.setRankButton.Text = "set";
            this.setRankButton.UseVisualStyleBackColor = true;
            this.setRankButton.Click += new System.EventHandler(this.SetRankButton_Click);
            // 
            // xpLabel
            // 
            this.xpLabel.AutoSize = true;
            this.xpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpLabel.ForeColor = System.Drawing.Color.White;
            this.xpLabel.Location = new System.Drawing.Point(23, 246);
            this.xpLabel.Name = "xpLabel";
            this.xpLabel.Size = new System.Drawing.Size(38, 20);
            this.xpLabel.TabIndex = 1;
            this.xpLabel.Text = "XP: ";
            // 
            // xpBox
            // 
            this.xpBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xpBox.Location = new System.Drawing.Point(159, 246);
            this.xpBox.Name = "xpBox";
            this.xpBox.Size = new System.Drawing.Size(210, 20);
            this.xpBox.TabIndex = 2;
            this.xpBox.Text = "0";
            // 
            // setXpBox
            // 
            this.setXpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setXpBox.Location = new System.Drawing.Point(386, 245);
            this.setXpBox.Name = "setXpBox";
            this.setXpBox.Size = new System.Drawing.Size(75, 23);
            this.setXpBox.TabIndex = 3;
            this.setXpBox.Text = "set";
            this.setXpBox.UseVisualStyleBackColor = true;
            this.setXpBox.Click += new System.EventHandler(this.SetXpButton_Click);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.White;
            this.roundLabel.Location = new System.Drawing.Point(23, 280);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(65, 20);
            this.roundLabel.TabIndex = 1;
            this.roundLabel.Text = "Round: ";
            // 
            // roundBox
            // 
            this.roundBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundBox.Location = new System.Drawing.Point(159, 280);
            this.roundBox.Name = "roundBox";
            this.roundBox.Size = new System.Drawing.Size(210, 20);
            this.roundBox.TabIndex = 2;
            this.roundBox.Text = "0";
            // 
            // setRoundButton
            // 
            this.setRoundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setRoundButton.Location = new System.Drawing.Point(386, 279);
            this.setRoundButton.Name = "setRoundButton";
            this.setRoundButton.Size = new System.Drawing.Size(75, 23);
            this.setRoundButton.TabIndex = 3;
            this.setRoundButton.Text = "set";
            this.setRoundButton.UseVisualStyleBackColor = true;
            this.setRoundButton.Click += new System.EventHandler(this.SetRoundButton_Click);
            // 
            // hookGameButton
            // 
            this.hookGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hookGameButton.Location = new System.Drawing.Point(260, 417);
            this.hookGameButton.Name = "hookGameButton";
            this.hookGameButton.Size = new System.Drawing.Size(201, 23);
            this.hookGameButton.TabIndex = 6;
            this.hookGameButton.Text = "Hook Game";
            this.hookGameButton.UseVisualStyleBackColor = true;
            this.hookGameButton.Click += new System.EventHandler(this.HookGameButton_Click);
            // 
            // gameVerLabel
            // 
            this.gameVerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gameVerLabel.AutoSize = true;
            this.gameVerLabel.ForeColor = System.Drawing.Color.White;
            this.gameVerLabel.Location = new System.Drawing.Point(13, 404);
            this.gameVerLabel.Name = "gameVerLabel";
            this.gameVerLabel.Size = new System.Drawing.Size(187, 13);
            this.gameVerLabel.TabIndex = 7;
            this.gameVerLabel.Text = "BTD5-Steam-NK-Version-3.22 (20610)";
            // 
            // lgbtButton
            // 
            this.lgbtButton.Location = new System.Drawing.Point(180, 35);
            this.lgbtButton.Name = "lgbtButton";
            this.lgbtButton.Size = new System.Drawing.Size(119, 23);
            this.lgbtButton.TabIndex = 8;
            this.lgbtButton.Text = "Lgbt Selected";
            this.lgbtButton.UseVisualStyleBackColor = true;
            this.lgbtButton.Click += new System.EventHandler(this.lgbtButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.lgbtButton);
            this.Controls.Add(this.gameVerLabel);
            this.Controls.Add(this.hookGameButton);
            this.Controls.Add(this.DowngradeCheckbox);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.setRoundButton);
            this.Controls.Add(this.setXpBox);
            this.Controls.Add(this.setRankButton);
            this.Controls.Add(this.setTokensButton);
            this.Controls.Add(this.setHealthBox);
            this.Controls.Add(this.setMonkeyMoney);
            this.Controls.Add(this.setMoneyButton);
            this.Controls.Add(this.roundBox);
            this.Controls.Add(this.xpBox);
            this.Controls.Add(this.rankBox);
            this.Controls.Add(this.tokenBox);
            this.Controls.Add(this.healthBox);
            this.Controls.Add(this.monkeyMoneyBox);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.xpLabel);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.tokenLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.monkeyMoneyLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "BTD5-Trainer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.Button setMoneyButton;
        private System.Windows.Forms.Label credits;
        private System.Windows.Forms.Label monkeyMoneyLabel;
        private System.Windows.Forms.TextBox monkeyMoneyBox;
        private System.Windows.Forms.Button setMonkeyMoney;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.TextBox healthBox;
        private System.Windows.Forms.Button setHealthBox;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Button setTokensButton;
        private System.Windows.Forms.CheckBox DowngradeCheckbox;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.TextBox rankBox;
        private System.Windows.Forms.Button setRankButton;
        private System.Windows.Forms.Label xpLabel;
        private System.Windows.Forms.TextBox xpBox;
        private System.Windows.Forms.Button setXpBox;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.TextBox roundBox;
        private System.Windows.Forms.Button setRoundButton;
        private System.Windows.Forms.Button hookGameButton;
        private System.Windows.Forms.Label gameVerLabel;
        private System.Windows.Forms.Button lgbtButton;
    }
}

