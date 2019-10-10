namespace RSAEncrpytionImplementation
{
    partial class RSAImplementationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEnteredText = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEnteredText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEncryptedText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDecryptedText = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearTBX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the text you want to see encrypted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "in the field below, then click submit:";
            // 
            // tbxEnteredText
            // 
            this.tbxEnteredText.Location = new System.Drawing.Point(12, 65);
            this.tbxEnteredText.Name = "tbxEnteredText";
            this.tbxEnteredText.Size = new System.Drawing.Size(307, 22);
            this.tbxEnteredText.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 93);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shown below is the text you entered";
            // 
            // lblEnteredText
            // 
            this.lblEnteredText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEnteredText.Location = new System.Drawing.Point(7, 164);
            this.lblEnteredText.Name = "lblEnteredText";
            this.lblEnteredText.Size = new System.Drawing.Size(378, 73);
            this.lblEnteredText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Here is your text encrypted";
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEncryptedText.Location = new System.Drawing.Point(9, 264);
            this.lblEncryptedText.Name = "lblEncryptedText";
            this.lblEncryptedText.Size = new System.Drawing.Size(614, 286);
            this.lblEncryptedText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "And here it is decrypted again!";
            // 
            // lblDecryptedText
            // 
            this.lblDecryptedText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDecryptedText.Location = new System.Drawing.Point(423, 164);
            this.lblDecryptedText.Name = "lblDecryptedText";
            this.lblDecryptedText.Size = new System.Drawing.Size(419, 73);
            this.lblDecryptedText.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(245, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearTBX
            // 
            this.btnClearTBX.Location = new System.Drawing.Point(130, 93);
            this.btnClearTBX.Name = "btnClearTBX";
            this.btnClearTBX.Size = new System.Drawing.Size(75, 23);
            this.btnClearTBX.TabIndex = 11;
            this.btnClearTBX.Text = "Clear";
            this.btnClearTBX.UseVisualStyleBackColor = true;
            this.btnClearTBX.Click += new System.EventHandler(this.btnClearTBX_Click);
            // 
            // RSAImplementationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 559);
            this.Controls.Add(this.btnClearTBX);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDecryptedText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEncryptedText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEnteredText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxEnteredText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RSAImplementationForm";
            this.Text = "RSA Encryption Algorithm Implementation";
            this.Load += new System.EventHandler(this.RSAImplementationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEnteredText;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnteredText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEncryptedText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDecryptedText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearTBX;
    }
}

