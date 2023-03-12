using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public abstract class Model
    {
        public class Productos
        {
            public int Cod_Venta { get; set; }
            public string NombreCliente { get; set; }
            public string NombreProducto { get; set; }
            public int Cantidad_Ventas { get; set; }
            public double Precio { get; set; }
            public DateTime Fecha_Venta { get; set; }

            public Productos(int Cod_Venta, string NombreCliente, string NombreProducto, int Cantidad_Ventas, double Precio, DateTime Fecha_Venta)
            {
                //this.Cod_Venta = Cod_Venta;
                //this.NombreCliente = NombreCliente;
                //this.NombreProducto = NombreProducto;
                //this.Cantidad_Ventas = Cantidad_Ventas;
                //this.Precio = Precio;
                //this.Fecha_Venta = Fecha_Venta;
            }
            public static List<Productos> ListarProductos()
            {
                return new List<Productos>
                {
                    new Productos(1,"Pedro", "Miel de Abeja", 550, 50.00, Convert.ToDateTime("2023-05-20")),
                    new Productos(2,"Carlos","Crema la Perfecta", 820, 20.00, Convert.ToDateTime("2023-02-10"))

                };
            }

        }
    }

}