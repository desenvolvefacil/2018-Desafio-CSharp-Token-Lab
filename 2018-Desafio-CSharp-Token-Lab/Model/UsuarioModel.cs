using _2018_Desafio_CSharp_Token_Lab.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2018_Desafio_CSharp_Token_Lab.Model
{
    public static class UsuarioModel
    {

        public static bool Salvar(UsuarioEntity entity)
        {
            //criptografa a senha
            entity.Senha = Util.SHA512(entity.Senha);

            Util.DB.Entry(entity).State = (entity.Id==0)?EntityState.Added:EntityState.Modified;

            return Util.DB.SaveChanges()==1;
        }

        public static UsuarioEntity Logar(String Login, String Senha)
        {
            //criptografa a senha
            Senha = Util.SHA512(Senha);

            return Util.DB.Usuarios.Where(u => u.Login==Login && u.Senha==Senha).FirstOrDefault();
        }
    }
}
