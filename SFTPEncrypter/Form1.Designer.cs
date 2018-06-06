namespace SFTPEncrypter
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
            this.valueLabel = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.unencryptTextBox = new System.Windows.Forms.TextBox();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(23, 13);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(98, 13);
            this.valueLabel.TabIndex = 0;
            this.valueLabel.Text = "Unencrypted Value";
            this.valueLabel.Click += new System.EventHandler(this.valueLabel_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(101, 196);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 1;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // unencryptTextBox
            // 
            this.unencryptTextBox.Location = new System.Drawing.Point(147, 10);
            this.unencryptTextBox.Name = "unencryptTextBox";
            this.unencryptTextBox.Size = new System.Drawing.Size(100, 20);
            this.unencryptTextBox.TabIndex = 2;
            this.unencryptTextBox.TextChanged += new System.EventHandler(this.encryptTextBox_TextChanged);
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(147, 60);
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.Size = new System.Drawing.Size(100, 20);
            this.encryptedTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encrypted Value";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(197, 196);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 5;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.unencryptTextBox);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.valueLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox unencryptTextBox;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decryptButton;
    }
}

