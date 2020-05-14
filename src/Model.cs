using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoDSI
{
    public class LogroID
    {
        //Define si el logro está acabado o sin acabar
        public enum estados { bloqueado, desbloqueado, cobrado };
        //Posición en la lista
        public int Id { get; set; }
        //Nombre de los logros
        public string Nombre { get; set; }
        //Requisitos de los logros
        public string Requisitos { get; set; }
        //Recompensa por el logro
        public int Dinero { get; set; }
        //Recompensa por el logro
        public int Fama { get; set; }
        //Estado actual
        public estados Estado { get; set; }
        //Muestra la recompensa
        public string Recompensa { get; set; }
        //Imagen de fondo
        public string Imagen { get; set; }
        public LogroID() { }
    }

    public class RankingID
    {
        //Para saber si se ha jugado ya contra el contrincante o no
        public enum estados { player, incompleto, completado, siguiente }
        //Posición en la lista
        public int Id { get; set; }
        //Nombre de los logros
        public string Nombre { get; set; }
        //Tipo de coche que tiene
        public string Coche { get; set; }
        //Fama necesaria o acutal (en caso del player)
        public int Fama { get; set; }
        //Muestra el texto de la fama
        public string FamaText { get; set; }
        //Estado actual
        public estados Estado { get; set; }
        //Imagen de fondo
        public string Imagen { get; set; }
        public RankingID() { }
    }

    public class Model
    {
        public static List<LogroID> Logros = new List<LogroID>()
        {
            new LogroID()
            {
                Nombre = "Rápido y Furioso",
                Requisitos = "Completa todos los demás logros",
                Dinero = 100000,
                Fama = 0,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Nombre = "Superando límites",
                Requisitos = "Mejora al máximo 10 coches diferentes",
                Dinero = 15000,
                Fama = 300,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Nombre = "Ampliando fronteras",
                Requisitos = "Desbloquea todos los mapas",
                Dinero = 20000,
                Fama = 100,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Nombre = "Paparazzis por doquier",
                Requisitos = "Consigue llegar a los 10.000 followers",
                Dinero = 50000,
                Fama = 0,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Nombre = "Hundido en la gloria",
                Requisitos = "Llega a 5.000 followers",
                Dinero = 25000,
                Fama = 0,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Nombre = "El bueno, el feo y el rápido",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Dinero = 25000,
                Fama = 100,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Nombre = "Como un cohete",
                Requisitos = "Supera los 400 km/h en menos de 3 segundos",
                Dinero = 10000,
                Fama = 30,
                Estado = LogroID.estados.cobrado,
             },

            new LogroID()
            {
                Nombre = "El comienzo de una leyenda",
                Requisitos = "Gana tu primera carrera",
                Dinero = 5000,
                Fama = 10,
                Estado = LogroID.estados.cobrado,
             },

            new LogroID()
            {
                Nombre = "Como puercos en el oro",
                Requisitos = "Supera todas las carreras callejeras con una medalla de oro",
                Dinero = 40000,
                Fama = 1000,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Nombre = "Regresa por donde has venido",
                Requisitos = "Provoca la descalificación de un adversario",
                Dinero = 500,
                Fama = 50,
                Estado = LogroID.estados.cobrado,
             },

            new LogroID()
            {
                Nombre = "Quemando ruedas",
                Requisitos = "Consigue 20 derrapes perfectos en una sola carrera",
                Dinero = 1000,
                Fama = 50,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Nombre = "El más listo de la clase",
                Requisitos = "Arranca de forma perfecta en 5 carreras seguidas",
                Dinero = 1000,
                Fama = 60,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Nombre = "Caballos de fuego",
                Requisitos = "Entra en el top 10 del ranking mundial",
                Dinero = 6000,
                Fama = 100,
                Estado = LogroID.estados.bloqueado,
             },

          };

        public static List<RankingID> RankingList = new List<RankingID>() {
            new RankingID()
            {
                Nombre = "Goku",
                Coche = "Kinton Cloud",
                Fama = 10000,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Nombre = "Alfred",
                Coche = "Batmovil",
                Fama = 9000,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Nombre = "Picolo",
                Coche = "Techrules Ren",
                Fama = 8000,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Nombre = "Chaos",
                Coche = "Audi TT",
                Fama = 6000,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Nombre = "Mocho",
                Coche = "NIO EP9 ",
                Fama = 5000,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Nombre = "Ricolino",
                Coche = "Koenigsegg Agera RS",
                Fama = 4000,
                Estado = RankingID.estados.siguiente,
            },
            new RankingID()
            {
                Nombre = "Venancio",
                Coche = "Koenigsegg One:1 ",
                Fama = 3000,
                Estado = RankingID.estados.completado,
            },
            new RankingID()
            {
                Nombre = "Mutenroshi",
                Coche = "Rimac Concept_S",
                Fama = 2000,
                Estado = RankingID.estados.completado,
            },
            new RankingID()
            {
                Nombre = "Krilin",
                Coche = "Bugatti Chiron",
                Fama = 1000,
                Estado = RankingID.estados.completado,
            },
            new RankingID()
            {
                Nombre = "Stiwi",
                Coche = "",
                Fama = 4050,
                Estado = RankingID.estados.player,
            },
        };

        public static IList<LogroID> GetAllLogros()
        {
            return Logros;
        }

        public static IList<RankingID> GetAllRanking()
        {
            return RankingList;
        }
        public static LogroID GetLogroBy(int id)
        {
            return Logros[id];
        }
    }
}
