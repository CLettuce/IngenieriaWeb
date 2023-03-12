using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IngenieriaWeb.Controllers
{
    public class TarjetaController : ApiController
    {
        [Route("api/productos/ListarTodos")]
        [HttpGet]
        public List<Dto> ListProductos()
        {
            var productos = Models.cModel.Productos.ListarProductos()
                .Select(p => new Dto
                {
                    NombreCliente = p.NombreCliente,
                    NombreProducto = p.NombreProducto,
                    Cantidad_Ventas = p.Cantidad_Ventas,
                    Precio = p.Precio,
                    Fecha_Venta = p.Fecha_Venta
                }).OrderBy(p => p.Cantidad_Ventas).ToList();

            return productos;
        }
        [Route("api/productos/ProdNvidia")]
        [HttpGet]
        public List<Dto> SoloN()
        {
            var productos = Models.cModel.Productos.ListarProductos()
                .Where(p => p.NombreProducto.Contains("Nvidia"))
                .Select(p => new Dto
                {
                    NombreCliente = p.NombreCliente,
                    NombreProducto = p.NombreProducto,
                    Cantidad_Ventas = p.Cantidad_Ventas,
                    Precio = p.Precio,
                    Fecha_Venta = p.Fecha_Venta
                }).OrderBy(p => p.Cantidad_Ventas).ToList();
            return productos;
        }
        [Route("api/productos/Precio")]
        [HttpGet]
        public List<Dto> Precio100()
        {
            var productos = Models.cModel.Productos.ListarProductos()
                  .Where(p => p.Precio > 100)
                  .Select(p => new Dto
                  {
                      NombreCliente = p.NombreCliente,
                      NombreProducto = p.NombreProducto,
                      Cantidad_Ventas = p.Cantidad_Ventas,
                      Precio = p.Precio,
                      Fecha_Venta = p.Fecha_Venta
                  }).OrderBy(p => p.Precio).ToList();
            return productos;
        }
        [Route("api/productos/Precio")]
        [HttpGet]
        public List<Dto> Precio100()
        {
            var productos = Models.cModel.Productos.ListarProductos()
               .Select(p => new Dto
                {
                    NombreCliente = p.NombreCliente,
                    NombreProducto = p.NombreProducto,
                    Cantidad_Ventas = p.Cantidad_Ventas,
                    Precio = p.Precio,
                    Fecha_Venta = p.Fecha_Venta
               }).OrderByDescending(p => p.Cantidad_Ventas).Take(10).ToList();
            return productos;
        }
        public class Dto
        {
            public int Cod_Venta;
            public string NombreCliente;
            public string NombreProducto;
            public int Cantidad_Ventas;
            public double Precio;
            public DateTime Fecha_Venta;
        }
    }
}
