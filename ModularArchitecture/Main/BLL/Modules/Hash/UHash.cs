using System;
using System.Security.Cryptography;
using System.Text;

namespace Main.BLL.Modules.Hash
{
    public static class UHash
    {
        public static string Encrypt(string input) {
            byte[] bytes = Encoding.Unicode.GetBytes(input);
            byte[] inArray = HashAlgorithm.Create("SHA1")?.ComputeHash(bytes);
            return Convert.ToBase64String(inArray ?? throw new Exception());
        }
        
        public static string GenGuid() {
            return Guid.NewGuid().ToString();
        }
    }
}