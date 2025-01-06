namespace NextForm
{
    partial class Form1
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
            this.buttonForm1 = new System.Windows.Forms.Button();
            this.textBoxNameForm1 = new System.Windows.Forms.TextBox();
            this.textBoxPassForm1 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonForm1
            // 
            this.buttonForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm1.Location = new System.Drawing.Point(188, 280);
            this.buttonForm1.Name = "buttonForm1";
            this.buttonForm1.Size = new System.Drawing.Size(194, 106);
            this.buttonForm1.TabIndex = 0;
            this.buttonForm1.Text = "Click here";
            this.buttonForm1.UseVisualStyleBackColor = true;
            this.buttonForm1.Click += new System.EventHandler(this.buttonForm1_Click);
            // 
            // textBoxNameForm1
            // 
            this.textBoxNameForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameForm1.Location = new System.Drawing.Point(102, 90);
            this.textBoxNameForm1.Multiline = true;
            this.textBoxNameForm1.Name = "textBoxNameForm1";
            this.textBoxNameForm1.Size = new System.Drawing.Size(352, 56);
            this.textBoxNameForm1.TabIndex = 1;
            // 
            // textBoxPassForm1
            // 
            this.textBoxPassForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassForm1.Location = new System.Drawing.Point(102, 190);
            this.textBoxPassForm1.Multiline = true;
            this.textBoxPassForm1.Name = "textBoxPassForm1";
            this.textBoxPassForm1.PasswordChar = '*';
            this.textBoxPassForm1.Size = new System.Drawing.Size(352, 58);
            this.textBoxPassForm1.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(97, 58);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(132, 29);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBoxPassForm1);
            this.Controls.Add(this.textBoxNameForm1);
            this.Controls.Add(this.buttonForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForm1;
        private System.Windows.Forms.TextBox textBoxNameForm1;
        private System.Windows.Forms.TextBox textBoxPassForm1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
    }
}

