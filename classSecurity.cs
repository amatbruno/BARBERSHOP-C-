using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace P13_amatbruno_proyectoBarberTopACTUAL
{
    internal class classSecurity
    {
 
        public static string md5Digest(string txt)
        {
            string digest = "";
            MD5 md5 = MD5CryptoServiceProvider.Create(); //32 bytes


            //1st pass: convert txt to byte string
            Byte[] bytes = Encoding.Default.GetBytes(txt);


            //2nd pass: convert bytes to hash
            Byte[] hashBytes = md5.ComputeHash(bytes);
            digest = BitConverter.ToString(hashBytes);

            //replace -
            digest = digest.Replace("-", String.Empty);

            return digest;
        }


        public static string sha1Digest(string txt)
        {
            string digest = string.Empty;
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();


            //1st pass: convert txt to byte string
            Byte[] bytes = Encoding.Default.GetBytes(txt);


            //2nd pass: convert bytes to hash
            Byte[] hashBytes = sha1.ComputeHash(bytes);
            digest = BitConverter.ToString(hashBytes);


            //replace -
            digest = digest.Replace("-", String.Empty);


            return digest;
        }



        public static string convertToJSON(String login, String password)
        {

            var p = new classJSON
            {
                Login = login,
                Password = password,
            };

            return JsonSerializer.Serialize(p);
        }


        public static string convertToJson(Object ob)
        {
            return JsonSerializer.Serialize(ob);
        }


        public static string JSONtoTXT(String JSONtoTXT, string pass)
        {
            classJSON p1 = JsonSerializer.Deserialize<classJSON>(JSONtoTXT);
            return p1.Login + p1.Password;
        }
    }
}
