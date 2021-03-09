
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.myTokensUpDown = new System.Windows.Forms.NumericUpDown();
            this.myTokensLabel = new System.Windows.Forms.Label();
            this.calculateTokens = new System.Windows.Forms.RadioButton();
            this.calculateTickets = new System.Windows.Forms.RadioButton();
            this.tokensOrTicketsLabel = new System.Windows.Forms.Label();
            this.TargetUpDown = new System.Windows.Forms.NumericUpDown();
            this.serverGLRadio = new System.Windows.Forms.RadioButton();
            this.serverGroupBox = new System.Windows.Forms.GroupBox();
            this.serverKORadio = new System.Windows.Forms.RadioButton();
            this.myGemsUpDown = new System.Windows.Forms.NumericUpDown();
            this.myGemsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.TicketThresholdLabel = new System.Windows.Forms.Label();
            this.efficientOutputLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.doubleCheckBox = new System.Windows.Forms.CheckBox();
            this.targetTypeLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.languageGroupBox = new System.Windows.Forms.GroupBox();
            this.KoreanLanguageButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.myTokensUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetUpDown)).BeginInit();
            this.serverGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGemsUpDown)).BeginInit();
            this.languageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // myTokensUpDown
            // 
            this.myTokensUpDown.Location = new System.Drawing.Point(61, 90);
            this.myTokensUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.myTokensUpDown.Name = "myTokensUpDown";
            this.myTokensUpDown.Size = new System.Drawing.Size(120, 22);
            this.myTokensUpDown.TabIndex = 0;
            this.myTokensUpDown.ValueChanged += new System.EventHandler(this.myTokensUpDown_ValueChanged);
            // 
            // myTokensLabel
            // 
            this.myTokensLabel.AutoSize = true;
            this.myTokensLabel.Location = new System.Drawing.Point(16, 70);
            this.myTokensLabel.Name = "myTokensLabel";
            this.myTokensLabel.Size = new System.Drawing.Size(209, 17);
            this.myTokensLabel.TabIndex = 1;
            this.myTokensLabel.Text = "How many tokens do you have?";
            // 
            // calculateTokens
            // 
            this.calculateTokens.AutoSize = true;
            this.calculateTokens.Location = new System.Drawing.Point(310, 170);
            this.calculateTokens.Name = "calculateTokens";
            this.calculateTokens.Size = new System.Drawing.Size(76, 21);
            this.calculateTokens.TabIndex = 4;
            this.calculateTokens.Text = "Tokens";
            this.calculateTokens.UseVisualStyleBackColor = true;
            // 
            // calculateTickets
            // 
            this.calculateTickets.AutoSize = true;
            this.calculateTickets.Checked = true;
            this.calculateTickets.Location = new System.Drawing.Point(310, 145);
            this.calculateTickets.Name = "calculateTickets";
            this.calculateTickets.Size = new System.Drawing.Size(140, 21);
            this.calculateTickets.TabIndex = 3;
            this.calculateTickets.TabStop = true;
            this.calculateTickets.Text = "Exchange Tickets";
            this.calculateTickets.UseVisualStyleBackColor = true;
            this.calculateTickets.CheckedChanged += new System.EventHandler(this.calculateTickets_CheckedChanged);
            // 
            // tokensOrTicketsLabel
            // 
            this.tokensOrTicketsLabel.AutoSize = true;
            this.tokensOrTicketsLabel.Location = new System.Drawing.Point(307, 70);
            this.tokensOrTicketsLabel.Name = "tokensOrTicketsLabel";
            this.tokensOrTicketsLabel.Size = new System.Drawing.Size(136, 17);
            this.tokensOrTicketsLabel.TabIndex = 5;
            this.tokensOrTicketsLabel.Text = "What is your target?";
            // 
            // TargetUpDown
            // 
            this.TargetUpDown.Location = new System.Drawing.Point(310, 90);
            this.TargetUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TargetUpDown.Name = "TargetUpDown";
            this.TargetUpDown.Size = new System.Drawing.Size(120, 22);
            this.TargetUpDown.TabIndex = 2;
            this.TargetUpDown.ValueChanged += new System.EventHandler(this.TargetUpDown_ValueChanged);
            // 
            // serverGLRadio
            // 
            this.serverGLRadio.AutoSize = true;
            this.serverGLRadio.Checked = true;
            this.serverGLRadio.Location = new System.Drawing.Point(6, 21);
            this.serverGLRadio.Name = "serverGLRadio";
            this.serverGLRadio.Size = new System.Drawing.Size(103, 21);
            this.serverGLRadio.TabIndex = 8;
            this.serverGLRadio.TabStop = true;
            this.serverGLRadio.Text = "Global (EN)";
            this.serverGLRadio.UseVisualStyleBackColor = true;
            this.serverGLRadio.CheckedChanged += new System.EventHandler(this.serverGLRadio_CheckedChanged);
            // 
            // serverGroupBox
            // 
            this.serverGroupBox.Controls.Add(this.serverKORadio);
            this.serverGroupBox.Controls.Add(this.serverGLRadio);
            this.serverGroupBox.Location = new System.Drawing.Point(640, 12);
            this.serverGroupBox.Name = "serverGroupBox";
            this.serverGroupBox.Size = new System.Drawing.Size(128, 75);
            this.serverGroupBox.TabIndex = 9;
            this.serverGroupBox.TabStop = false;
            this.serverGroupBox.Text = "Server:";
            // 
            // serverKORadio
            // 
            this.serverKORadio.AutoSize = true;
            this.serverKORadio.Location = new System.Drawing.Point(6, 48);
            this.serverKORadio.Name = "serverKORadio";
            this.serverKORadio.Size = new System.Drawing.Size(75, 21);
            this.serverKORadio.TabIndex = 9;
            this.serverKORadio.TabStop = true;
            this.serverKORadio.Text = "Korean";
            this.serverKORadio.UseVisualStyleBackColor = true;
            // 
            // myGemsUpDown
            // 
            this.myGemsUpDown.Location = new System.Drawing.Point(61, 145);
            this.myGemsUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.myGemsUpDown.Name = "myGemsUpDown";
            this.myGemsUpDown.Size = new System.Drawing.Size(120, 22);
            this.myGemsUpDown.TabIndex = 1;
            this.myGemsUpDown.ValueChanged += new System.EventHandler(this.myGemsUpDown_ValueChanged);
            // 
            // myGemsLabel
            // 
            this.myGemsLabel.AutoSize = true;
            this.myGemsLabel.Location = new System.Drawing.Point(16, 122);
            this.myGemsLabel.Name = "myGemsLabel";
            this.myGemsLabel.Size = new System.Drawing.Size(201, 17);
            this.myGemsLabel.TabIndex = 11;
            this.myGemsLabel.Text = "How many gems do you have?";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(503, 26);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 28);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // TicketThresholdLabel
            // 
            this.TicketThresholdLabel.AutoSize = true;
            this.TicketThresholdLabel.Location = new System.Drawing.Point(307, 206);
            this.TicketThresholdLabel.Name = "TicketThresholdLabel";
            this.TicketThresholdLabel.Size = new System.Drawing.Size(181, 85);
            this.TicketThresholdLabel.TabIndex = 14;
            this.TicketThresholdLabel.Text = "Exchange ticket thresholds:\r\n\r\n600 for L2D costumes\r\n200 for 5 star dolls\r\n100 fo" +
    "r other dolls";
            // 
            // efficientOutputLabel
            // 
            this.efficientOutputLabel.AutoSize = true;
            this.efficientOutputLabel.Location = new System.Drawing.Point(58, 304);
            this.efficientOutputLabel.Name = "efficientOutputLabel";
            this.efficientOutputLabel.Size = new System.Drawing.Size(95, 17);
            this.efficientOutputLabel.TabIndex = 16;
            this.efficientOutputLabel.Text = "Standing by...";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(503, 62);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(93, 28);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // doubleCheckBox
            // 
            this.doubleCheckBox.AutoSize = true;
            this.doubleCheckBox.Location = new System.Drawing.Point(12, 12);
            this.doubleCheckBox.Name = "doubleCheckBox";
            this.doubleCheckBox.Size = new System.Drawing.Size(349, 21);
            this.doubleCheckBox.TabIndex = 18;
            this.doubleCheckBox.Text = "Apply extra gifts? (this doubles gems per package)";
            this.doubleCheckBox.UseVisualStyleBackColor = true;
            this.doubleCheckBox.CheckedChanged += new System.EventHandler(this.doubleCheckBox_CheckedChanged);
            // 
            // targetTypeLabel
            // 
            this.targetTypeLabel.AutoSize = true;
            this.targetTypeLabel.Location = new System.Drawing.Point(307, 122);
            this.targetTypeLabel.Name = "targetTypeLabel";
            this.targetTypeLabel.Size = new System.Drawing.Size(147, 17);
            this.targetTypeLabel.TabIndex = 19;
            this.targetTypeLabel.Text = "And this target is for...";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(637, 206);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(131, 17);
            this.aboutLabel.TabIndex = 20;
            this.aboutLabel.Text = "Why is this a thing?";
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // languageGroupBox
            // 
            this.languageGroupBox.Controls.Add(this.KoreanLanguageButton);
            this.languageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.languageGroupBox.Location = new System.Drawing.Point(640, 93);
            this.languageGroupBox.Name = "languageGroupBox";
            this.languageGroupBox.Size = new System.Drawing.Size(128, 75);
            this.languageGroupBox.TabIndex = 21;
            this.languageGroupBox.TabStop = false;
            this.languageGroupBox.Text = "Language:";
            // 
            // KoreanLanguageButton
            // 
            this.KoreanLanguageButton.AutoSize = true;
            this.KoreanLanguageButton.Enabled = false;
            this.KoreanLanguageButton.Location = new System.Drawing.Point(6, 48);
            this.KoreanLanguageButton.Name = "KoreanLanguageButton";
            this.KoreanLanguageButton.Size = new System.Drawing.Size(75, 21);
            this.KoreanLanguageButton.TabIndex = 1;
            this.KoreanLanguageButton.Text = "Korean";
            this.KoreanLanguageButton.UseVisualStyleBackColor = true;
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(6, 21);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(75, 21);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.languageGroupBox);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.targetTypeLabel);
            this.Controls.Add(this.doubleCheckBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.efficientOutputLabel);
            this.Controls.Add(this.TicketThresholdLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.myGemsLabel);
            this.Controls.Add(this.myGemsUpDown);
            this.Controls.Add(this.serverGroupBox);
            this.Controls.Add(this.TargetUpDown);
            this.Controls.Add(this.tokensOrTicketsLabel);
            this.Controls.Add(this.calculateTickets);
            this.Controls.Add(this.calculateTokens);
            this.Controls.Add(this.myTokensLabel);
            this.Controls.Add(this.myTokensUpDown);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "GFL Gems Calculator Ver.α";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myTokensUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetUpDown)).EndInit();
            this.serverGroupBox.ResumeLayout(false);
            this.serverGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGemsUpDown)).EndInit();
            this.languageGroupBox.ResumeLayout(false);
            this.languageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown myTokensUpDown;
        private System.Windows.Forms.Label myTokensLabel;
        private System.Windows.Forms.RadioButton calculateTokens;
        private System.Windows.Forms.RadioButton calculateTickets;
        private System.Windows.Forms.Label tokensOrTicketsLabel;
        private System.Windows.Forms.NumericUpDown TargetUpDown;
        private System.Windows.Forms.RadioButton serverGLRadio;
        private System.Windows.Forms.GroupBox serverGroupBox;
        private System.Windows.Forms.RadioButton serverKORadio;
        private System.Windows.Forms.NumericUpDown myGemsUpDown;
        private System.Windows.Forms.Label myGemsLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label TicketThresholdLabel;
        private System.Windows.Forms.Label efficientOutputLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox doubleCheckBox;
        private System.Windows.Forms.Label targetTypeLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.GroupBox languageGroupBox;
        private System.Windows.Forms.RadioButton KoreanLanguageButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
    }
}

