﻿using Agrosoft.DAL;
using Agrosoft.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Agrosoft.BLL
{
    public class CompraProductosBLL
    {
        public static void AgregarCantidad(CompraProductos compra)
        {
            RepositorioBase<Productos> Metodos = new RepositorioBase<Productos>();

            foreach (var item in compra.CompraProductosDetalle)
            {
                Productos productos = Metodos.Buscar(item.ProductoId);
                productos.CantidadExistente += item.Cantidad;
                Metodos.Modificar(productos);
            } 
        }

        public static void RestarCantidad(CompraProductos compra)
        {
            RepositorioBase<Productos> Metodos = new RepositorioBase<Productos>();
            CompraProductos compraAnterior = CompraProductosBLL.Buscar(compra.CompraId);

            foreach (var item in compraAnterior.CompraProductosDetalle)
            {
                Productos productos = Metodos.Buscar(item.ProductoId);
                productos.CantidadExistente -= item.Cantidad;
                Metodos.Modificar(productos);
            }
        }

        public static bool Guardar(CompraProductos compra)
        {
            if (!Existe(compra.CompraId))
                return Insertar(compra);
            else
            {
                return Modificar(compra);
            }
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();

            try
            {
                encontrado = db.CompraProductos.Any(x => x.CompraId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }

        public static bool Insertar(CompraProductos compra)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.CompraProductos.Add(compra);
                AgregarCantidad(compra);

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(CompraProductos compra)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Productos> repositorioProductos = new RepositorioBase<Productos>();

            var compraAnterior = Buscar(compra.CompraId);

            try
            {
                foreach (var item in compraAnterior.CompraProductosDetalle)
                {
                    var producto = repositorioProductos.Buscar(item.ProductoId);
                    producto.CantidadExistente -= item.Cantidad;
                    repositorioProductos.Modificar(producto);
                }

                foreach (var item in compra.CompraProductosDetalle)
                {
                    if (item.Id == 0)
                        db.Entry(item).State = EntityState.Added;
                }

                foreach (var item in compraAnterior.CompraProductosDetalle)
                {
                    if (!compra.CompraProductosDetalle.Any(A => A.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;
                }

                db.Entry(compra).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

                foreach (var item in compra.CompraProductosDetalle)
                {
                    var producto = repositorioProductos.Buscar(item.ProductoId);
                    producto.CantidadExistente += item.Cantidad;
                    repositorioProductos.Modificar(producto);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            RepositorioBase<Productos> Metodos = new RepositorioBase<Productos>();
            CompraProductos compra = CompraProductosBLL.Buscar(id);

            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (compra != null)
                {
                    foreach (var item in compra.CompraProductosDetalle)
                    {
                        Productos productos = Metodos.Buscar(item.ProductoId);
                        productos.CantidadExistente -= item.Cantidad;
                        Metodos.Modificar(productos);
                    }

                    db.CompraProductos.Remove(compra);
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static CompraProductos Buscar(int id)
        {
            Contexto db = new Contexto();
            CompraProductos compra = new CompraProductos();

            try
            {
                compra = db.CompraProductos
                    .Where(e => e.CompraId == id)
                    .Include(e => e.CompraProductosDetalle)
                    .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return compra;
        }

        public static List<CompraProductos> GetList(Expression<Func<CompraProductos, bool>> criterio)
        {
            List<CompraProductos> lista = new List<CompraProductos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.CompraProductos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
