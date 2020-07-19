using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSim2020
{
    public partial class Form1 : Form
    {
        //eventos 
        string llegadaCliente = "Llegada_cliente";
        string fin_atencion_combustible = "Fin_atencion_combustible";
        string fin_atencion_accesorios = "Fin_atencion_accesorios";
        string fin_atenicon_gomeria = "Fin_atencion_gomeria";
        string inicializacion = "Inicializacion";
        string finalizacion = "Fin de simulacion";

        //declaracion de variable para calculo de probabilidades 
        CalculoProbabilidad proxNum;

        //carga de datos
        double minutosASimular = 0;
        double desdeSim = 0;
        double hastaSim = 0;
        double normalIn = 0;
        double dsIn = 0;
        double nAcomb = 0;
        double nBcomb = 0;
        double nAgom = 0;
        double nBgom = 0;
        double nAacc = 0;
        double nBacc = 0;

        //datos grilla 
        string evento = "";
        double reloj = 0;
        double proxLlegadaCliente = 0;
        double llegaClienteNum = 0;
        double tipoServicio = 0;
        double tiempoAtencionCom = 0;
        double finAtencionCom1 = 0;
        double finAtencionCom2 = 0;
        double finAtencionCom3 = 0;
        double colaCombustible = 0;
        string tipoServicioPostCombustible = "";
        double tiempoAtencionGomeria = 0;
        double finAtencionGom1 = 0;
        double finAtencionGom2 = 0;
        double colaGomeria = 0;
        double tiempoAtencionAccesorios = 0;
        double finAtencionAcessorios = 0;
        double colaAceesorios = 0;


        List<Cliente> colaCombustibleconCliente = new List<Cliente>();
        List<Cliente> colaGomeriaconCliente = new List<Cliente>();
        List<Cliente> colaAccesoriosconCliente = new List<Cliente>();
        List<Cliente> grillaconClientesfinalizados = new List<Cliente>();


        Cliente cliente;








        public Form1()
        {
            InitializeComponent();
        }

        private void Simular_Click(object sender, EventArgs e)
        {
            this.inicializarValoresIngresados();
            this.iniciarSimulacion();


        }

        public void inicializarValoresIngresados()
        {
            normalIn = double.Parse(media_normal.Text);
            dsIn = double.Parse(desv_normal.Text);
            nAcomb = double.Parse(nroA_comb.Text);
            nBcomb = double.Parse(nroB_comb.Text);
            nAgom = double.Parse(nroA_gom.Text);
            nBgom = double.Parse(nroB_gom.Text);
            nAacc = double.Parse(nroA_acc.Text);
            nBacc = double.Parse(nroB_acc.Text);

            proxNum = new CalculoProbabilidad(normalIn, dsIn, nAcomb, nBcomb, nAgom, nBgom, nAacc, nBacc);

            minutosASimular = double.Parse(minutos_a_simular.Text);
            desdeSim = double.Parse(desde_min_sim.Text);
            hastaSim = double.Parse(hasta_min_sim.Text);


        }

        public void iniciarSimulacion()
        {
            proxLlegadaCliente = proxNum.LlegadaCliente();
            llegaClienteNum = proxLlegadaCliente;

            tabla_estacion.Rows.Add(inicializacion, reloj, proxLlegadaCliente, llegaClienteNum, tipoServicio, tiempoAtencionCom, finAtencionCom1, finAtencionCom2, finAtencionCom3, colaCombustible, tipoServicioPostCombustible, tiempoAtencionGomeria, finAtencionGom1, finAtencionGom2, colaGomeria, tiempoAtencionAccesorios, finAtencionAcessorios, colaAceesorios);

            while (reloj <= minutosASimular)
            {
                this.proximoEvento();
                var valorSwitch = this.nombreEvento();
                switch (valorSwitch)
                {
                    //llegada cliente
                    case 1: break;
                    //fin atencion combustible
                    case 2: break;
                    //fin atencion gomeria
                    case 3: break;
                    //fin atencion accesorios
                    case 4: break;
                }
                if (reloj >= desdeSim && reloj <= hastaSim)
                {
                    tabla_estacion.Rows.Add(inicializacion, reloj, proxLlegadaCliente, llegaClienteNum, tipoServicio, tiempoAtencionCom, finAtencionCom1, finAtencionCom2, finAtencionCom3, colaCombustible, tipoServicioPostCombustible, tiempoAtencionGomeria, finAtencionGom1, finAtencionGom2, colaGomeria, tiempoAtencionAccesorios, finAtencionAcessorios, colaAceesorios);

                }

            }

            tabla_estacion.Rows.Add(inicializacion, reloj, proxLlegadaCliente, llegaClienteNum, tipoServicio, tiempoAtencionCom, finAtencionCom1, finAtencionCom2, finAtencionCom3, colaCombustible, tipoServicioPostCombustible, tiempoAtencionGomeria, finAtencionGom1, finAtencionGom2, colaGomeria, tiempoAtencionAccesorios, finAtencionAcessorios, colaAceesorios);

        }

        public void proximoEvento()
        {
            List<double> num = new List<double>();

            if (llegaClienteNum != 0) num.Add(llegaClienteNum);
            if (finAtencionCom1 != 0) num.Add(finAtencionCom1);
            if (finAtencionCom2 != 0) num.Add(finAtencionCom2);
            if (finAtencionCom3 != 0) num.Add(finAtencionCom3);
            if (finAtencionGom1 != 0) num.Add(finAtencionGom1);
            if (finAtencionGom2 != 0) num.Add(finAtencionGom2);
            if (finAtencionAcessorios != 0) num.Add(finAtencionAcessorios);
            reloj = num.Min();

        }

        public int nombreEvento()
        {
            if (reloj == llegaClienteNum) return 1;
            if (reloj == finAtencionCom1) return 2;
            if (reloj == finAtencionCom2) return 2;
            if (reloj == finAtencionCom3) return 2;
            if (reloj == finAtencionGom1) return 3;
            if (reloj == finAtencionGom2) return 3;
            return 4;

        }
    }
}
