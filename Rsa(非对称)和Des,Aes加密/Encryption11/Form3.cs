using EncriptSample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption11
{
    public partial class Form3 : Form
    {
        string privateKey = "";
        string publicKey ="";
        public Form3()
        {
            InitializeComponent();

        
        }


     
        private void button1_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> keyPair =  Encrypter.CreateRSAKey();
             privateKey = keyPair.Value;
             publicKey = keyPair.Key;
            //RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //string privateKey1 = rsa.ToXmlString(true);
            //string publicKey1 = rsa.ToXmlString(false);
            richTextBox2.Text =publicKey;
            richTextBox3.Text = privateKey;
            string aa = Encrypter.EncryptByRSA(textBox1.Text.Trim(), publicKey);
            richTextBox1.Text = aa;// Encryption. Encryption.EncryptionKey(textBox1.Text.Trim());

            var bb = Encrypter.DecryptByRSA(richTextBox1.Text.Trim(), privateKey);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var aa = Encrypter.DecryptByRSA(richTextBox1.Text.Trim(), privateKey);
            textBox3.Text = aa;// Encryption.Encryption.DecryptKey(richTextBox1.Text.Trim());
        }
    }
}
