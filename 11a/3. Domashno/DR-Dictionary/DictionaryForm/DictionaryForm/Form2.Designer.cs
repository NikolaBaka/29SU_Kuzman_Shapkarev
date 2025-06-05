namespace DictionaryForm
{
    partial class Form2
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
            textBoxEN = new TextBox();
            labelBG = new Label();
            button1 = new Button();
            labelLeft = new Label();
            labelRight = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxEN
            // 
            textBoxEN.Font = new Font("Segoe UI", 12F);
            textBoxEN.Location = new Point(31, 63);
            textBoxEN.Name = "textBoxEN";
            textBoxEN.Size = new Size(193, 34);
            textBoxEN.TabIndex = 2;
            textBoxEN.KeyDown += textBoxEN_KeyDown;
            // 
            // labelBG
            // 
            labelBG.AutoSize = true;
            labelBG.Font = new Font("Segoe UI", 12F);
            labelBG.Location = new Point(426, 66);
            labelBG.Name = "labelBG";
            labelBG.Size = new Size(65, 28);
            labelBG.TabIndex = 1;
            labelBG.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(191, 210);
            button1.Name = "button1";
            button1.Size = new Size(139, 57);
            button1.TabIndex = 2;
            button1.Text = "Преводи";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelLeft
            // 
            labelLeft.AutoSize = true;
            labelLeft.Font = new Font("Segoe UI", 12F);
            labelLeft.Location = new Point(31, 32);
            labelLeft.Name = "labelLeft";
            labelLeft.Size = new Size(111, 28);
            labelLeft.TabIndex = 3;
            labelLeft.Text = "Английски";
            labelLeft.Click += label2_Click;
            // 
            // labelRight
            // 
            labelRight.AutoSize = true;
            labelRight.Font = new Font("Segoe UI", 12F);
            labelRight.Location = new Point(384, 32);
            labelRight.Name = "labelRight";
            labelRight.Size = new Size(107, 28);
            labelRight.TabIndex = 4;
            labelRight.Text = "Български";
            // 
            // button2
            // 
            button2.Location = new Point(217, 123);
            button2.Name = "button2";
            button2.Size = new Size(87, 60);
            button2.TabIndex = 5;
            button2.Text = "размени езика";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 306);
            Controls.Add(button2);
            Controls.Add(labelRight);
            Controls.Add(labelLeft);
            Controls.Add(button1);
            Controls.Add(labelBG);
            Controls.Add(textBoxEN);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEN;
        private Label labelBG;
        private Button button1;
        private Label labelLeft;
        private Label labelRight;
        private Button button2;
    }
}