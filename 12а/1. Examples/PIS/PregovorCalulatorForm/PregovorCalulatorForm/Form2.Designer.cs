namespace PregovorCalulatorForm
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
            textBoxFirst = new TextBox();
            textBoxSecond = new TextBox();
            labelResult = new Label();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonClean = new Button();
            SuspendLayout();
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(93, 57);
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(125, 27);
            textBoxFirst.TabIndex = 0;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(93, 105);
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(125, 27);
            textBoxSecond.TabIndex = 1;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(93, 171);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(50, 20);
            labelResult.TabIndex = 2;
            labelResult.Text = "label1";
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(493, 57);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(94, 29);
            buttonPlus.TabIndex = 3;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(493, 120);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(94, 29);
            buttonMinus.TabIndex = 4;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(493, 189);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(94, 29);
            buttonMultiply.TabIndex = 5;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(493, 250);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(94, 29);
            buttonDivide.TabIndex = 6;
            buttonDivide.Text = "\\";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonClean
            // 
            buttonClean.Location = new Point(493, 313);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(94, 29);
            buttonClean.TabIndex = 7;
            buttonClean.Text = "Изчисти";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClean);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(labelResult);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxFirst);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirst;
        private TextBox textBoxSecond;
        private Label labelResult;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonClean;
    }
}