namespace NextForm
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
            this.buttonForm2 = new System.Windows.Forms.Button();
            this.lableForm2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonForm2
            // 
            this.buttonForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm2.Location = new System.Drawing.Point(186, 302);
            this.buttonForm2.Name = "buttonForm2";
            this.buttonForm2.Size = new System.Drawing.Size(168, 94);
            this.buttonForm2.TabIndex = 0;
            this.buttonForm2.Text = "OK";
            this.buttonForm2.UseVisualStyleBackColor = true;
            this.buttonForm2.Click += new System.EventHandler(this.buttonForm2_Click);
            // 
            // lableForm2
            // 
            this.lableForm2.AutoSize = true;
            this.lableForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableForm2.Location = new System.Drawing.Point(220, 112);
            this.lableForm2.Name = "lableForm2";
            this.lableForm2.Size = new System.Drawing.Size(79, 29);
            this.lableForm2.TabIndex = 1;
            this.lableForm2.Text = "label1";
            this.lableForm2.Click += new System.EventHandler(this.lableForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.lableForm2);
            this.Controls.Add(this.buttonForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForm2;
        private System.Windows.Forms.Label lableForm2;
    }
}