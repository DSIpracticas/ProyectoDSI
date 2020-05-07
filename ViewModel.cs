using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSI
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
