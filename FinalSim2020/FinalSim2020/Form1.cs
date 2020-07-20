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

        string combustible = "Carga Combustible";
        string gomeria = "Gomería";
        string accesorios = "Accesorios";
        string seRetira = "Se retira";

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
        string tipoServicio = "";
        double tiempoAtencionCom = 0;
        double finAtencionCom1 = 0;
        double finAtencionCom2 = 0;
        double finAtencionCom3 = 0;
        int colaCombustible = 0;
        string tipoServicioPostCombustible = "";
        double tiempoAtencionGomeria = 0;
        double finAtencionGom1 = 0;
        double finAtencionGom2 = 0;
        int colaGomeria = 0;
        double tiempoAtencionAccesorios = 0;
        double finAtencionAcessorios = 0;
        int colaAceesorios = 0;

        int i = 0;

        List<Cliente> colaCombustibleconCliente = new List<Cliente>();
        List<Cliente> colaGomeriaconCliente = new List<Cliente>();
        List<Cliente> colaAccesoriosconCliente = new List<Cliente>();
        List<Cliente> grillaconClientesfinalizados = new List<Cliente>();


        Cliente cliente;


        int maxComb = 0;
        int maxGomeria = 0;
        int maxAccesorio = 0;
        double maxDiferencia = 0;








        public Form1()
        {
            InitializeComponent();
        }

        private void Simular_Click(object sender, EventArgs e)
        {
            this.tabla_cliente.Rows.Clear();
            this.tabla_estacion.Rows.Clear();
            this.inicializarValoresIngresados();
            this.validaciones();
        }

        public void validaciones()
        {
            if (hastaSim < desdeSim)
            {
                MessageBox.Show("El parametro DESDE debe ser mayor al parametro HASTA");
                return;
            }

            if ((hastaSim - desdeSim) > 30)
            {
                MessageBox.Show("La diferencia entre los parametros DESDE y HASTA no deben superar el numero 30");
                return;
            }

            if (desdeSim > minutosASimular)
            {
                MessageBox.Show("El parametro DESDE no debe ser mayor al parametro MINUTOS A SIMULAR");
                return;

            }

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


            evento = "";
            reloj = 0;
            proxLlegadaCliente = 0;
            llegaClienteNum = 0;
            tipoServicio = "";
            tiempoAtencionCom = 0;
            finAtencionCom1 = 0;
            finAtencionCom2 = 0;
            finAtencionCom3 = 0;
            colaCombustible = 0;
            tipoServicioPostCombustible = "";
            tiempoAtencionGomeria = 0;
            finAtencionGom1 = 0;
            finAtencionGom2 = 0;
            colaGomeria = 0;
            tiempoAtencionAccesorios = 0;
            finAtencionAcessorios = 0;
            colaAceesorios = 0;

            i = 0;

            colaCombustibleconCliente = new List<Cliente>();
            colaGomeriaconCliente = new List<Cliente>();
            colaAccesoriosconCliente = new List<Cliente>();
            grillaconClientesfinalizados = new List<Cliente>();





            maxComb = 0;
            maxGomeria = 0;
            maxAccesorio = 0;
            maxDiferencia = 0;



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
                    case 1:

                        i++;
                        evento = llegadaCliente;
                        var cliente = new Cliente();
                        cliente.NumeroCliente = i;
                        cliente.MinLlegada = reloj;

                        tipoServicio = proxNum.TipoServicio();

                        if (tipoServicio == combustible)
                        {
                            colaCombustibleconCliente.Add(cliente);
                            colaCombustible++;
                            this.atencionCombustible();
                            tiempoAtencionGomeria = 0;
                            tiempoAtencionAccesorios = 0;
                        }
                        if (tipoServicio == gomeria)
                        {
                            colaGomeriaconCliente.Add(cliente);
                            colaGomeria++;
                            this.atencionGomeria();
                            tiempoAtencionCom = 0;
                            tiempoAtencionAccesorios = 0;
                        }
                        if (tipoServicio == accesorios)
                        {
                            colaAccesoriosconCliente.Add(cliente);
                            colaAceesorios++;
                            this.atencionAccesorios();
                            tiempoAtencionCom = 0;
                            tiempoAtencionGomeria = 0;
                        }

                        proxLlegadaCliente = proxNum.LlegadaCliente();
                        llegaClienteNum = proxLlegadaCliente + reloj;

                     
                        tipoServicioPostCombustible = "";

                        break;

                    //fin atencion combustible
                    case 2:
                        evento = fin_atencion_combustible;

                        var clienteCombustible = colaCombustibleconCliente.First();

                        tipoServicioPostCombustible = proxNum.PosCargaCombustible();

                        if (tipoServicioPostCombustible == seRetira)
                        {
                            clienteCombustible.MinFin = reloj;
                            grillaconClientesfinalizados.Add(clienteCombustible);
                            colaCombustibleconCliente.Remove(clienteCombustible);

                            colaCombustible = colaCombustible < 0 ? 0 : colaCombustible;
                            tiempoAtencionGomeria = 0;
                            tiempoAtencionAccesorios = 0;
                        }
                        if (tipoServicioPostCombustible == gomeria)
                        {
                            colaGomeriaconCliente.Add(clienteCombustible);

                            colaGomeria++;

                            if (finAtencionGom1 == 0 || finAtencionGom2 == 0)
                            {
                                this.atencionGomeria();
                                tiempoAtencionAccesorios = 0;
                            }
                            else
                            {
                                tiempoAtencionAccesorios = 0;
                                tiempoAtencionGomeria = 0;
                            }

                            colaCombustibleconCliente.Remove(clienteCombustible);
                            colaCombustible = colaCombustible < 0 ? 0 : colaCombustible;
                           
                        }
                        if (tipoServicioPostCombustible == accesorios)
                        {
                            colaAccesoriosconCliente.Add(clienteCombustible);
                            colaAceesorios++;

                            if (finAtencionAcessorios == 0)
                            {
                                this.atencionAccesorios();
                                tiempoAtencionGomeria = 0;

                            }
                            else
                            {
                                tiempoAtencionAccesorios = 0;
                                tiempoAtencionGomeria = 0;
                            }
                            colaCombustibleconCliente.Remove(clienteCombustible);
                            colaCombustible = colaCombustible < 0 ? 0 : colaCombustible;
                        }

                        if (colaCombustible > 0)
                        {
                            if (reloj == finAtencionCom1)
                            {
                                tiempoAtencionCom = proxNum.AtencionCombustible();
                                finAtencionCom1 = tiempoAtencionCom + reloj;
                                colaCombustible--;

                            }
                            if (reloj == finAtencionCom2)
                            {
                                tiempoAtencionCom = proxNum.AtencionCombustible();
                                finAtencionCom2 = tiempoAtencionCom + reloj;
                                colaCombustible--;
                            }
                            if (reloj == finAtencionCom3)
                            {
                                tiempoAtencionCom = proxNum.AtencionCombustible();
                                finAtencionCom3 = tiempoAtencionCom + reloj;
                                colaCombustible--;
                            }

                        }
                        else
                        {
                            tiempoAtencionCom = 0;

                            if (reloj == finAtencionCom1)
                            {
                                finAtencionCom1 = 0;

                            }
                            if (reloj == finAtencionCom2)
                            {
                                finAtencionCom2 = 0;

                            }
                            if (reloj == finAtencionCom3)
                            {
                                finAtencionCom3 = 0;

                            }

                        }

                        proxLlegadaCliente = 0;
                        tipoServicio = "";

                        break;

                    //fin atencion gomeria
                    case 3:
                        evento = fin_atenicon_gomeria;
                        var clienteGomeria = colaGomeriaconCliente.First();
                        clienteGomeria.MinFin = reloj;
                        grillaconClientesfinalizados.Add(clienteGomeria);
                        colaAccesoriosconCliente.Remove(clienteGomeria);

                        colaGomeria = colaGomeria < 0 ? 0 : colaGomeria;

                        if (colaGomeria > 0)
                        {
                            if (reloj == finAtencionGom1)
                            {
                                tiempoAtencionGomeria = proxNum.AtencionGomeria();
                                finAtencionGom1 = tiempoAtencionGomeria + reloj;
                                colaGomeria--;

                            }
                            else
                            {
                                tiempoAtencionGomeria = proxNum.AtencionGomeria();
                                finAtencionGom2 = tiempoAtencionGomeria + reloj;
                                colaGomeria--;
                            }

                        }
                        else
                        {
                            tiempoAtencionCom = 0;

                            if (reloj == finAtencionGom1)
                            {
                                finAtencionGom1 = 0;

                            }
                            else
                            {
                                finAtencionGom2 = 0;
                            }

                        }

                        tipoServicio = "";
                        tipoServicioPostCombustible = "";
                        tiempoAtencionCom = 0;
                        tiempoAtencionAccesorios = 0;
                        proxLlegadaCliente = 0;

                        break;


                    //fin atencion accesorios
                    case 4:
                        evento = fin_atencion_accesorios;
                        var clienteAccesorio = colaAccesoriosconCliente.First();
                        clienteAccesorio.MinFin = reloj;
                        grillaconClientesfinalizados.Add(clienteAccesorio);
                        colaAccesoriosconCliente.Remove(clienteAccesorio);

                        colaAceesorios = colaAceesorios < 0 ? 0 : colaAceesorios;

                        if (colaAceesorios > 0)
                        {
                            tiempoAtencionAccesorios = proxNum.AtencionAccesorios();
                            finAtencionAcessorios = tiempoAtencionAccesorios + reloj;
                            colaAceesorios--;

                        }
                        else
                        {
                            tiempoAtencionAccesorios = 0;
                            finAtencionAcessorios = 0;
                        }
                        tipoServicio = "";
                        tipoServicioPostCombustible = "";
                        tiempoAtencionCom = 0;
                        tiempoAtencionGomeria = 0;
                        proxLlegadaCliente = 0;
                        break;
                }


                if (reloj >= desdeSim && reloj <= hastaSim)
                {
                    tabla_estacion.Rows.Add(evento, reloj, proxLlegadaCliente, llegaClienteNum, tipoServicio, tiempoAtencionCom, finAtencionCom1, finAtencionCom2, finAtencionCom3, colaCombustible, tipoServicioPostCombustible, tiempoAtencionGomeria, finAtencionGom1, finAtencionGom2, colaGomeria, tiempoAtencionAccesorios, finAtencionAcessorios, colaAceesorios);

                }

                maxComb = colaCombustible > maxComb ? colaCombustible : maxComb;
                maxGomeria = colaGomeria > maxGomeria ? colaGomeria : maxGomeria;
                maxAccesorio = colaAceesorios > maxAccesorio ? colaAceesorios : maxAccesorio;

            }

            tabla_estacion.Rows.Add(finalizacion, minutosASimular, proxLlegadaCliente, llegaClienteNum, tipoServicio, tiempoAtencionCom, finAtencionCom1, finAtencionCom2, finAtencionCom3, colaCombustible, tipoServicioPostCombustible, tiempoAtencionGomeria, finAtencionGom1, finAtencionGom2, colaGomeria, tiempoAtencionAccesorios, finAtencionAcessorios, colaAceesorios);

            this.llenargrillaCliente();

            max_gomeria.Text = maxGomeria.ToString();
            max_combustible.Text = maxComb.ToString();
            max_accesorios.Text = maxAccesorio.ToString();

            int r = tabla_estacion.Rows.Count;
            tabla_estacion.Rows[r - 1].DefaultCellStyle.ForeColor = Color.FromArgb(156, 0, 6);
            tabla_estacion.Rows[r - 1].DefaultCellStyle.BackColor = Color.Yellow;
            tabla_estacion.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tabla_estacion.Rows[0].DefaultCellStyle.ForeColor = Color.FromArgb(156, 0, 6);
            tabla_estacion.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
            tabla_estacion.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void llenargrillaCliente()
        {
            List<double> diferencias = new List<double>();

            foreach (var cliente in grillaconClientesfinalizados)
            {
                cliente.Diferencia = cliente.MinFin - cliente.MinLlegada;

                tabla_cliente.Rows.Add(cliente.NumeroCliente, cliente.MinLlegada, cliente.MinFin, cliente.Diferencia);

                diferencias.Add(cliente.Diferencia);

            }

            maxDiferencia = diferencias.Max();
            max_cliente.Text = maxDiferencia.ToString();
        }

        public void atencionCombustible()
        {
            if (finAtencionCom1 == 0)
            {
                tiempoAtencionCom = proxNum.AtencionCombustible();
                finAtencionCom1 = tiempoAtencionCom + reloj;
                colaCombustible = colaCombustible - 1;
            }

            else if (finAtencionCom2 == 0)
            {
                tiempoAtencionCom = proxNum.AtencionCombustible();
                finAtencionCom2 = tiempoAtencionCom + reloj;
                colaCombustible = colaCombustible - 1;
            }

            else if (finAtencionCom3 == 0)
            {
                tiempoAtencionCom = proxNum.AtencionCombustible();
                finAtencionCom3 = tiempoAtencionCom + reloj;
                colaCombustible = colaCombustible - 1;
            }

        }

        public void atencionGomeria()
        {
            if (finAtencionGom1 == 0)
            {
                tiempoAtencionGomeria = proxNum.AtencionGomeria();
                finAtencionGom1 = tiempoAtencionGomeria + reloj;
                colaGomeria = colaGomeria - 1;
            }

            else if (finAtencionGom2 == 0)
            {
                tiempoAtencionGomeria = proxNum.AtencionGomeria();
                finAtencionGom2 = tiempoAtencionGomeria + reloj;
                colaGomeria = colaGomeria - 1;
            }

        }

        public void atencionAccesorios()
        {
            if (finAtencionAcessorios == 0)
            {
                tiempoAtencionAccesorios = proxNum.AtencionAccesorios();
                finAtencionAcessorios = tiempoAtencionAccesorios + reloj;
                colaAceesorios = colaAceesorios - 1;
            }

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
