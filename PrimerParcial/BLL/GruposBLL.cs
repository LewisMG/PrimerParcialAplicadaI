using PrimerParcial.DAL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PrimerParcial.BLL
{
    public class GruposBLL
    {
        public static bool Guardar(Grupos grupo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Grupo.Add(grupo) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Grupos grupo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(grupo).State = EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            
            try
            {
                Grupos grupo = contexto.Grupo.Find(id);
                contexto.Grupo.Remove(grupo);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Grupos Buscar(int id)
        {
            Grupos grupo = new Grupos();
            Contexto contexto = new Contexto();
        
            try
            {
                grupo = contexto.Grupo.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return grupo;
        }

        public static List<Grupos> GetList(Expression<Func<Grupos, bool>> expression)
        {
            List<Grupos> grupo = new List<Grupos>();
            Contexto contexto = new Contexto();

            try
            {
                grupo = contexto.Grupo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return grupo;
        }
    }
}
