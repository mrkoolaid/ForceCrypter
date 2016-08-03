using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
//Copyright 2016
//Made by mrmutt for hackforums uid=3005497
//Please leave this note here
namespace ForceCrypterSmall
{


    public class Encboop
    {
       

        public static byte[] AESEncrypt(byte[] encrypt, byte[] key2)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] {1, 2, 3, 4, 5, 6, 7, 8};

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(key2, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize/8);
                    AES.IV = key.GetBytes(AES.BlockSize/8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encrypt, 0, encrypt.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }


            return encryptedBytes;
        }

        public static byte[] AESDecrypt(byte[] decrypted, byte[] key2)
        {
            byte[] decryptedBytes = null;

            byte[] saltBytes = new byte[] {1, 2, 3, 4, 5, 6, 7, 8};

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(key2, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize/8);
                    AES.IV = key.GetBytes(AES.BlockSize/8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(decrypted, 0, decrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }
            return decryptedBytes;
        }
    }
}
