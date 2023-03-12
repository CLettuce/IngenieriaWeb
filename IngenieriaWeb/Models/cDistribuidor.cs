using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IngenieriaWeb.Models
{
    public abstract class cDistribuidor
    {
        public class Disti
        {
            public int Cod_Dis { get; set; }
            public string NombreEmpresa { get; set; }

            public Disti(int io, string ioy)
            {
                this.Cod_Dis = io;
                this.NombreEmpresa = ioy;
            }

            public static List<Disti> Distribuidores()
            {
                return new List<Disti>
                {
                    new Disti(1, "Nvidia"),
                    new Disti(2, "AMD"),
                    new Disti(3, "ASUS"),
                    new Disti(4, "MSI"),
                    new Disti(6, "EVGA"),
                    new Disti(5, "Gigabyte"),
                    new Disti(7, "Zotac"),
                    new Disti(8, "XFX"),
                    new Disti(9,"PowerColor")
                };
            }
        }
    }
}