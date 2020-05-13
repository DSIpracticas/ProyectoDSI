using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocheDSI
{
    public class CarID
    {
        //Define si el coche está comprado o no
        public enum estados { bloqueado, desbloqueado };
        //Estado actual
        public estados Estado { get; set; }
        //Posición en la lista
        public int Posicion { get; set; }
        //Coste de compra
        public int Coste { get; set; }
        //Nombre del coche
        public string Nombre { get; set; }
        //Source del coche
        public string Source { get; set; }
        //Gama del coche
        public int Gama { get; set; }
        //PROPIEDADES
        //Gama del coche
        public int Velocidad { get; set; }
        //Gama del coche
        public int Aceleracion { get; set; }
        //Gama del coche
        public int Suspension { get; set; }
        //Gama del coche
        public int Aerodinamica { get; set; }
        //Gama del coche
        public int Agarre { get; set; }
        //MEJORAS
        //Nivel de mejora de turbo (aceleracion)
        public int Turbo { get; set; }
        //Nivel de mejora de motor (velocidad)
        public int Motor { get; set; }
        //Nivel de mejora de amortiguadores (suspension)
        public int Amortiguador { get; set; }
        //Nivel de mejora de neumaticos (agarre)
        public int Neumaticos { get; set; }
        //Nivel de mejora de carroceria (aerodinamica)
        public int Carroceria { get; set; }
        public CarID() { }
    }

    public class CarModel
    {
        public static List<CarID> Cars = new List<CarID>()
        {
            new CarID()
            {
                Posicion = 0,
                Nombre = "Ferrari 599XX Dogde Charger",
                Source = "/Assets/Cars/Coche1.png",
                //Gama
                Gama = 1,
                Coste = 100,
                //Caracteristicas
                Velocidad = 12, Aceleracion = 15, Aerodinamica = 12, Agarre = 18, Suspension = 12,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.desbloqueado,
            },

            new CarID()
            {
                Posicion = 1,
                Nombre = "Ferrari 458 Pagani Huayra",
                Source = "/Assets/Cars/Coche2.png",
                //Gama
                Gama = 1,
                Coste = 200,
                //Caracteristicas
                Velocidad = 18, Aceleracion = 10, Aerodinamica = 12, Agarre = 14, Suspension = 16,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.desbloqueado,
            },

            new CarID()
            {
                Posicion = 2,
                Nombre = "Chevrolet Corvette",
                Source = "/Assets/Cars/Coche3.png",
                //Gama
                Gama = 2,
                Coste = 300,
                //Caracteristicas
                Velocidad = 28, Aceleracion = 22, Aerodinamica = 24, Agarre = 25, Suspension = 28,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },

            new CarID()
            {
                Posicion = 3,
                Nombre = "Ford Mustang Mach 1",
                Source = "/Assets/Cars/Coche4.png",
                //Gama
                Gama = 2,
                Coste = 400,
                //Caracteristicas
                Velocidad = 24, Aceleracion = 22, Aerodinamica = 28, Agarre = 26, Suspension = 24,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },
            new CarID()
            {
                Posicion = 4,
                Nombre = "Pontiac Firebird GTO",
                Source = "/Assets/Cars/Coche5.png",
                //Gama
                Gama = 2,
                Coste = 500,
                //Caracteristicas
                Velocidad = 28, Aceleracion = 25, Aerodinamica = 20, Agarre = 25, Suspension = 22,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },
            new CarID()
            {
                Posicion = 5,
                Nombre = "Honda Civic Type R",
                Source = "/Assets/Cars/Coche6.png",
                //Gama
                Gama = 3,
                Coste = 600,
                //Caracteristicas
                Velocidad = 36, Aceleracion = 35, Aerodinamica = 34, Agarre = 39, Suspension = 34,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },
            new CarID()
            {
                Posicion = 6,
                Nombre = "Pagani Huayra",
                Source = "/Assets/Cars/Coche7.png",
                //Gama
                Gama = 3,
                Coste = 700,
                //Caracteristicas
                Velocidad = 38, Aceleracion = 32, Aerodinamica = 31, Agarre = 36, Suspension = 37,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },
            new CarID()
            {
                Posicion = 7,
                Nombre = "Toyota Supra Nissan Skyline",
                Source = "/Assets/Cars/Coche8.png",
                //Gama
                Gama = 3,
                Coste = 800,
                //Caracteristicas
                Velocidad = 38, Aceleracion = 33, Aerodinamica = 38, Agarre = 34, Suspension = 32,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },
            new CarID()
            {
                Posicion = 8,
                Nombre = "Mini Cooper E",
                Source = "/Assets/Cars/Coche9.png",
                //Gama
                Gama = 4,
                Coste = 900,
                //Caracteristicas
                Velocidad = 28, Aceleracion = 35, Aerodinamica = 11, Agarre = 16, Suspension = 24,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },
            new CarID()
            {
                Posicion = 9,
                Nombre = "Dodge Ram Pickup",
                Source = "/Assets/Cars/Coche10.png",
                //Gama
                Gama = 4,
                Coste = 1000,
                //Caracteristicas
                Velocidad = 28, Aceleracion = 35, Aerodinamica = 11, Agarre = 16, Suspension = 24,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },
            new CarID()
            {
                Posicion = 10,
                Nombre = "Chevrolet Camaro Yenko",
                Source = "/Assets/Cars/Coche11.png",
                //Gama
                Gama = 4,
                Coste = 1100,
                //Caracteristicas
                Velocidad = 28, Aceleracion = 35, Aerodinamica = 11, Agarre = 16, Suspension = 24,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },
            new CarID()
            {
                Posicion = 11,
                Nombre = "Aston Martin DB5",
                Source = "/Assets/Cars/Coche12.png",
                //Gama
                Gama = 5,
                Coste = 1200,
                //Caracteristicas
                Velocidad = 28, Aceleracion = 35, Aerodinamica = 11, Agarre = 16, Suspension = 24,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },
            new CarID()
            {
                Posicion = 12,
                Nombre = "Batmovil",
                Source = "/Assets/Cars/Coche13.png",
                //Gama
                Gama = 5,
                Coste = 1300,
                //Caracteristicas
                Velocidad = 28, Aceleracion = 35, Aerodinamica = 11, Agarre = 16, Suspension = 24,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            }
    };
        public static IList<CarID> GetAllCars()
        {
            return Cars;
        }
    }
}

namespace LogroDSI
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

    public class LogroModel
    {
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
        public static IList<LogroID> GetAllLogros()
        {
            return Logros;
        }
        public static LogroID GetLogroBy(int id)
        {
            return Logros[id];
        }
    }
}

namespace RankingDSI
{
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

    public class RankingModel {

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
        public static IList<RankingID> GetAllRanking()
        {
           return RankingList;
        }
    }
}


