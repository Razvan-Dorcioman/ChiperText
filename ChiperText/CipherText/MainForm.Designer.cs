namespace CipherText
{
    partial class MainForm
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
            this.cipherButton = new System.Windows.Forms.Button();
            this.decipherButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.caesarKeyLabel = new System.Windows.Forms.Label();
            this.caesarKeyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vigenereKeyLabel = new System.Windows.Forms.Label();
            this.vigenereKeyTextBox = new System.Windows.Forms.TextBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.vigenereCipherText = new System.Windows.Forms.Label();
            this.vigenereCipherRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cipherTextLabel = new System.Windows.Forms.Label();
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.cipherTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.plainTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caesarKeyNumericUpDown)).BeginInit();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cipherButton
            // 
            this.cipherButton.Location = new System.Drawing.Point(134, 121);
            this.cipherButton.Name = "cipherButton";
            this.cipherButton.Size = new System.Drawing.Size(75, 23);
            this.cipherButton.TabIndex = 0;
            this.cipherButton.Text = "Encode";
            this.cipherButton.UseVisualStyleBackColor = true;
            this.cipherButton.Click += new System.EventHandler(this.cipherButton_Click);
            // 
            // decipherButton
            // 
            this.decipherButton.Location = new System.Drawing.Point(215, 121);
            this.decipherButton.Name = "decipherButton";
            this.decipherButton.Size = new System.Drawing.Size(75, 23);
            this.decipherButton.TabIndex = 1;
            this.decipherButton.Text = "Decode";
            this.decipherButton.UseVisualStyleBackColor = true;
            this.decipherButton.Click += new System.EventHandler(this.decipherButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.infoLabel.Location = new System.Drawing.Point(13, 13);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(225, 13);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "This program use Vigenere and Caesar cipher.";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.caesarKeyLabel);
            this.settingsGroupBox.Controls.Add(this.caesarKeyNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.vigenereKeyLabel);
            this.settingsGroupBox.Controls.Add(this.vigenereKeyTextBox);
            this.settingsGroupBox.Controls.Add(this.cipherButton);
            this.settingsGroupBox.Controls.Add(this.decipherButton);
            this.settingsGroupBox.Location = new System.Drawing.Point(13, 46);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(299, 150);
            this.settingsGroupBox.TabIndex = 3;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // caesarKeyLabel
            // 
            this.caesarKeyLabel.AutoSize = true;
            this.caesarKeyLabel.Location = new System.Drawing.Point(148, 33);
            this.caesarKeyLabel.Name = "caesarKeyLabel";
            this.caesarKeyLabel.Size = new System.Drawing.Size(61, 13);
            this.caesarKeyLabel.TabIndex = 5;
            this.caesarKeyLabel.Text = "Caesar Key";
            // 
            // caesarKeyNumericUpDown
            // 
            this.caesarKeyNumericUpDown.Location = new System.Drawing.Point(151, 49);
            this.caesarKeyNumericUpDown.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.caesarKeyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.caesarKeyNumericUpDown.Name = "caesarKeyNumericUpDown";
            this.caesarKeyNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.caesarKeyNumericUpDown.TabIndex = 4;
            this.caesarKeyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // vigenereKeyLabel
            // 
            this.vigenereKeyLabel.AutoSize = true;
            this.vigenereKeyLabel.Location = new System.Drawing.Point(10, 33);
            this.vigenereKeyLabel.Name = "vigenereKeyLabel";
            this.vigenereKeyLabel.Size = new System.Drawing.Size(70, 13);
            this.vigenereKeyLabel.TabIndex = 3;
            this.vigenereKeyLabel.Text = "Vigenere Key";
            // 
            // vigenereKeyTextBox
            // 
            this.vigenereKeyTextBox.Location = new System.Drawing.Point(10, 49);
            this.vigenereKeyTextBox.Name = "vigenereKeyTextBox";
            this.vigenereKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.vigenereKeyTextBox.TabIndex = 2;
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.vigenereCipherText);
            this.outputGroupBox.Controls.Add(this.vigenereCipherRichTextBox);
            this.outputGroupBox.Controls.Add(this.cipherTextLabel);
            this.outputGroupBox.Controls.Add(this.plainTextLabel);
            this.outputGroupBox.Controls.Add(this.cipherTextRichTextBox);
            this.outputGroupBox.Controls.Add(this.plainTextRichTextBox);
            this.outputGroupBox.Location = new System.Drawing.Point(13, 203);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(775, 235);
            this.outputGroupBox.TabIndex = 4;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // vigenereCipherText
            // 
            this.vigenereCipherText.AutoSize = true;
            this.vigenereCipherText.Location = new System.Drawing.Point(7, 87);
            this.vigenereCipherText.Name = "vigenereCipherText";
            this.vigenereCipherText.Size = new System.Drawing.Size(119, 13);
            this.vigenereCipherText.TabIndex = 5;
            this.vigenereCipherText.Text = "Vigenere encrypted text";
            // 
            // vigenereCipherRichTextBox
            // 
            this.vigenereCipherRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vigenereCipherRichTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.vigenereCipherRichTextBox.Location = new System.Drawing.Point(6, 107);
            this.vigenereCipherRichTextBox.Name = "vigenereCipherRichTextBox";
            this.vigenereCipherRichTextBox.ReadOnly = true;
            this.vigenereCipherRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.vigenereCipherRichTextBox.Size = new System.Drawing.Size(763, 41);
            this.vigenereCipherRichTextBox.TabIndex = 4;
            this.vigenereCipherRichTextBox.Text = "";
            // 
            // cipherTextLabel
            // 
            this.cipherTextLabel.AutoSize = true;
            this.cipherTextLabel.Location = new System.Drawing.Point(7, 157);
            this.cipherTextLabel.Name = "cipherTextLabel";
            this.cipherTextLabel.Size = new System.Drawing.Size(153, 13);
            this.cipherTextLabel.TabIndex = 3;
            this.cipherTextLabel.Text = "Cipher text (Vigenere + Caesar)";
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.Location = new System.Drawing.Point(7, 20);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(50, 13);
            this.plainTextLabel.TabIndex = 2;
            this.plainTextLabel.Text = "Plain text";
            // 
            // cipherTextRichTextBox
            // 
            this.cipherTextRichTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cipherTextRichTextBox.Location = new System.Drawing.Point(7, 177);
            this.cipherTextRichTextBox.Name = "cipherTextRichTextBox";
            this.cipherTextRichTextBox.ReadOnly = true;
            this.cipherTextRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.cipherTextRichTextBox.Size = new System.Drawing.Size(762, 36);
            this.cipherTextRichTextBox.TabIndex = 1;
            this.cipherTextRichTextBox.Text = "";
            // 
            // plainTextRichTextBox
            // 
            this.plainTextRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plainTextRichTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.plainTextRichTextBox.Location = new System.Drawing.Point(6, 40);
            this.plainTextRichTextBox.Name = "plainTextRichTextBox";
            this.plainTextRichTextBox.ReadOnly = true;
            this.plainTextRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.plainTextRichTextBox.Size = new System.Drawing.Size(763, 41);
            this.plainTextRichTextBox.TabIndex = 0;
            this.plainTextRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.infoLabel);
            this.Name = "MainForm";
            this.Text = "CipherText Form - Double encryption with Vigenere and Caesar cipher";
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caesarKeyNumericUpDown)).EndInit();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cipherButton;
        private System.Windows.Forms.Button decipherButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label vigenereKeyLabel;
        private System.Windows.Forms.TextBox vigenereKeyTextBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.RichTextBox cipherTextRichTextBox;
        private System.Windows.Forms.RichTextBox plainTextRichTextBox;
        private System.Windows.Forms.Label caesarKeyLabel;
        private System.Windows.Forms.NumericUpDown caesarKeyNumericUpDown;
        private System.Windows.Forms.Label vigenereCipherText;
        private System.Windows.Forms.RichTextBox vigenereCipherRichTextBox;
    }
}

