using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEnergiaElectrica
{
    public class Global
    {
        public static List<Annio> Annios = new List<Annio>()
        {
            new Annio(1,2017)
            ,new Annio(1,2018)
        };

        public static List<Tarifa> Tarofas = new List<Tarifa>()
        {
            new Tarifa(1,"Enero",6.5778, 8.7787,  6.4083,  5.2986,  6.9338 ,1)
            ,new Tarifa(2,"Febrero",5.9834,  8.6689 , 6.4673 , 5.258,   6.8998,1)
            ,new Tarifa(3,"Marzo", 6.1222  , 8.5638  ,6.2095 , 5.2553 , 6.8459,1)
            ,new Tarifa(4,"Abril",6.23  ,8.6523,  6.3913 , 5.3598 , 6.8984,1)
            ,new Tarifa(1,"Enero",6.5778, 8.7787,  6.4083,  5.2986,  6.9338 ,2)
            ,new Tarifa(2,"Febrero",5.9834,  5.6689 , 6.4673 , 5.258,   6.8998,2)
            ,new Tarifa(3,"Marzo", 6.1222  , 4.5638  ,6.2095 , 5.2553 , 6.8459,2)
            ,new Tarifa(4,"Abril",6.23  ,2.6523,  6.3913 , 5.3598 , 6.8984,2)
        };

        public class Tarifa
        {
            int id;
            string mes;
            double residencial;
            double comercial;
            double industrial;
            double irrigacion;
            double bombero;
            int idannio;

            public Tarifa(int id, string mes, double residencial, double comercial, double industrial, double irrigacion, double bombero, int idannio)
            {
                this.id = id;
                this.mes = mes;
                this.residencial = residencial;
                this.comercial = comercial;
                this.industrial = industrial;
                this.irrigacion = irrigacion;
                this.bombero = bombero;
                this.Idannio = idannio;
            }

            public int Id { get => id; set => id = value; }
            public string Mes { get => mes; set => mes = value; }
            public double Residencial { get => residencial; set => residencial = value; }
            public double Comercial { get => comercial; set => comercial = value; }
            public double Industrial { get => industrial; set => industrial = value; }
            public double Irrigacion { get => irrigacion; set => irrigacion = value; }
            public double Bombero { get => bombero; set => bombero = value; }
            public int Idannio { get => idannio; set => idannio = value; }
        }

        public class Annio
        {
            int id;
            int valor;

            public Annio(int id, int valor)
            {
                this.id = id;
                this.valor = valor;
            }

            public int Id { get => id; set => id = value; }
            public int Valor { get => valor; set => valor = value; }
        }
    }
}