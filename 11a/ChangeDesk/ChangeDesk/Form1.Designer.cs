namespace ChangeDesk
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
            buttonCalculate = new Button();
            textBoxCurrency = new TextBox();
            groupBox1 = new GroupBox();
            radioButtonYEN = new RadioButton();
            radioButtonRUB = new RadioButton();
            radioButtonEUR = new RadioButton();
            radioButtonUSD = new RadioButton();
            labelCaculation = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCalculate.Location = new Point(271, 346);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(214, 55);
            buttonCalculate.TabIndex = 0;
            buttonCalculate.Text = "Пресметни";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxCurrency
            // 
            textBoxCurrency.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxCurrency.Location = new Point(108, 128);
            textBoxCurrency.Multiline = true;
            textBoxCurrency.Name = "textBoxCurrency";
            textBoxCurrency.Size = new Size(283, 64);
            textBoxCurrency.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonYEN);
            groupBox1.Controls.Add(radioButtonRUB);
            groupBox1.Controls.Add(radioButtonEUR);
            groupBox1.Controls.Add(radioButtonUSD);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(482, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 189);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Валути";
            // 
            // radioButtonYEN
            // 
            radioButtonYEN.AutoSize = true;
            radioButtonYEN.Location = new Point(6, 135);
            radioButtonYEN.Name = "radioButtonYEN";
            radioButtonYEN.Size = new Size(86, 36);
            radioButtonYEN.TabIndex = 7;
            radioButtonYEN.TabStop = true;
            radioButtonYEN.Text = "YEN";
            radioButtonYEN.UseVisualStyleBackColor = true;
            // 
            // radioButtonRUB
            // 
            radioButtonRUB.AutoSize = true;
            radioButtonRUB.Location = new Point(6, 100);
            radioButtonRUB.Name = "radioButtonRUB";
            radioButtonRUB.Size = new Size(87, 36);
            radioButtonRUB.TabIndex = 6;
            radioButtonRUB.TabStop = true;
            radioButtonRUB.Text = "RUB";
            radioButtonRUB.UseVisualStyleBackColor = true;
            // 
            // radioButtonEUR
            // 
            radioButtonEUR.AutoSize = true;
            radioButtonEUR.Location = new Point(6, 65);
            radioButtonEUR.Name = "radioButtonEUR";
            radioButtonEUR.Size = new Size(85, 36);
            radioButtonEUR.TabIndex = 5;
            radioButtonEUR.TabStop = true;
            radioButtonEUR.Text = "EUR";
            radioButtonEUR.UseVisualStyleBackColor = true;
            // 
            // radioButtonUSD
            // 
            radioButtonUSD.AutoSize = true;
            radioButtonUSD.Location = new Point(6, 30);
            radioButtonUSD.Name = "radioButtonUSD";
            radioButtonUSD.Size = new Size(87, 36);
            radioButtonUSD.TabIndex = 4;
            radioButtonUSD.TabStop = true;
            radioButtonUSD.Text = "USD";
            radioButtonUSD.UseVisualStyleBackColor = true;
            // 
            // labelCaculation
            // 
            labelCaculation.AutoSize = true;
            labelCaculation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelCaculation.Location = new Point(108, 265);
            labelCaculation.Name = "labelCaculation";
            labelCaculation.Size = new Size(83, 32);
            labelCaculation.TabIndex = 3;
            labelCaculation.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCaculation);
            Controls.Add(groupBox1);
            Controls.Add(textBoxCurrency);
            Controls.Add(buttonCalculate);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalculate;
        private TextBox textBoxCurrency;
        private GroupBox groupBox1;
        private RadioButton radioButtonRUB;
        private RadioButton radioButtonEUR;
        private RadioButton radioButtonUSD;
        private Label labelCaculation;
        private RadioButton radioButtonYEN;
    }
}
