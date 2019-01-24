using EncriptSample;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string key = "111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";

            //var result = Encrypter.EncryptByAES("abc", key);
            //Console.WriteLine("AES加密结果：{0}", result);

            //result = Encrypter.DecryptByAES(result, key);
            //Console.WriteLine("AES解密结果：{0}", result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox2.Text;
            if (key.Trim().Length!=16)
            {
                MessageBox.Show("添加16位key");
            }
            string aa = Encrypter.EncryptByAES(textBox1.Text.Trim(), key); 
            richTextBox1.Text = aa;// Encryption. Encryption.EncryptionKey(textBox1.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = textBox2.Text;
            var aa = Encrypter.DecryptByAES(richTextBox1.Text.Trim(), key);
            textBox3.Text = aa;// Encryption.Encryption.DecryptKey(richTextBox1.Text.Trim());

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1 f = new Encryption11.Form1();
            //f.Show();
        }
    }
}
