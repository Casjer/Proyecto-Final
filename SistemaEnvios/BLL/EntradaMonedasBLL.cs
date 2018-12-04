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
    public class EntradaMonedasBLL
    {
        public static bool Guardar(EntradaMonedas entradaMoneda)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.entradaMoneda.Add(entradaMoneda) != null)
                {
                    Monedas moneda = BLL.MonedasBLL.Buscar(entradaMoneda.MonedasID);
                    moneda.Inventario += entradaMoneda.Cantidad;
                    BLL.MonedasBLL.Modificar(moneda);

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
                EntradaMonedas entradaMoneda = contexto.entradaMoneda.Find(id);

                if (entradaMoneda != null)
                {
                    Monedas moneda = BLL.MonedasBLL.Buscar(entradaMoneda.MonedasID);
                    moneda.Inventario -= entradaMoneda.Cantidad;
                    BLL.MonedasBLL.Modificar(moneda);

                    contexto.Entry(entradaMoneda).State = EntityState.Deleted;
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



        public static bool Modificar(EntradaMonedas entradaMoneda)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                EntradaMonedas ant = BLL.EntradaMonedasBLL.Buscar(entradaMoneda.EntradaID);
                int resta;
                resta = entradaMoneda.Cantidad - ant.Cantidad;

                Monedas moneda = BLL.MonedasBLL.Buscar(entradaMoneda.MonedasID);
                moneda.Inventario += resta;
                BLL.MonedasBLL.Modificar(moneda);

                contexto.Entry(entradaMoneda).State = EntityState.Modified;

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




        public static EntradaMonedas Buscar(int id)
        {

            EntradaMonedas entradaMoneda = new EntradaMonedas();
            Contexto contexto = new Contexto();

            try
            {
                entradaMoneda = contexto.entradaMoneda.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return entradaMoneda;

        }



        public static List<EntradaMonedas> GetList(Expression<Func<EntradaMonedas, bool>> expression)
        {
            List<EntradaMonedas> entradaMoneda = new List<EntradaMonedas>();
            Contexto contexto = new Contexto();

            try
            {
                entradaMoneda = contexto.entradaMoneda.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return entradaMoneda;
        }
    }
}
