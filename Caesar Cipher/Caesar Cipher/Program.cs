using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Input your secret message.");
            string userMessage = Console.ReadLine().ToLower();
            char[] secretMessage = userMessage.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char tempLetter = secretMessage[i];
                int tempIndexOld = Array.IndexOf(alphabet, tempLetter);
                int tempIndexNew = (tempIndexOld + 3) % alphabet.Length;
                encryptedMessage[i] = alphabet[tempIndexNew];
            }
            string userMessageEncrypted = String.Join("", encryptedMessage);
            Console.WriteLine($"This is your message encrypted, \"{userMessageEncrypted}\". ");
        }
    }
}
