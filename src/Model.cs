using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
                Turbo = 3, Motor = 0, Carroceria = 2, Neumaticos = 1, Amortiguador = 0,
                Estado = CarID.estados.desbloqueado,
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
                Velocidad = 48, Aceleracion = 45, Aerodinamica = 41, Agarre = 46, Suspension = 44,
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
                Velocidad = 42, Aceleracion = 43, Aerodinamica = 49, Agarre = 41, Suspension = 47,
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
                Velocidad = 46, Aceleracion = 42, Aerodinamica = 43, Agarre = 47, Suspension = 43,
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
                Velocidad = 58, Aceleracion = 53, Aerodinamica = 55, Agarre = 59, Suspension = 58,
                //Nivel de las mejoras
                Turbo = 0, Motor = 0, Carroceria = 0, Neumaticos = 0, Amortiguador = 0,
                Estado = CarID.estados.bloqueado,
            },
            new CarID()
            {
                Posicion = 12,
                Nombre = "BATMOVIL",
                Source = "/Assets/Cars/Coche13.png",
                //Gama
                Gama = 5,
                Coste = 1300,
                //Caracteristicas
                Velocidad = 75, Aceleracion = 75, Aerodinamica = 75, Agarre = 75, Suspension = 75,
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

        public static IList<KeyID> GetKeyIDs()
        {
            return keys;
        }
    }
}
