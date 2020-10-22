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
            bool mainRunning = true;
            while (mainRunning)
            {
                Console.WriteLine("Welcome to the program. Would you like to encrypt a message or decrypt a message? Type the letter 'E' to choose encrypt and 'D' to choose decrypt.");
                string userInput = (Console.ReadLine()).ToLower();
                if (userInput == "e")
                {
                    mainRunning = false;
                    Encrypter();
                }
                else if (userInput == "d")
                {
                    mainRunning = false;
                    Decrypter();
                }
                else
                {
                    mainRunning = true;
                    Console.Clear();
                    Console.WriteLine("Invalid input, try again.");
                }
            }
        }
        public static void Encrypter()
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Input your message to be encoded.");
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
            Console.ReadLine();
        }
        public static void Decrypter()
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Input your message to be decoded.");
            string userMessage = Console.ReadLine().ToLower();
            char[] secretMessage = userMessage.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char tempLetter = secretMessage[i];
                int tempIndexOld = Array.IndexOf(alphabet, tempLetter);
                int tempIndexNew = (tempIndexOld - 3) % alphabet.Length;
                encryptedMessage[i] = alphabet[tempIndexNew];
            }
            string userMessageEncrypted = String.Join("", encryptedMessage);
            Console.WriteLine($"This is your message decrypted, \"{userMessageEncrypted}\". ");
            Console.ReadLine();
        }
    }
}
