using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Inventario.Helpers.Cryptography
{

    class Helper
    {
        private Helper() { }

        /**
         * 
         * @param string
         * @return byte[]
         */
        public static byte[] GetBytesOfString(string str)
        {
            return System.Text.Encoding.UTF8.GetBytes(str);
        }

        /**
         * 
         * @param byte[]
         * @return string
         */
        public static string GetStringOfBytes(byte[] str)
        {
            return Convert.ToBase64String(str);
        }

    }

    class DesEncryption
    { 
        private DesEncryption() 
        {
            des.Mode = CipherMode.CBC;
            des.Padding = PaddingMode.PKCS7;
        }

        public static byte[] Decrypt(string dataToDecrypt, string key, string IV)
        {
            return Decrypt(Helper.GetBytesOfString(dataToDecrypt),
                           Helper.GetBytesOfString(key),
                           Helper.GetBytesOfString(IV)
                    );
        }

        public static byte[] Decrypt(byte[] dataToDecrypt, byte[] key, byte[] IV)
        {
            return null;
        }

        public static byte[] Encrypt(string dataToEncrypt, string key, string IV)
        {
            return Encrypt(Helper.GetBytesOfString(dataToEncrypt),
                           Helper.GetBytesOfString(key),
                           Helper.GetBytesOfString(IV)
                    );
        }

        public static byte[] Encrypt(byte[] dataToEncrypt, byte[] key, byte[] IV)
        {
            return null;
        }

        private static DESCryptoServiceProvider des = new DESCryptoServiceProvider(); 
    }

    class Hash
    {

        private Hash() { }
        
        /**
         * @param int
         * @return byte[]
         */
        public static byte[] GenerateRandowNumber(int lenght)
        {
            byte[] randomNumber = new byte[lenght];

            randomNumberGenerator.GetBytes(randomNumber);

            return randomNumber;
        }

        /**
         * 
         * @param string
         * @return byte[]
         */
        public static byte[] MD5(string str)
        {
            return MD5(Helper.GetBytesOfString(str));
        }

        /**
         * 
         * @param byte[]
         * @return byte[]
         */
        public static byte[] MD5(byte[] str)
        {
            return md5.ComputeHash(str);
        }

        /**
         * 
         * @param string
         * @return byte[]
         */
        public static byte[] SHA256(string str)
        {
            return SHA256(Helper.GetBytesOfString(str));
        }

        /**
         * 
         * @param byte[]
         * @return byte[]
         */
        public static byte[] SHA256(byte[] str)
        {
            return sha256.ComputeHash(str);
        }

        /**
         * @param string
         * @return byte[]
         */
        public static byte[] SHA384(string str)
        {
            return SHA384(Helper.GetBytesOfString(str));
        }

        /**
         * @param byte[]
         * @return byte[]
         */
        public static byte[] SHA384(byte[] str)
        {
            return sha384.ComputeHash(str);
        }

        /**
         * 
         * @param string
         * @return byte[]
         */
        public static byte[] SHA512(string str)
        {
            return SHA512(Helper.GetBytesOfString(str));
        }

        /**
         * 
         * @param byte[]
         * @return byte[]
         */
        public static byte[] SHA512(byte[] str)
        {
            return sha512.ComputeHash(str);
        }

        private static MD5 md5 = System.Security.Cryptography.MD5.Create();
        private static SHA256 sha256 = System.Security.Cryptography.SHA256.Create();
        private static SHA384 sha384 = System.Security.Cryptography.SHA384.Create();
        private static SHA512 sha512 = System.Security.Cryptography.SHA512.Create();
        private static RNGCryptoServiceProvider randomNumberGenerator = new RNGCryptoServiceProvider();

    }

}
