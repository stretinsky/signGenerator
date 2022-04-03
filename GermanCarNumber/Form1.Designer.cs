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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.31F);
            this.button1.Location = new System.Drawing.Point(379, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сгенерировать случайный номер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateRandomNumber);
            // 
            // label1
            // 
            this.regionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regionLabel.AutoSize = true;
            this.regionLabel.BackColor = System.Drawing.Color.White;
            this.regionLabel.Location = new System.Drawing.Point(272, 140);
            this.regionLabel.Name = "label1";
            this.regionLabel.Size = new System.Drawing.Size(12, 17);
            this.regionLabel.TabIndex = 2;
            this.regionLabel.Text = "A";
            this.regionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regionLabel.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.lettersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lettersLabel.AutoSize = true;
            this.lettersLabel.BackColor = System.Drawing.Color.White;
            this.lettersLabel.Location = new System.Drawing.Point(451, 140);
            this.lettersLabel.Name = "label2";
            this.lettersLabel.Size = new System.Drawing.Size(12, 17);
            this.lettersLabel.TabIndex = 3;
            this.lettersLabel.Text = "A";
            this.lettersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lettersLabel.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.numbersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.BackColor = System.Drawing.Color.White;
            this.numbersLabel.Location = new System.Drawing.Point(577, 140);
            this.numbersLabel.Name = "label3";
            this.numbersLabel.Size = new System.Drawing.Size(10, 17);
            this.numbersLabel.TabIndex = 4;
            this.numbersLabel.Text = "1";
            this.numbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numbersLabel.UseCompatibleTextRendering = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(662, 309);
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
            this.button3.Location = new System.Drawing.Point(156, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 95);
            this.button3.TabIndex = 6;
            this.button3.Text = "Предыдущий номер";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GeneratePreviousNumber);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(12, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.lettersLabel);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

