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
    public class EnviosBLL
    {
        private static Usuarios user = new Usuarios();

        public static bool Guardar(Envios Envio)
        {
            bool paso = false;
            Contexto contexto = new Contexto();


            Clientes Cliente = new Clientes();
            try
            {
                if (contexto.Envio.Add(Envio) != null)
                {

                    foreach (var item in Envio.Detalle)
                    {
                        contexto.Moneda.Find(item.MonedasID).Inventario -= item.Cantidad;
                    }


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
                Envios Envio = contexto.Envio.Find(id);


                if (Envio != null)
                {
                    foreach (var item in Envio.Detalle)
                    {
                        contexto.Moneda.Find(item.MonedasID).Inventario += item.Cantidad;

                    }

                    Envio.Detalle.Count();
                    contexto.Envio.Remove(Envio);
                }




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




        public static Envios Buscar(int id)
        {
            Envios Envio = new Envios();
            Contexto contexto = new Contexto();

            try
            {
                Envio = contexto.Envio.Find(id);
                if (Envio != null)
                {
                    Envio.Detalle.Count();

                    foreach (var item in Envio.Detalle)
                    {

                        string s = item.Moneda.TipoMonedas;
                    }

                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Envio;
        }


        public static bool Modificar(Envios Envio)
        {

            bool paso = false;
            Contexto contexto = new Contexto();



            try
            {
                var envio = EnviosBLL.Buscar(Envio.EnviosID);


                if (envio != null)
                {


                    foreach (var item in envio.Detalle)
                    {

                        contexto.Moneda.Find(item.MonedasID).Inventario += item.Cantidad;



                        if (!envio.Detalle.ToList().Exists(v => v.ID == item.ID))
                        {


                            item.Moneda = null;
                            contexto.Entry(item).State = EntityState.Deleted;
                        }



                    }


                    foreach (var item in Envio.Detalle)
                    {
                        contexto.Moneda.Find(item.MonedasID).Inventario -= item.Cantidad;



                        var estado = item.ID > 0 ? EntityState.Modified : EntityState.Added;
                        contexto.Entry(item).State = estado;
                    }

                    contexto.Entry(envio).State = EntityState.Modified;
                }



                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;


        }



        public static List<Envios> GetList(Expression<Func<Envios, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Envios> Envio = new List<Envios>();

            try
            {
                Envio = contexto.Envio.Where(expression).ToList();

                foreach (var item in Envio)
                {
                    item.Detalle.Count();
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Envio;

        }

        public static void NombreLogin(string nombre, int id)
        {
            user.Nombre = nombre;
            user.UsuarioID = id;
        }

        public static Usuarios returnUsuario()
        {
            return user;
        }
        public static decimal CalcularImporte(decimal efectivo, int cantidad)
        {
            return Convert.ToDecimal(efectivo) * Convert.ToInt32(cantidad);
        }



    }
}
