using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "123456123456";
            var keyBytes = Encoding.ASCII.GetBytes(key);
            var originText = "北京，你好。";
            // 加密原文
            var encBytes = qiyubrother.AES.Encrypt(Encoding.UTF8.GetBytes(originText), keyBytes);
            // 解密密文
            var decBytes = qiyubrother.AES.Decrypt(encBytes, keyBytes);
            var rstOriginText = Encoding.UTF8.GetString(decBytes);

            Console.WriteLine($"原文：“{originText}”");
            Console.WriteLine($"还原：“{rstOriginText}”");

            Console.ReadKey();
        }
    }
}
