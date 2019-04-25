using _2018_Desafio_CSharp_Token_Lab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2018_Desafio_CSharp_Token_Lab.Utils
{
    public static class Util
    {
        //variavel que controla a conexão com o banco de dados
        public static Model.BDTokenLabEntities DB = new BDTokenLabEntities();


        //usuario logado
        public static UsuarioEntity UsuarioLogado;

        //cripatografa uma string
        public static string SHA512(string Senha)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(Senha);
            byte[] hash = sha512.ComputeHash(bytes);

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}
