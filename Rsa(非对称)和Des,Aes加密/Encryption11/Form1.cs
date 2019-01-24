using EncriptSample;
using Encryption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string aa = Encryption.Encryption.EncryptionKey(textBox1.Text.Trim());
            richTextBox1.Text = aa;// Encryption. Encryption.EncryptionKey(textBox1.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var aa = Encryption.Encryption.DecryptKey(richTextBox1.Text.Trim());
            textBox3.Text = aa;// Encryption.Encryption.DecryptKey(richTextBox1.Text.Trim());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //KeyValuePair<string, string> keyPair = Encrypter.CreateRSAKey();
            //string privateKey = keyPair.Value;
            //string publicKey = keyPair.Key;

            //var aa = Encrypter.EncryptByRSA(richTextBox1.Text.Trim(),publicKey);
            //var cc = Encrypter.DecryptByRSA(aa, privateKey);
            //textBox3.Text = cc;// Encryption.Encryption.DecryptKey(richTextBox1.Text.Trim());

            //string   key = "111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";

            //  var  result = Encrypter.EncryptByAES("abc", key);
            //   Console.WriteLine("AES加密结果：{0}", result);

            //   result = Encrypter.DecryptByAES(result, key);
            //   Console.WriteLine("AES解密结果：{0}", result);

            Form2 f = new Encryption11.Form2();
            f.ShowDialog();

        //    KeyValuePair<string, string> keyPair = Encrypter.CreateRSAKey();
        //    string privateKey = keyPair.Value;
        //    string publicKey = keyPair.Key;

        //var     result = Encrypter.EncryptByRSA("阿斯顿撒大所多撒多撒多撒", publicKey);
        //    Console.WriteLine("RSA私钥加密后的结果：{0}", result);

        //    result = Encrypter.DecryptByRSA(result, privateKey);
        //    Console.WriteLine("RSA公钥解密后的结果：{0}", result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Encryption11.Form3();
            f.ShowDialog();
        }
    }
}
