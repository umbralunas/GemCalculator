
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CalcTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.serverKORadio = new System.Windows.Forms.RadioButton();
            this.serverGLRadio = new System.Windows.Forms.RadioButton();
            this.targetTypeLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.efficientOutputLabel = new System.Windows.Forms.Label();
            this.TicketThresholdLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.myGemsLabel = new System.Windows.Forms.Label();
            this.myGemsUpDown = new System.Windows.Forms.NumericUpDown();
            this.serverGroupBox = new System.Windows.Forms.GroupBox();
            this.TargetUpDown = new System.Windows.Forms.NumericUpDown();
            this.tokensOrTicketsLabel = new System.Windows.Forms.Label();
            this.calculateTickets = new System.Windows.Forms.RadioButton();
            this.calculateTokens = new System.Windows.Forms.RadioButton();
            this.myTokensLabel = new System.Windows.Forms.Label();
            this.myTokensUpDown = new System.Windows.Forms.NumericUpDown();
            this.AssumptionsLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.CalcTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGemsUpDown)).BeginInit();
            this.serverGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TargetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTokensUpDown)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcTabs
            // 
            this.CalcTabs.Controls.Add(this.tabPage1);
            this.CalcTabs.Controls.Add(this.tabPage2);
            this.CalcTabs.Controls.Add(this.tabPage3);
            this.CalcTabs.Location = new System.Drawing.Point(0, 0);
            this.CalcTabs.Name = "CalcTabs";
            this.CalcTabs.SelectedIndex = 0;
            this.CalcTabs.Size = new System.Drawing.Size(784, 555);
            this.CalcTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.efficientOutputLabel);
            this.tabPage1.Controls.Add(this.targetTypeLabel);
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.TicketThresholdLabel);
            this.tabPage1.Controls.Add(this.calculateButton);
            this.tabPage1.Controls.Add(this.myGemsLabel);
            this.tabPage1.Controls.Add(this.myGemsUpDown);
            this.tabPage1.Controls.Add(this.serverGroupBox);
            this.tabPage1.Controls.Add(this.TargetUpDown);
            this.tabPage1.Controls.Add(this.tokensOrTicketsLabel);
            this.tabPage1.Controls.Add(this.calculateTickets);
            this.tabPage1.Controls.Add(this.calculateTokens);
            this.tabPage1.Controls.Add(this.myTokensLabel);
            this.tabPage1.Controls.Add(this.myTokensUpDown);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AssumptionsLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "How to use";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // serverKORadio
            // 
            this.serverKORadio.AutoSize = true;
            this.serverKORadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverKORadio.Location = new System.Drawing.Point(6, 48);
            this.serverKORadio.Name = "serverKORadio";
            this.serverKORadio.Size = new System.Drawing.Size(75, 21);
            this.serverKORadio.TabIndex = 9;
            this.serverKORadio.TabStop = true;
            this.serverKORadio.Text = "Korean";
            this.serverKORadio.UseVisualStyleBackColor = true;
            // 
            // serverGLRadio
            // 
            this.serverGLRadio.AutoSize = true;
            this.serverGLRadio.Checked = true;
            this.serverGLRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverGLRadio.Location = new System.Drawing.Point(6, 21);
            this.serverGLRadio.Name = "serverGLRadio";
            this.serverGLRadio.Size = new System.Drawing.Size(103, 21);
            this.serverGLRadio.TabIndex = 8;
            this.serverGLRadio.TabStop = true;
            this.serverGLRadio.Text = "Global (EN)";
            this.serverGLRadio.UseVisualStyleBackColor = true;
            this.serverGLRadio.CheckedChanged += new System.EventHandler(this.serverGLRadio_CheckedChanged);
            // 
            // targetTypeLabel
            // 
            this.targetTypeLabel.AutoSize = true;
            this.targetTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetTypeLabel.Location = new System.Drawing.Point(273, 68);
            this.targetTypeLabel.Name = "targetTypeLabel";
            this.targetTypeLabel.Size = new System.Drawing.Size(163, 17);
            this.targetTypeLabel.TabIndex = 37;
            this.targetTypeLabel.Text = "4. And this target is for...";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(499, 61);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 28);
            this.clearButton.TabIndex = 36;
            this.clearButton.Text = "Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // efficientOutputLabel
            // 
            this.efficientOutputLabel.AutoSize = true;
            this.efficientOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efficientOutputLabel.Location = new System.Drawing.Point(93, 294);
            this.efficientOutputLabel.Name = "efficientOutputLabel";
            this.efficientOutputLabel.Size = new System.Drawing.Size(40, 17);
            this.efficientOutputLabel.TabIndex = 35;
            this.efficientOutputLabel.Text = "        ";
            // 
            // TicketThresholdLabel
            // 
            this.TicketThresholdLabel.AutoSize = true;
            this.TicketThresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketThresholdLabel.Location = new System.Drawing.Point(273, 152);
            this.TicketThresholdLabel.Name = "TicketThresholdLabel";
            this.TicketThresholdLabel.Size = new System.Drawing.Size(181, 85);
            this.TicketThresholdLabel.TabIndex = 34;
            this.TicketThresholdLabel.Text = "Exchange ticket thresholds:\r\n\r\n600 for L2D costumes\r\n200 for 5 star dolls\r\n100 fo" +
    "r other dolls";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(499, 24);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(105, 28);
            this.calculateButton.TabIndex = 30;
            this.calculateButton.Text = "5. Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click_1);
            // 
            // myGemsLabel
            // 
            this.myGemsLabel.AutoSize = true;
            this.myGemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGemsLabel.Location = new System.Drawing.Point(12, 63);
            this.myGemsLabel.Name = "myGemsLabel";
            this.myGemsLabel.Size = new System.Drawing.Size(217, 17);
            this.myGemsLabel.TabIndex = 33;
            this.myGemsLabel.Text = "2. How many gems do you have?";
            // 
            // myGemsUpDown
            // 
            this.myGemsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGemsUpDown.Location = new System.Drawing.Point(49, 89);
            this.myGemsUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.myGemsUpDown.Name = "myGemsUpDown";
            this.myGemsUpDown.Size = new System.Drawing.Size(120, 22);
            this.myGemsUpDown.TabIndex = 25;
            this.myGemsUpDown.ValueChanged += new System.EventHandler(this.myGemsUpDown_ValueChanged_1);
            // 
            // serverGroupBox
            // 
            this.serverGroupBox.Controls.Add(this.serverKORadio);
            this.serverGroupBox.Controls.Add(this.serverGLRadio);
            this.serverGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverGroupBox.Location = new System.Drawing.Point(638, 10);
            this.serverGroupBox.Name = "serverGroupBox";
            this.serverGroupBox.Size = new System.Drawing.Size(128, 75);
            this.serverGroupBox.TabIndex = 32;
            this.serverGroupBox.TabStop = false;
            this.serverGroupBox.Text = "Server:";
            // 
            // TargetUpDown
            // 
            this.TargetUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetUpDown.Location = new System.Drawing.Point(276, 32);
            this.TargetUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TargetUpDown.Name = "TargetUpDown";
            this.TargetUpDown.Size = new System.Drawing.Size(120, 22);
            this.TargetUpDown.TabIndex = 27;
            this.TargetUpDown.ValueChanged += new System.EventHandler(this.TargetUpDown_ValueChanged_1);
            // 
            // tokensOrTicketsLabel
            // 
            this.tokensOrTicketsLabel.AutoSize = true;
            this.tokensOrTicketsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokensOrTicketsLabel.Location = new System.Drawing.Point(273, 8);
            this.tokensOrTicketsLabel.Name = "tokensOrTicketsLabel";
            this.tokensOrTicketsLabel.Size = new System.Drawing.Size(152, 17);
            this.tokensOrTicketsLabel.TabIndex = 31;
            this.tokensOrTicketsLabel.Text = "3. What is your target?";
            // 
            // calculateTickets
            // 
            this.calculateTickets.AutoSize = true;
            this.calculateTickets.Checked = true;
            this.calculateTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTickets.Location = new System.Drawing.Point(276, 91);
            this.calculateTickets.Name = "calculateTickets";
            this.calculateTickets.Size = new System.Drawing.Size(140, 21);
            this.calculateTickets.TabIndex = 28;
            this.calculateTickets.TabStop = true;
            this.calculateTickets.Text = "Exchange Tickets";
            this.calculateTickets.UseVisualStyleBackColor = true;
            this.calculateTickets.CheckedChanged += new System.EventHandler(this.calculateTickets_CheckedChanged_1);
            // 
            // calculateTokens
            // 
            this.calculateTokens.AutoSize = true;
            this.calculateTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTokens.Location = new System.Drawing.Point(276, 116);
            this.calculateTokens.Name = "calculateTokens";
            this.calculateTokens.Size = new System.Drawing.Size(76, 21);
            this.calculateTokens.TabIndex = 29;
            this.calculateTokens.Text = "Tokens";
            this.calculateTokens.UseVisualStyleBackColor = true;
            // 
            // myTokensLabel
            // 
            this.myTokensLabel.AutoSize = true;
            this.myTokensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTokensLabel.Location = new System.Drawing.Point(8, 8);
            this.myTokensLabel.Name = "myTokensLabel";
            this.myTokensLabel.Size = new System.Drawing.Size(225, 17);
            this.myTokensLabel.TabIndex = 26;
            this.myTokensLabel.Text = "1. How many tokens do you have?";
            // 
            // myTokensUpDown
            // 
            this.myTokensUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTokensUpDown.Location = new System.Drawing.Point(49, 32);
            this.myTokensUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.myTokensUpDown.Name = "myTokensUpDown";
            this.myTokensUpDown.Size = new System.Drawing.Size(120, 22);
            this.myTokensUpDown.TabIndex = 24;
            this.myTokensUpDown.ValueChanged += new System.EventHandler(this.myTokensUpDown_ValueChanged_1);
            // 
            // AssumptionsLabel
            // 
            this.AssumptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssumptionsLabel.Location = new System.Drawing.Point(8, 3);
            this.AssumptionsLabel.Name = "AssumptionsLabel";
            this.AssumptionsLabel.Size = new System.Drawing.Size(758, 360);
            this.AssumptionsLabel.TabIndex = 39;
            this.AssumptionsLabel.Text = resources.GetString("AssumptionsLabel.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AboutLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AboutLabel
            // 
            this.AboutLabel.Location = new System.Drawing.Point(8, 12);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(758, 290);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = resources.GetString("AboutLabel.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.CalcTabs);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Gems Calculator Ver. γ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CalcTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGemsUpDown)).EndInit();
            this.serverGroupBox.ResumeLayout(false);
            this.serverGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TargetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTokensUpDown)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CalcTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label targetTypeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label efficientOutputLabel;
        private System.Windows.Forms.Label TicketThresholdLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label myGemsLabel;
        private System.Windows.Forms.NumericUpDown myGemsUpDown;
        private System.Windows.Forms.GroupBox serverGroupBox;
        private System.Windows.Forms.RadioButton serverKORadio;
        private System.Windows.Forms.RadioButton serverGLRadio;
        private System.Windows.Forms.NumericUpDown TargetUpDown;
        private System.Windows.Forms.Label tokensOrTicketsLabel;
        private System.Windows.Forms.RadioButton calculateTickets;
        private System.Windows.Forms.RadioButton calculateTokens;
        private System.Windows.Forms.Label myTokensLabel;
        private System.Windows.Forms.NumericUpDown myTokensUpDown;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label AssumptionsLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label AboutLabel;
    }
}

