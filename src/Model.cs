using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSI
{
    public class LogroID
    {
        //Define si el logro está acabado o sin acabar
        public enum estados { bloqueado, desbloqueado };
        //Define el color
        public Windows.UI.Xaml.Media.Brush color { get; set; }
        //Posición en la lista
        public int Posicion { get; set; }
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
        public LogroID() { }
    }

    public class RankingID
    {
        //Para saber si se ha jugado ya contra el contrincante o no
        public enum estados { player, incompleto, completado }
        //Posición en la lista
        public int Posicion { get; set; }
        //Nombre de los logros
        public string Nombre { get; set; }
        //Tipo de coche que tiene
        public string Coche { get; set; }
        //Fama necesaria o acutal (en caso del player)
        public int Fama { get; set; }
        //Estado actual
        public estados Estado { get; set; }
        public RankingID() { }
    }

    public class Model
    {
        public static List<LogroID> Logros = new List<LogroID>()
        {
            new LogroID()
            {
                Posicion = 0,
                Nombre = "Rápido y Furioso",
                Requisitos = "Completa todos los demás logros",
                Dinero = 100000,
                Fama = 0,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 1,
                Nombre = "Superando límites",
                Requisitos = "Mejora al máximo 10 coches diferentes",
                Dinero = 15000,
                Fama = 300,
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 2,
                Nombre = "Ampliando fronteras",
                Requisitos = "Desbloquea todos los mapas",
                Recompensa = "Dinero: 20.000€ Fama: 100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 3,
                Nombre = "Paparazzis por doquier",
                Requisitos = "Consigue llegar a los 10.000 followers",
                Recompensa = "Dinero: 50.000€",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 4,
                Nombre = "Hundido en la gloria",
                Requisitos = "Llega a 5.000 followers",
                Recompensa = "Dinero: 25.000€",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 5,
                Nombre = "El bueno, el feo y el rápido",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 25.000€ Fama: 100 Followers",
                Estado = LogroID.estados.desbloqueado,
             },

            new LogroID()
            {
                Posicion = 6,
                Nombre = "Como un cohete",
                Requisitos = "Supera los 400 km/h en menos de 3 segundos",
                Recompensa = "Dinero: 10.000€ Fama: 30 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 7,
                Nombre = "El comienzo de una leyenda",
                Requisitos = "Gana tu primera carrera",
                Recompensa = "Dinero: 5.000€ Fama: 10 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 8,
                Nombre = "Como puercos en el oro",
                Requisitos = "Supera todas las carreras callejeras con una medalla de oro",
                Recompensa = "Dinero: 40.000€ Fama: 1.000 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 9,
                Nombre = "Regresa por donde has venido",
                Requisitos = "Provoca la descalificación de un adversario",
                Recompensa = "Dinero: 500€ Fama: 50 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 10,
                Nombre = "Quemando ruedas",
                Requisitos = "Consigue 20 derrapes perfectos en una sola carrera",
                Recompensa = "Dinero: 1.000€ Fama: 50 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 11,
                Nombre = "El más listo de la clase",
                Requisitos = "Arranca de forma perfecta en 5 carreras seguidas",
                Recompensa = "Dinero: 1.000€ Fama: 60 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 12,
                Nombre = "Caballos de fuego",
                Requisitos = "Entra en el top 10 del ranking mundial",
                Recompensa = "Dinero: 6.000€ Fama: 100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

          };

        public static List<RankingID> RankingList = new List<RankingID>() {
            new RankingID()
            {
                Posicion = 0,
                Nombre = "Alfred",
                Coche = "Ferrari F8",
                Fama = 200,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Posicion = 1,
                Nombre = "Alfred",
                Coche = "Ferrari F8",
                Fama = 200,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Posicion = 2,
                Nombre = "Alfred",
                Coche = "Ferrari F8",
                Fama = 200,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Posicion = 3,
                Nombre = "Alfred",
                Coche = "Ferrari F8",
                Fama = 200,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Posicion = 4,
                Nombre = "Alfred",
                Coche = "Ferrari F8",
                Fama = 200,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Posicion = 5,
                Nombre = "Alfred",
                Coche = "Ferrari F8",
                Fama = 200,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Posicion = 6,
                Nombre = "Alfred",
                Coche = "Ferrari F8",
                Fama = 200,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Posicion = 7,
                Nombre = "Alfred",
                Coche = "Ferrari F8",
                Fama = 200,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Posicion = 0,
                Nombre = "Alfred",
                Coche = "Ferrari F8",
                Fama = 200,
                Estado = RankingID.estados.incompleto,
            },
            new RankingID()
            {
                Posicion = 8,
                Nombre = "Stiwi",
                Coche = "",
                Fama = 99999,
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
