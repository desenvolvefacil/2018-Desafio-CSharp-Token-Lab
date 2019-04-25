using _2018_Desafio_CSharp_Token_Lab.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_Desafio_CSharp_Token_Lab.Model
{
    public static class EventoModel
    {
        public static bool Salvar(EventoEntity entity)
        {
            try
            {
                entity.Usuario = Util.UsuarioLogado;

                Util.DB.Entry(entity).State = (entity.Id == 0) ? EntityState.Added : EntityState.Modified;

                int ret = Util.DB.SaveChanges();

                return ret>0;
            }catch(Exception e)
            {
                e.StackTrace.ToString();

                return false;
            }
        }

        public static List<EventoEntity> Listar()
        {
            return Util.DB.Eventos.Where(e => e.Usuario.Id == Util.UsuarioLogado.Id).ToList();
        }

        public static bool Remover(EventoEntity entity)
        {
            Util.DB.Entry(entity).State = EntityState.Deleted;

            int ret = Util.DB.SaveChanges();

            return ret > 0;

        }

        public static EventoEntity Buscar(DateTime data)
        {
            return Util.DB.Eventos.Where(e => e.Data == data && e.Usuario.Id == Util.UsuarioLogado.Id).SingleOrDefault();
        }

    }
}