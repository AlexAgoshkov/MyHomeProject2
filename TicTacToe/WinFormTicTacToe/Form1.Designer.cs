namespace WinFormTicTacToe
{
    partial class WinForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            this.btOne = new System.Windows.Forms.Button();
            this.btTwo = new System.Windows.Forms.Button();
            this.btThree = new System.Windows.Forms.Button();
            this.btFour = new System.Windows.Forms.Button();
            this.btFive = new System.Windows.Forms.Button();
            this.btSix = new System.Windows.Forms.Button();
            this.btSeven = new System.Windows.Forms.Button();
            this.btEight = new System.Windows.Forms.Button();
            this.btNine = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesOfTheGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOne
            // 
            this.btOne.Font = new System.Drawing.Font("Buxton Sketch", 59.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOne.ForeColor = System.Drawing.Color.Red;
            this.btOne.Image = global::WinFormTicTacToe.Properties.Resources.black_darth_vader_64;
            this.btOne.Location = new System.Drawing.Point(61, 90);
            this.btOne.Name = "btOne";
            this.btOne.Size = new System.Drawing.Size(87, 86);
            this.btOne.TabIndex = 0;
            this.btOne.UseVisualStyleBackColor = true;
            this.btOne.Click += new System.EventHandler(this.btClick);
            // 
            // btTwo
            // 
            this.btTwo.Font = new System.Drawing.Font("Buxton Sketch", 59.25F);
            this.btTwo.ForeColor = System.Drawing.Color.Red;
            this.btTwo.Image = global::WinFormTicTacToe.Properties.Resources.black_darth_vader_64;
            this.btTwo.Location = new System.Drawing.Point(226, 90);
            this.btTwo.Name = "btTwo";
            this.btTwo.Size = new System.Drawing.Size(87, 86);
            this.btTwo.TabIndex = 1;
            this.btTwo.UseVisualStyleBackColor = true;
            this.btTwo.Click += new System.EventHandler(this.btClick);
            // 
            // btThree
            // 
            this.btThree.Font = new System.Drawing.Font("Buxton Sketch", 59.25F);
            this.btThree.ForeColor = System.Drawing.Color.Red;
            this.btThree.Image = global::WinFormTicTacToe.Properties.Resources.black_darth_vader_64;
            this.btThree.Location = new System.Drawing.Point(389, 90);
            this.btThree.Name = "btThree";
            this.btThree.Size = new System.Drawing.Size(87, 86);
            this.btThree.TabIndex = 2;
            this.btThree.UseVisualStyleBackColor = true;
            this.btThree.Click += new System.EventHandler(this.btClick);
            // 
            // btFour
            // 
            this.btFour.Font = new System.Drawing.Font("Buxton Sketch", 59.25F);
            this.btFour.ForeColor = System.Drawing.Color.Red;
            this.btFour.Image = global::WinFormTicTacToe.Properties.Resources.black_darth_vader_64;
            this.btFour.Location = new System.Drawing.Point(61, 209);
            this.btFour.Name = "btFour";
            this.btFour.Size = new System.Drawing.Size(87, 86);
            this.btFour.TabIndex = 3;
            this.btFour.UseVisualStyleBackColor = true;
            this.btFour.Click += new System.EventHandler(this.btClick);
            // 
            // btFive
            // 
            this.btFive.Font = new System.Drawing.Font("Buxton Sketch", 59.25F);
            this.btFive.ForeColor = System.Drawing.Color.Red;
            this.btFive.Image = global::WinFormTicTacToe.Properties.Resources.black_darth_vader_64;
            this.btFive.Location = new System.Drawing.Point(226, 209);
            this.btFive.Name = "btFive";
            this.btFive.Size = new System.Drawing.Size(87, 86);
            this.btFive.TabIndex = 4;
            this.btFive.UseVisualStyleBackColor = true;
            this.btFive.Click += new System.EventHandler(this.btClick);
            // 
            // btSix
            // 
            this.btSix.Font = new System.Drawing.Font("Buxton Sketch", 59.25F);
            this.btSix.ForeColor = System.Drawing.Color.Red;
            this.btSix.Image = global::WinFormTicTacToe.Properties.Resources.black_darth_vader_64;
            this.btSix.Location = new System.Drawing.Point(389, 209);
            this.btSix.Name = "btSix";
            this.btSix.Size = new System.Drawing.Size(87, 86);
            this.btSix.TabIndex = 5;
            this.btSix.UseVisualStyleBackColor = true;
            this.btSix.Click += new System.EventHandler(this.btClick);
            // 
            // btSeven
            // 
            this.btSeven.Font = new System.Drawing.Font("Buxton Sketch", 59.25F);
            this.btSeven.ForeColor = System.Drawing.Color.Red;
            this.btSeven.Image = global::WinFormTicTacToe.Properties.Resources.black_darth_vader_64;
            this.btSeven.Location = new System.Drawing.Point(61, 329);
            this.btSeven.Name = "btSeven";
            this.btSeven.Size = new System.Drawing.Size(87, 86);
            this.btSeven.TabIndex = 6;
            this.btSeven.UseVisualStyleBackColor = true;
            this.btSeven.Click += new System.EventHandler(this.btClick);
            // 
            // btEight
            // 
            this.btEight.Font = new System.Drawing.Font("Buxton Sketch", 59.25F);
            this.btEight.ForeColor = System.Drawing.Color.Red;
            this.btEight.Image = global::WinFormTicTacToe.Properties.Resources.black_darth_vader_64;
            this.btEight.Location = new System.Drawing.Point(226, 329);
            this.btEight.Name = "btEight";
            this.btEight.Size = new System.Drawing.Size(87, 86);
            this.btEight.TabIndex = 7;
            this.btEight.UseVisualStyleBackColor = true;
            this.btEight.Click += new System.EventHandler(this.btClick);
            // 
            // btNine
            // 
            this.btNine.Font = new System.Drawing.Font("Buxton Sketch", 59.25F);
            this.btNine.ForeColor = System.Drawing.Color.Red;
            this.btNine.Image = global::WinFormTicTacToe.Properties.Resources.black_darth_vader_64;
            this.btNine.Location = new System.Drawing.Point(389, 329);
            this.btNine.Name = "btNine";
            this.btNine.Size = new System.Drawing.Size(87, 86);
            this.btNine.TabIndex = 8;
            this.btNine.UseVisualStyleBackColor = true;
            this.btNine.Click += new System.EventHandler(this.btClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::WinFormTicTacToe.Properties.Resources._24;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Brown;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.Color.Brown;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Brown;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesOfTheGameToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Brown;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // rulesOfTheGameToolStripMenuItem
            // 
            this.rulesOfTheGameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rulesOfTheGameToolStripMenuItem.ForeColor = System.Drawing.Color.Brown;
            this.rulesOfTheGameToolStripMenuItem.Name = "rulesOfTheGameToolStripMenuItem";
            this.rulesOfTheGameToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.rulesOfTheGameToolStripMenuItem.Text = "Rules of the game";
            this.rulesOfTheGameToolStripMenuItem.Click += new System.EventHandler(this.rulesOfTheGameToolStripMenuItem_Click);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::WinFormTicTacToe.Properties.Resources._24;
            this.ClientSize = new System.Drawing.Size(537, 501);
            this.Controls.Add(this.btNine);
            this.Controls.Add(this.btEight);
            this.Controls.Add(this.btSeven);
            this.Controls.Add(this.btSix);
            this.Controls.Add(this.btFive);
            this.Controls.Add(this.btFour);
            this.Controls.Add(this.btThree);
            this.Controls.Add(this.btTwo);
            this.Controls.Add(this.btOne);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WinForm";
            this.Text = "Tic Tac Toe";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOne;
        private System.Windows.Forms.Button btTwo;
        private System.Windows.Forms.Button btThree;
        private System.Windows.Forms.Button btFour;
        private System.Windows.Forms.Button btFive;
        private System.Windows.Forms.Button btSix;
        private System.Windows.Forms.Button btSeven;
        private System.Windows.Forms.Button btEight;
        private System.Windows.Forms.Button btNine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesOfTheGameToolStripMenuItem;
    }
}

