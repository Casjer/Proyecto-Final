using SistemaEnvios.DAL;
using SistemaEnvios.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SistemaEnvios.BLL
{
    public class MonedasBLL
    {
        public static bool Guardar(Monedas Moneda)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.Moneda.Add(Moneda) != null)
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



        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Monedas Moneda = contexto.Moneda.Find(id);

                if (Moneda != null)
                {
                    contexto.Entry(Moneda).State = EntityState.Deleted;
                }
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();

                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }



        public static bool Modificar(Monedas Moneda)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(Moneda).State = EntityState.Modified;

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



        public static Monedas Buscar(int id)
        {

            Monedas Moneda = new Monedas();
            Contexto contexto = new Contexto();

            try
            {
                Moneda = contexto.Moneda.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Moneda;

        }



        public static List<Monedas> GetList(Expression<Func<Monedas, bool>> expression)
        {
            List<Monedas> Moneda = new List<Monedas>();
            Contexto contexto = new Contexto();

            try
            {
                Moneda = contexto.Moneda.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return Moneda;
        }

        public static string RetornarTipoMonedas(string nombre)
        {
            string tipomonedas = string.Empty;
            var lista = GetList(x => x.TipoMonedas.Equals(nombre));
            foreach (var item in lista)
            {
                tipomonedas = item.TipoMonedas;
            }

            return tipomonedas;
        }

    }
}
