using System;
using System.Security.Cryptography;
using System.Text;

namespace lesson_6
{
    class HashHash
    {
        public static void Hash()
        {
            string str = Console.ReadLine();
            Console.WriteLine(str);

            char[] hs = str.ToCharArray();
            Console.WriteLine(hs);

            Console.ReadKey();
        }

        Guid GetHashString(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return new Guid(hash);
        }
    }
}
