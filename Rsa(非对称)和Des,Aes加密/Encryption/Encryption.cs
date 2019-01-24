using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
    public class Encryption
    {
        /// <summary>
        ///加密RSA
        /// </summary>
        /// <param name="express"></param>
        /// <param name="KeyContainerName">密匙容器的名称</param>
        /// <returns></returns>
        public static string EncryptionKey(string express, string KeyContainerName = "1")
        {
            try
            {
                CspParameters param = new CspParameters();
                param.KeyContainerName = KeyContainerName;//密匙容器的名称，保持加密解密一致才能解密成功
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
                {
                    byte[] plaindata = Encoding.Default.GetBytes(express);//将要加密的字符串转换为字节数组
                    byte[] encryptdata = rsa.Encrypt(plaindata, false);//将加密后的字节数据转换为新的加密字节数组
                    return Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为字符串
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //解密RSA
        public static string DecryptKey(string ciphertext, string KeyContainerName = "1")
        {
            try
            {
                CspParameters param = new CspParameters();
                param.KeyContainerName = KeyContainerName;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
                {
                    byte[] encryptdata = Convert.FromBase64String(ciphertext);
                    byte[] decryptdata = rsa.Decrypt(encryptdata, false);
                    return Encoding.Default.GetString(decryptdata);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
