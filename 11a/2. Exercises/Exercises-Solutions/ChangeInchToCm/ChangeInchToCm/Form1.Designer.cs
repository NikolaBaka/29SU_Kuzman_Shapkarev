namespace ChangeInchToCm
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
            label1 = new Label();
            labelCalculation = new Label();
            textBoxCalculate = new TextBox();
            SuspendLayout();
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(300, 237);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(112, 34);
            buttonCalculate.TabIndex = 0;
            buttonCalculate.Text = "Пресметни";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += пресметни_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(434, 83);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 1;
            label1.Text = "Inch";
            // 
            // labelCalculation
            // 
            labelCalculation.AutoSize = true;
            labelCalculation.Location = new Point(134, 167);
            labelCalculation.Name = "labelCalculation";
            labelCalculation.Size = new Size(59, 25);
            labelCalculation.TabIndex = 2;
            labelCalculation.Text = "label2";
            // 
            // textBoxCalculate
            // 
            textBoxCalculate.Location = new Point(227, 77);
            textBoxCalculate.Name = "textBoxCalculate";
            textBoxCalculate.Size = new Size(150, 31);
            textBoxCalculate.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 300);
            Controls.Add(textBoxCalculate);
            Controls.Add(labelCalculation);
            Controls.Add(label1);
            Controls.Add(buttonCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalculate;
        private Label label1;
        private Label labelCalculation;
        private TextBox textBoxCalculate;
    }
}
