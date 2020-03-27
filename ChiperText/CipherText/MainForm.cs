using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChiperText;

namespace CipherText
{
    public partial class MainForm : Form
    {

        private readonly string plainTextPath = @"C:\Users\razvan.dorcioman\source\repos\ChiperText\ChiperText\CipherText\PlainText.txt";
        private readonly string cipherTextPath = @"C:\Users\razvan.dorcioman\source\repos\ChiperText\ChiperText\CipherText\CipherText.txt";

        public MainForm()
        {
            InitializeComponent();
            LoadText();
        }

        private void LoadText()
        {
            // This text is added only once to the file.
            if (!File.Exists(plainTextPath))
            {
                // Create a file to write to.
                string createText = "Error! File does not exist, I create it." + Environment.NewLine;
                File.WriteAllText(plainTextPath, createText, Encoding.UTF8);
            }

            string plainText = File.ReadAllText(plainTextPath);
            string cipherText = File.ReadAllText(cipherTextPath);

            plainTextRichTextBox.Text = plainText;
            cipherTextRichTextBox.Text = cipherText;
        }

        private void cipherButton_Click(object sender, EventArgs e)
        {
            // This text is added only once to the file.
            if (!File.Exists(plainTextPath))
            {
                return;
            }

            string plainText = File.ReadAllText(plainTextPath);
            string vigenereKey = vigenereKeyTextBox.Text;

            var vigenereEncryptionText = VigenereCipher.Encipher(plainText, vigenereKey);

            vigenereCipherRichTextBox.Text = vigenereEncryptionText;


            int caesarKey = Convert.ToInt32(caesarKeyNumericUpDown.Value);
            var cipherText = CaesarCipher.Encipher(vigenereEncryptionText, caesarKey);

            cipherTextRichTextBox.Text = cipherText;

            File.WriteAllText(cipherTextPath, cipherText);
        }

        private void decipherButton_Click(object sender, EventArgs e)
        {
            // This text is added only once to the file.
            if (!File.Exists(cipherTextPath))
            {
                return;
            }

            string cipherText = File.ReadAllText(cipherTextPath);
            string vigenereKey = vigenereKeyTextBox.Text;

            var vigenereDecryptionText = VigenereCipher.Decipher(cipherText, vigenereKey);

            vigenereCipherRichTextBox.Text = vigenereDecryptionText;
            
            int caesarKey = Convert.ToInt32(caesarKeyNumericUpDown.Value);
            var plainText = CaesarCipher.Decipher(vigenereDecryptionText, caesarKey);

            plainTextRichTextBox.Text = plainText;

            File.WriteAllText(plainTextPath, plainText);
        }
    }
}
