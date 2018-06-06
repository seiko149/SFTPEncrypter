using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SFTPEncrypter
{
    public partial class Form1 : Form
    {
        String value;
        String value2;

        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            Encryption encryption = new Encryption();

            String unencrypted = unencryptTextBox.Text;

            if (unencrypted != "" || unencrypted != null)
            {
                value = encryption.Encrypt(unencrypted);
            }
            else
            {
                value = "Insert a value to be encrypted";
            }

            encryptedTextBox.Text = value;
        }

        private void valueLabel_Click(object sender, EventArgs e)
        {

        }

        private void encryptTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            Encryption encryption = new Encryption();

            try
            {
                String encrypted = encryptedTextBox.Text;
                if (encrypted != "" && encrypted != null)
                {
                    value2 = encryption.Decrypted(encrypted);
                }
                else
                {
                    value2 = "insert a value to be decrypted";
                }
                unencryptTextBox.Text = value2;
            }
            catch (Exception ex)
            {
                unencryptTextBox.Text = "Incorrect value";
            }
        }
    }
}
