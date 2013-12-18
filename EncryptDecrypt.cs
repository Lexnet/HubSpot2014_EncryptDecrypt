using System;
using System.Collections.Generic;
using System.Text;
using System.Security;
using System.Security.Cryptography;

namespace Lexnet.Security
{
    //using System;
    //using System.IO;
    //using System.Xml;
    //using System.Text;
    //using System.Security.Cryptography;

    public class EncryptDecrypt
    {
        private static string seed = "";        	

        public EncryptDecrypt()
        {
            
        }        

        /// <summary>
        ///    Decrypts  a particular string with a specific Key
        /// </summary>
        public static string Decrypt(string stringToDecrypt, string sEncryptionKey)
        {
            /*
            byte[] key = { };
            byte[] IV = { 10, 20, 30, 40, 50, 60, 70, 80 };
            byte[] inputByteArray = new byte[stringToDecrypt.Length];

            try
            {
                key = Encoding.UTF8.GetBytes(sEncryptionKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(stringToDecrypt);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                Encoding encoding = Encoding.UTF8;
                return encoding.GetString(ms.ToArray());
            }

            catch (System.Exception ex)
            {
                return (string.Empty);
            }
             * */
            return stringToDecrypt;
        }

        public static string Decrypt(string stringToDecrypt)
        {
            //return Decrypt(stringToDecrypt, EncryptDecrypt.seed);
            return stringToDecrypt;
        }

        /// <summary>
        ///   Encrypts  a particular string with a specific Key
        /// </summary>
        /// <param name="stringToEncrypt"></param>
        /// <param name="sEncryptionKey"></param>
        /// <returns></returns>
        public static string Encrypt(string stringToEncrypt, string sEncryptionKey)
        { /*
            byte[] key = { };
            byte[] IV = { 10, 20, 30, 40, 50, 60, 70, 80 };
            byte[] inputByteArray; //Convert.ToByte(stringToEncrypt.Length) 

            try
            {
                key = Encoding.UTF8.GetBytes(sEncryptionKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Encoding.UTF8.GetBytes(stringToEncrypt);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }

            catch (System.Exception ex)
            {
                return (string.Empty);
            }
           * */
            return stringToEncrypt;
        }

        public static string Encrypt(string stringToEncrypt)
        {
            //return Encrypt(stringToEncrypt, EncryptDecrypt.seed);
            return stringToEncrypt;
        }
    }
}
