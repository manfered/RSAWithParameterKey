using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAWithParameterKey
{
    class Program
    {
        static void Main(string[] args)
        {
            var rsaParams = new RSAWithParameterKey();
            const string message = "Message to Encrypt";

            rsaParams.AssignNewKey();

            var encrypted = rsaParams.EncryptData(Encoding.UTF8.GetBytes(message));
            var decrypted = rsaParams.DecryptData(encrypted);

            Console.WriteLine("RSA Encryption in Memory");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Message text = {message}");
            Console.WriteLine($"Encrypted text = {Convert.ToBase64String(encrypted)}");
            Console.WriteLine($"Decrypted text = {Encoding.UTF8.GetString(decrypted)}");
            Console.WriteLine();

        }
    }
}
