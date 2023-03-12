using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IngenieriaWeb.Models
{
    public abstract class Cmarca
    {
        public class Disti
        {
            public int Id { get; set; }
            public string N_Marca { get; set; }
            public string Modelo { get; }


            public Disti(int Id, string N_Marca, string Modelo)
            {
                this.Id = Id;
                this.N_Marca = N_Marca;
                this.Modelo = Modelo;

            }
            public static List<Disti> Marca12()
            {
                return new List<Disti>
                {
                    new Disti(1,"Intel","I3"),
                    new Disti(2,"AMD","HQ"),
                    new Disti(3,"CR","JK")
                };
            
            }
        }
    }
    
}