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
        //Posición en la lista
        public int Posicion { get; set; }
        //Nombre de los logros
        public string Nombre { get; set; }
        //Requisitos de los logros
        public string Requisitos { get; set; }
        //Recompensa por el logro
        public string Recompensa { get; set; }
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

    public class KeyID
    {
        public string keyComand_ { get; set; }
        public string keyName_ { get; set; }
        public KeyID() { }
    }

    public class Model
    {

        public static List<KeyID> keys = new List<KeyID>()
        {
            new KeyID()
            {
                keyName_ = "Q",
                keyComand_ = "Unassign"
            },
            new KeyID()
            {
                keyName_ = "W",
                keyComand_ = "Accelerate"
            },
            new KeyID()
            {
                keyName_ = "E",
                keyComand_ = "Gear down"
            },
            new KeyID()
            {
                keyName_ = "R",
                keyComand_ = "Gear up"
            },
            new KeyID()
            {
                keyName_ = "T",
                keyComand_ = "Unassign"
            },
            new KeyID()
            {
                keyName_ = "Y",
                keyComand_ = "Unassign"
            },
            new KeyID()
            {
                keyName_ = "S",
                keyComand_ = "Decelerate"
            },
            new KeyID()
            {
                keyName_ = "UP",
                keyComand_ = "Up movement"
            },
            new KeyID()
            {
                keyName_ = "LEFT",
                keyComand_ = "Left movement"
            },
            new KeyID()
            {
                keyName_ = "DOWN",
                keyComand_ = "Down movement"
            },
            new KeyID()
            {
                keyName_ = "RIGHT",
                keyComand_ = "Right movement"
            },
        };

        public static List<LogroID> Logros = new List<LogroID>()
        {
            new LogroID()
            {
                Posicion = 0,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 1,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 2,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 3,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 4,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 5,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 6,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 7,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 8,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 9,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 10,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 11,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
                Estado = LogroID.estados.bloqueado,
             },

            new LogroID()
            {
                Posicion = 12,
                Nombre = "Rápido y Furioso",
                Requisitos = "Alcanza el primer puesto en 5 carreras consecutivas.",
                Recompensa = "Dinero: 6000€ Fama:100 Followers",
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

        public static IList<KeyID> GetKeyIDs()
        {
            return keys;
        }
    }
}
