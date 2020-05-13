using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocheDSI
{
    public class VMCar : CarID
    {
        public VMCar(CarID car)
        {
            Posicion = car.Posicion;
            Nombre = car.Nombre;
            Source = car.Source;
            Gama = car.Gama;
            Coste = car.Coste;

            Velocidad = car.Velocidad;
            Agarre = car.Agarre;
            Suspension = car.Suspension;
            Aceleracion = car.Aceleracion;
            Aerodinamica = car.Aerodinamica;

            Turbo = car.Turbo;
            Motor = car.Motor;
            Amortiguador = car.Amortiguador;
            Neumaticos = car.Neumaticos;
            Carroceria = car.Carroceria;

            Estado = car.Estado;
        }
    }
}

namespace LogroDSI
{
    public class VMLogro : LogroID
    {
        public VMLogro(LogroID logro)
        {
            Posicion = logro.Posicion;
            Nombre = logro.Nombre;
            Requisitos = logro.Requisitos;
            Recompensa = logro.Recompensa;
            Estado = logro.Estado;
        }
    }
}

namespace RankingDSI
{
    public class VMRanking : RankingID
    {
        public VMRanking(RankingID ranking)
        {
            Posicion = ranking.Posicion;
            Nombre = ranking.Nombre;
            Coche = ranking.Coche;
            Fama = ranking.Fama;
            Estado = ranking.Estado;
        }
    }
}
