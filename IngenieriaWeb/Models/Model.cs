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
            public int Tarjeta { get; set; }

            public Productos(int Cod_Venta
                , string NombreCliente
                , string NombreProducto
                , int Cantidad_Ventas
                , double Precio
                , DateTime Fecha_Venta
                )
            {
                this.Cod_Venta = Cod_Venta;
                this.NombreCliente = NombreCliente;
                this.NombreProducto = NombreProducto;
                this.Cantidad_Ventas = Cantidad_Ventas;
                this.Precio = Precio;
                this.Fecha_Venta = Fecha_Venta;
            }
            public static List<Productos> ListarProductos()
            {
                return new List<Productos>
                {
                    new Productos(1,"Nvidia Quadro RTX 6000", 200, 50.00, Convert.ToDateTime("2023-05-25")),
                    new Productos(2,"Carlos","Nvidia Titan RTX", 103, 30.00, Convert.ToDateTime("2023-02-18")),
                    new Productos(3,"Miguel","Nvidia GeForce RTX 3090", 1000, 60.00, Convert.ToDateTime("2023-01-10")),
                    new Productos(4,"Angel","Nvidia GeForce RTX 3080", 30, 40.00, Convert.ToDateTime("2021-03-12")),
                    new Productos(5,"Juan","Nvidia GeForce RTX 3070", 203, 90.00, Convert.ToDateTime("2023-01-17")),
                    new Productos(6,"Nvidia GeForce RTX 3060 Ti", 15, 40.00, Convert.ToDateTime("2022-06-11")),
                    new Productos(7,"Rodrigo","AMD Radeon RX 6900 XT", 82, 80.00, Convert.ToDateTime("2021-08-10")),
                    new Productos(8,"Luis","AMD Radeon RX 6800 XT", 181, 90.00, Convert.ToDateTime("2023-07-9")),
                    new Productos(9,"Maria","Nvidia GeForce RTX 3090", 102, 100.00, Convert.ToDateTime("2020-09-21")),
                    new Productos(11,"Juana","Nvidia Quadro RTX 8000", 1, 50.00, Convert.ToDateTime("2023-03-23")),
                    new Productos(12,"Juana","Nvidia GeForce RTX 3080", 120, 50.00, Convert.ToDateTime("2022-05-26")),
                    new Productos(13,"Juana","Nvidia Quadro RTX 8000", 180, 50.00, Convert.ToDateTime("2021-06-24")),
                    new Productos(14,"Juana","Nvidia Titan RTX", 156, 50.00, Convert.ToDateTime("2022-07-29")),
                    new Productos(15,"Juana","Nvidia GeForce RTX 3080", 162, 50.00, Convert.ToDateTime("2023-08-15")),
                    new Productos(16,"Juana","Nvidia Titan RTX", 52, 50.00, Convert.ToDateTime("2023-09-20")),
                    new Productos(17,"Juana","Nvidia GeForce RTX 3060 Ti", 1, 50.00, Convert.ToDateTime("2021-03-30")),
                    new Productos(18,"Juana","Nvidia Quadro RTX 8000", 146, 50.00, Convert.ToDateTime("2022-02-25"))

                };
            }
           
        }
    }
}