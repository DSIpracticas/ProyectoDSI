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
            Id = logro.Id;
            Nombre = logro.Nombre;
            Requisitos = logro.Requisitos;
            Dinero = logro.Dinero;
            Fama = logro.Fama;
            Estado = logro.Estado;
            Imagen = logro.Imagen;
        }
    }

    public class VMRanking : RankingID
    {
        public VMRanking(RankingID ranking)
        {
            Id = ranking.Id;
            Nombre = ranking.Nombre;
            Coche = ranking.Coche;
            Fama = ranking.Fama;
            Estado = ranking.Estado;
            Imagen = ranking.Imagen;
            FamaText = ranking.FamaText;
        }
    }
}
