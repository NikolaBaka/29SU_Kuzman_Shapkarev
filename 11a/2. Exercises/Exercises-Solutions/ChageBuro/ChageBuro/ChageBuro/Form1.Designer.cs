namespace ChageBuro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lableShow = new Label();
            textBoxCurrency = new TextBox();
            buttonCalc = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(332, 58);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 0;
            label1.Text = "BGN";
            // 
            // lableShow
            // 
            lableShow.AutoSize = true;
            lableShow.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lableShow.Location = new Point(70, 125);
            lableShow.Name = "lableShow";
            lableShow.Size = new Size(76, 30);
            lableShow.TabIndex = 1;
            lableShow.Text = "label2";
            // 
            // textBoxCurrency
            // 
            textBoxCurrency.Location = new Point(78, 57);
            textBoxCurrency.Name = "textBoxCurrency";
            textBoxCurrency.Size = new Size(248, 31);
            textBoxCurrency.TabIndex = 2;
            // 
            // buttonCalc
            // 
            buttonCalc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonCalc.Location = new Point(332, 176);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(156, 41);
            buttonCalc.TabIndex = 3;
            buttonCalc.Text = "Calculate";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 74);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 30);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(398, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 150);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 247);
            Controls.Add(groupBox1);
            Controls.Add(buttonCalc);
            Controls.Add(textBoxCurrency);
            Controls.Add(lableShow);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lableShow;
        private TextBox textBoxCurrency;
        private Button buttonCalc;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
    }
}
