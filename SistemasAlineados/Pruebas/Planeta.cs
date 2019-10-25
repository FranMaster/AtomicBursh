using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Planeta
    {
        
        public string Nombre { get; set; }
        public int VelocidadAngularDia { get; set; }
        public int DistanciaAlSolEnKilometros { get; set; }
        public double AnguloActual { get; set; }
        public double PosicionX { get; set; }
        public double PosicionY { get; set; }
        public bool SentidoHorario { get; set; }
        public int DiasOrbita { get; set; }


        public Planeta(bool Sentido,int  DistanciaAlSolEnKilometros,string nombre,int Velocidad)
        {
            SentidoHorario = Sentido;
            AnguloActual = 90;
            this.DistanciaAlSolEnKilometros = DistanciaAlSolEnKilometros;
            PosicionY = DistanciaAlSolEnKilometros;
            PosicionX = 0;
            DiasOrbita = 0;
            VelocidadAngularDia = Velocidad;
            Nombre = nombre;

        }

        public void RecalcularPosicion()
        {

            if (SentidoHorario)
                    AnguloActual = 90 - (VelocidadAngularDia* DiasOrbita);
            else
                    AnguloActual = 90 + (VelocidadAngularDia * DiasOrbita);

            PosicionX = (int)(DistanciaAlSolEnKilometros * Math.Cos(AnguloActual*(Math.PI/180)));
            PosicionY = (int)(DistanciaAlSolEnKilometros * Math.Sin(AnguloActual * (Math.PI / 180)));
        }
      




    }
}
