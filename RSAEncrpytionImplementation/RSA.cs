using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Prng;

namespace RSAEncrpytionImplementation
{
    public static class RSA
    {
        /// <summary>
        /// Generates public and private key pairs for RSA encryption
        /// </summary>
        /// <param name="random">Random number</param>
        /// <param name="keyLength">Length of the keys(Default is 1024)</param>
        /// <param name="keyCertainty">Default is 10</param>
        /// <returns></returns>
        public static Dictionary<string, BigInteger> GenerateKeyPairs(SecureRandom random, int keyLength = 1024, int keyCertainty = 10)
        {
            // Generates 2 prime random numbers
            BigInteger p = new BigInteger(keyLength, keyCertainty, random);
            BigInteger q = new BigInteger(keyLength, keyCertainty, random);

            // Instantiating BigIntegers for numbers one and two
            BigInteger one = new BigInteger("1");
            BigInteger two = new BigInteger("2");

            // Finding the modulus to be used in the public and private key pairs
            BigInteger n = p.Multiply(q);
            // Finding the totient of n to be used to find our exponent in the public key
            // Also helps find the private key later on using the ModInverse method
            BigInteger et = p.Subtract(one).Multiply(q.Subtract(one));
            // Instaniates e as 11 since it is possibly coprime with the totient
            BigInteger e = new BigInteger("11");

            // Loop will use our extended euclidean algorithm to find our public key so that it is coprime with the totient
            while (true)
            {
                if (gcd(e, et).Equals(one))
                {
                    break;
                } else
                {
                    e = e.Add(two);
                }
            }
            // Finds the private key by finding the inversemod of e and the totient
            BigInteger d = e.ModInverse(et);

            // Generates the dictionary to store the keypairs
            Dictionary<string, BigInteger> ret = new Dictionary<string, BigInteger>();
            ret.Add("e", e);
            ret.Add("d", d);
            ret.Add("n", n);

            return ret;
        }
        /// <summary>
        /// Encrypts a string using RSA
        /// </summary>
        /// <param name="m"></param>
        /// <param name="keyValuePairs"></param>
        /// <returns></returns>
        public static string Encrypt(string m, Dictionary<string, BigInteger> keyValuePairs)
        {
            var byteArray = Encoding.ASCII.GetBytes(m); // Fkinds the ASCII codes
            BigInteger message = new BigInteger(byteArray);
            BigInteger c = message.ModPow(keyValuePairs["e"], keyValuePairs["n"]);
            return c.ToString();
        }

        /// <summary>
        /// Decrypts an encrypted string using RSA
        /// </summary>
        /// <param name="m"></param>
        /// <param name="keyValuePairs"></param>
        /// <returns></returns>
        public static string Decrypt(string m, Dictionary<string, BigInteger> keyValuePairs)
        {
            BigInteger c = new BigInteger(m);
            BigInteger decryptedMessage = c.ModPow(keyValuePairs["d"], keyValuePairs["n"]);

            var decryptedBA = decryptedMessage.ToByteArray();
            string decryptedMessageText = ASCIIEncoding.ASCII.GetString(decryptedBA);
            string returnString = decryptedMessageText;
            return returnString;
        }

        /// <summary>
        /// Extended euclidean algorithm
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static BigInteger gcd(BigInteger a, BigInteger b)
        {
            BigInteger zero = new BigInteger("0");
            if (a.Equals(zero))
                return b;

            return gcd(b.Mod(a), a);
        }
    }
}
