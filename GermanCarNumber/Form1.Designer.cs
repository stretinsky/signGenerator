namespace GermanCarNumber
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.regionLabel = new System.Windows.Forms.Label();
            this.lettersLabel = new System.Windows.Forms.Label();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.31F);
            this.button1.Location = new System.Drawing.Point(289, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сгенерировать случайный номер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateRandomNumber);
            // 
            // regionLabel
            // 
            this.regionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regionLabel.AutoSize = true;
            this.regionLabel.BackColor = System.Drawing.Color.White;
            this.regionLabel.Location = new System.Drawing.Point(158, 142);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(12, 17);
            this.regionLabel.TabIndex = 2;
            this.regionLabel.Text = "A";
            this.regionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regionLabel.UseCompatibleTextRendering = true;
            // 
            // lettersLabel
            // 
            this.lettersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lettersLabel.AutoSize = true;
            this.lettersLabel.BackColor = System.Drawing.Color.White;
            this.lettersLabel.Location = new System.Drawing.Point(364, 142);
            this.lettersLabel.Name = "lettersLabel";
            this.lettersLabel.Size = new System.Drawing.Size(12, 17);
            this.lettersLabel.TabIndex = 3;
            this.lettersLabel.Text = "A";
            this.lettersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lettersLabel.UseCompatibleTextRendering = true;
            // 
            // numbersLabel
            // 
            this.numbersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.BackColor = System.Drawing.Color.White;
            this.numbersLabel.Location = new System.Drawing.Point(509, 142);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(10, 17);
            this.numbersLabel.TabIndex = 4;
            this.numbersLabel.Text = "1";
            this.numbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numbersLabel.UseCompatibleTextRendering = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(606, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 95);
            this.button2.TabIndex = 5;
            this.button2.Text = "Следующий номер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GenerateNextNumber);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(35, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 95);
            this.button3.TabIndex = 6;
            this.button3.Text = "Предыдущий номер";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GeneratePreviousNumber);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem1.Text = "Настройки";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.OpenDialogBox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.lettersLabel);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Label lettersLabel;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

