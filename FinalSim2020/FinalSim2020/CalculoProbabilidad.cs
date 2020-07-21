using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim2020
{
    public class CalculoProbabilidad
    {
        double normal = 0;
        double desviacionEstandar = 0;
        double nroACombustible = 0;
        double nroBCombustible = 0;
        double nroAGomeria = 0;
        double nroBGomeria = 0;
        double nroAAccesorios = 0;
        double nroBAccesorios = 0;
        double sumaRnd = 0;

        string combustible = "Carga Combustible";
        string gomeria = "Gomería";
        string accesorios = "Accesorios";
        string seRetira = "Se retira";


        Random rnd = new Random();

        public CalculoProbabilidad(double normalCargada, double ds, double Acomb, double Bcomb, double Agom, double Bgom, double Aacce, double Bacc)
        {
            normal = normalCargada;
            desviacionEstandar = ds;
            nroACombustible = Acomb;
            nroBCombustible = Bcomb;
            nroAGomeria = Agom;
            nroBGomeria = Bgom;
            nroAAccesorios = Aacce;
            nroBAccesorios = Bacc;
        }

        public double TruncateFunction(double number, int digit)
        {
            return Math.Truncate((Math.Pow(10.0, (double)digit) * number)) / (Math.Pow(10.0, (double)digit));
        }

        public double LlegadaCliente()
        {
            sumaRnd = 0;

            for (int i = 0; i < 12; i++)
            {
                sumaRnd += this.TruncateFunction(rnd.NextDouble(), 4);
            }
            sumaRnd = this.TruncateFunction(sumaRnd, 4);

            var num = ((sumaRnd - 6) * desviacionEstandar) + normal;

            return num < 0 ? this.TruncateFunction(num * (-1), 4) : this.TruncateFunction(num, 4);
        }

        public double AtencionCombustible()
        {
            var nuevoRnd = this.TruncateFunction(rnd.NextDouble(), 4);

            return this.TruncateFunction(nroACombustible + (nuevoRnd * (nroBCombustible - nroACombustible)), 4);
        }

        public double AtencionGomeria()
        {
            var nuevoRnd = this.TruncateFunction(rnd.NextDouble(), 4);

            return this.TruncateFunction(nroAGomeria + (nuevoRnd * (nroBGomeria - nroAGomeria)), 4);
        }

        public double AtencionAccesorios()
        {
            var nuevoRnd = this.TruncateFunction(rnd.NextDouble(), 4);

            return this.TruncateFunction(nroAAccesorios + (nuevoRnd * (nroBAccesorios - nroAAccesorios)), 4);
        }


        public string TipoServicio()
        {
            var nuevoRnd = this.TruncateFunction(rnd.NextDouble(), 2);
            if (nuevoRnd < 0.80)
            {
                return combustible;
            }
            else
            {
                var otroRnd = this.TruncateFunction(rnd.NextDouble(), 2);
                if (otroRnd < 0.40) return accesorios;
                return gomeria;
            }
        }

        public string PosCargaCombustible()
        {
            var nuevoRnd = this.TruncateFunction(rnd.NextDouble(), 2);

            if (nuevoRnd < 0.30) return accesorios;
            if (nuevoRnd < 0.50) return gomeria;
            return seRetira;
        }



    }
}
