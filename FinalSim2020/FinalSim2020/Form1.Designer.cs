﻿namespace FinalSim2020
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabla_estacion = new System.Windows.Forms.DataGridView();
            this.Evento_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prox_llegada_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegada_cliente_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_servicio_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_atencion_combustible_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_at_com1_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_com1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_aten_com2_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_com2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_aten_com3_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_com3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_combustible_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_servicio_posCom_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_aten_gom_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_aten_gom1_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_gom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_aten_gom2_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_gom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_gom_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_aten_acc_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_aten_acc_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_acce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_accesorios_tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.minutos_a_simular = new System.Windows.Forms.TextBox();
            this.desde_min_sim = new System.Windows.Forms.TextBox();
            this.hasta_min_sim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Simular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.desv_normal = new System.Windows.Forms.TextBox();
            this.media_normal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nroB_comb = new System.Windows.Forms.TextBox();
            this.nroA_comb = new System.Windows.Forms.TextBox();
            this.tabla_cliente = new System.Windows.Forms.DataGridView();
            this.numero_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minuto_fuera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nroB_gom = new System.Windows.Forms.TextBox();
            this.nroA_gom = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nroB_acc = new System.Windows.Forms.TextBox();
            this.nroA_acc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.max_cliente = new System.Windows.Forms.TextBox();
            this.max_accesorios = new System.Windows.Forms.TextBox();
            this.max_gomeria = new System.Windows.Forms.TextBox();
            this.max_combustible = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cantidad_cliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_estacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cliente)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabla_estacion
            // 
            this.tabla_estacion.AllowUserToAddRows = false;
            this.tabla_estacion.AllowUserToDeleteRows = false;
            this.tabla_estacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_estacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento_tabla,
            this.reloj_tabla,
            this.prox_llegada_tabla,
            this.llegada_cliente_tabla,
            this.tipo_servicio_tabla,
            this.tiempo_atencion_combustible_tabla,
            this.fin_at_com1_tabla,
            this.estado_com1,
            this.fin_aten_com2_tabla,
            this.estado_com2,
            this.fin_aten_com3_tabla,
            this.estado_com3,
            this.cola_combustible_tabla,
            this.tipo_servicio_posCom_tabla,
            this.tiempo_aten_gom_tabla,
            this.fin_aten_gom1_tabla,
            this.estado_gom1,
            this.fin_aten_gom2_tabla,
            this.estado_gom2,
            this.cola_gom_tabla,
            this.tiempo_aten_acc_tabla,
            this.fin_aten_acc_tabla,
            this.estado_acce,
            this.cola_accesorios_tabla});
            this.tabla_estacion.Location = new System.Drawing.Point(3, 149);
            this.tabla_estacion.Name = "tabla_estacion";
            this.tabla_estacion.ReadOnly = true;
            this.tabla_estacion.Size = new System.Drawing.Size(1382, 304);
            this.tabla_estacion.TabIndex = 1;
            // 
            // Evento_tabla
            // 
            this.Evento_tabla.HeaderText = "Evento";
            this.Evento_tabla.Name = "Evento_tabla";
            this.Evento_tabla.ReadOnly = true;
            // 
            // reloj_tabla
            // 
            this.reloj_tabla.HeaderText = "Reloj";
            this.reloj_tabla.Name = "reloj_tabla";
            this.reloj_tabla.ReadOnly = true;
            // 
            // prox_llegada_tabla
            // 
            this.prox_llegada_tabla.HeaderText = "Prox. Llegada";
            this.prox_llegada_tabla.Name = "prox_llegada_tabla";
            this.prox_llegada_tabla.ReadOnly = true;
            // 
            // llegada_cliente_tabla
            // 
            this.llegada_cliente_tabla.HeaderText = "Llega Cliente";
            this.llegada_cliente_tabla.Name = "llegada_cliente_tabla";
            this.llegada_cliente_tabla.ReadOnly = true;
            // 
            // tipo_servicio_tabla
            // 
            this.tipo_servicio_tabla.HeaderText = "Tipo Servicio";
            this.tipo_servicio_tabla.Name = "tipo_servicio_tabla";
            this.tipo_servicio_tabla.ReadOnly = true;
            // 
            // tiempo_atencion_combustible_tabla
            // 
            this.tiempo_atencion_combustible_tabla.HeaderText = "Tiempo Atencion Comb";
            this.tiempo_atencion_combustible_tabla.Name = "tiempo_atencion_combustible_tabla";
            this.tiempo_atencion_combustible_tabla.ReadOnly = true;
            // 
            // fin_at_com1_tabla
            // 
            this.fin_at_com1_tabla.HeaderText = "Fin atenc. Comb1";
            this.fin_at_com1_tabla.Name = "fin_at_com1_tabla";
            this.fin_at_com1_tabla.ReadOnly = true;
            // 
            // estado_com1
            // 
            this.estado_com1.HeaderText = "Estado";
            this.estado_com1.Name = "estado_com1";
            this.estado_com1.ReadOnly = true;
            // 
            // fin_aten_com2_tabla
            // 
            this.fin_aten_com2_tabla.HeaderText = "Fin atenc. Comb2";
            this.fin_aten_com2_tabla.Name = "fin_aten_com2_tabla";
            this.fin_aten_com2_tabla.ReadOnly = true;
            // 
            // estado_com2
            // 
            this.estado_com2.HeaderText = "Estado";
            this.estado_com2.Name = "estado_com2";
            this.estado_com2.ReadOnly = true;
            // 
            // fin_aten_com3_tabla
            // 
            this.fin_aten_com3_tabla.HeaderText = "Fin atenc. Comb3";
            this.fin_aten_com3_tabla.Name = "fin_aten_com3_tabla";
            this.fin_aten_com3_tabla.ReadOnly = true;
            // 
            // estado_com3
            // 
            this.estado_com3.HeaderText = "Estado";
            this.estado_com3.Name = "estado_com3";
            this.estado_com3.ReadOnly = true;
            // 
            // cola_combustible_tabla
            // 
            this.cola_combustible_tabla.HeaderText = "Cola Combustible";
            this.cola_combustible_tabla.Name = "cola_combustible_tabla";
            this.cola_combustible_tabla.ReadOnly = true;
            // 
            // tipo_servicio_posCom_tabla
            // 
            this.tipo_servicio_posCom_tabla.HeaderText = "Tipo Servicio Pos Comb";
            this.tipo_servicio_posCom_tabla.Name = "tipo_servicio_posCom_tabla";
            this.tipo_servicio_posCom_tabla.ReadOnly = true;
            // 
            // tiempo_aten_gom_tabla
            // 
            this.tiempo_aten_gom_tabla.HeaderText = "Tiempo Atencion Gomeria";
            this.tiempo_aten_gom_tabla.Name = "tiempo_aten_gom_tabla";
            this.tiempo_aten_gom_tabla.ReadOnly = true;
            // 
            // fin_aten_gom1_tabla
            // 
            this.fin_aten_gom1_tabla.HeaderText = "Fin Atencion Gom1";
            this.fin_aten_gom1_tabla.Name = "fin_aten_gom1_tabla";
            this.fin_aten_gom1_tabla.ReadOnly = true;
            // 
            // estado_gom1
            // 
            this.estado_gom1.HeaderText = "Estado";
            this.estado_gom1.Name = "estado_gom1";
            this.estado_gom1.ReadOnly = true;
            // 
            // fin_aten_gom2_tabla
            // 
            this.fin_aten_gom2_tabla.HeaderText = "Fin Atencion Gom2";
            this.fin_aten_gom2_tabla.Name = "fin_aten_gom2_tabla";
            this.fin_aten_gom2_tabla.ReadOnly = true;
            // 
            // estado_gom2
            // 
            this.estado_gom2.HeaderText = "Estado";
            this.estado_gom2.Name = "estado_gom2";
            this.estado_gom2.ReadOnly = true;
            // 
            // cola_gom_tabla
            // 
            this.cola_gom_tabla.HeaderText = "Cola Gomeria";
            this.cola_gom_tabla.Name = "cola_gom_tabla";
            this.cola_gom_tabla.ReadOnly = true;
            // 
            // tiempo_aten_acc_tabla
            // 
            this.tiempo_aten_acc_tabla.HeaderText = "Tiempo Atencion Accesorio";
            this.tiempo_aten_acc_tabla.Name = "tiempo_aten_acc_tabla";
            this.tiempo_aten_acc_tabla.ReadOnly = true;
            // 
            // fin_aten_acc_tabla
            // 
            this.fin_aten_acc_tabla.HeaderText = "Fin Atencion Accesorios ";
            this.fin_aten_acc_tabla.Name = "fin_aten_acc_tabla";
            this.fin_aten_acc_tabla.ReadOnly = true;
            // 
            // estado_acce
            // 
            this.estado_acce.HeaderText = "Estado";
            this.estado_acce.Name = "estado_acce";
            this.estado_acce.ReadOnly = true;
            // 
            // cola_accesorios_tabla
            // 
            this.cola_accesorios_tabla.HeaderText = "Cola Accesorios";
            this.cola_accesorios_tabla.Name = "cola_accesorios_tabla";
            this.cola_accesorios_tabla.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1130, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minutos a simular";
            // 
            // minutos_a_simular
            // 
            this.minutos_a_simular.Location = new System.Drawing.Point(1133, 60);
            this.minutos_a_simular.Name = "minutos_a_simular";
            this.minutos_a_simular.Size = new System.Drawing.Size(100, 20);
            this.minutos_a_simular.TabIndex = 3;
            // 
            // desde_min_sim
            // 
            this.desde_min_sim.Location = new System.Drawing.Point(1077, 102);
            this.desde_min_sim.Name = "desde_min_sim";
            this.desde_min_sim.Size = new System.Drawing.Size(100, 20);
            this.desde_min_sim.TabIndex = 4;
            // 
            // hasta_min_sim
            // 
            this.hasta_min_sim.Location = new System.Drawing.Point(1193, 102);
            this.hasta_min_sim.Name = "hasta_min_sim";
            this.hasta_min_sim.Size = new System.Drawing.Size(100, 20);
            this.hasta_min_sim.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1074, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1198, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta";
            // 
            // Simular
            // 
            this.Simular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Simular.Location = new System.Drawing.Point(1314, 86);
            this.Simular.Name = "Simular";
            this.Simular.Size = new System.Drawing.Size(75, 39);
            this.Simular.TabIndex = 8;
            this.Simular.Text = "Simular";
            this.Simular.UseVisualStyleBackColor = false;
            this.Simular.Click += new System.EventHandler(this.Simular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.desv_normal);
            this.groupBox1.Controls.Add(this.media_normal);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llegada cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Desviacion estandar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Media";
            // 
            // desv_normal
            // 
            this.desv_normal.Location = new System.Drawing.Point(120, 66);
            this.desv_normal.Name = "desv_normal";
            this.desv_normal.Size = new System.Drawing.Size(64, 20);
            this.desv_normal.TabIndex = 11;
            this.desv_normal.Text = "0,38";
            // 
            // media_normal
            // 
            this.media_normal.Location = new System.Drawing.Point(120, 31);
            this.media_normal.Name = "media_normal";
            this.media_normal.Size = new System.Drawing.Size(64, 20);
            this.media_normal.TabIndex = 12;
            this.media_normal.Text = "0,4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nroB_comb);
            this.groupBox2.Controls.Add(this.nroA_comb);
            this.groupBox2.Location = new System.Drawing.Point(232, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carga de combustible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "A";
            // 
            // nroB_comb
            // 
            this.nroB_comb.Location = new System.Drawing.Point(120, 66);
            this.nroB_comb.Name = "nroB_comb";
            this.nroB_comb.Size = new System.Drawing.Size(64, 20);
            this.nroB_comb.TabIndex = 11;
            this.nroB_comb.Text = "0,91";
            // 
            // nroA_comb
            // 
            this.nroA_comb.Location = new System.Drawing.Point(120, 31);
            this.nroA_comb.Name = "nroA_comb";
            this.nroA_comb.Size = new System.Drawing.Size(64, 20);
            this.nroA_comb.TabIndex = 12;
            this.nroA_comb.Text = "0,75";
            // 
            // tabla_cliente
            // 
            this.tabla_cliente.AllowUserToAddRows = false;
            this.tabla_cliente.AllowUserToDeleteRows = false;
            this.tabla_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_cliente,
            this.min_llegada,
            this.minuto_fuera,
            this.diferencia});
            this.tabla_cliente.Location = new System.Drawing.Point(932, 485);
            this.tabla_cliente.Name = "tabla_cliente";
            this.tabla_cliente.ReadOnly = true;
            this.tabla_cliente.Size = new System.Drawing.Size(453, 195);
            this.tabla_cliente.TabIndex = 11;
            // 
            // numero_cliente
            // 
            this.numero_cliente.HeaderText = "Numero Cliente";
            this.numero_cliente.Name = "numero_cliente";
            this.numero_cliente.ReadOnly = true;
            // 
            // min_llegada
            // 
            this.min_llegada.HeaderText = "minuto llegada";
            this.min_llegada.Name = "min_llegada";
            this.min_llegada.ReadOnly = true;
            // 
            // minuto_fuera
            // 
            this.minuto_fuera.HeaderText = "minuto fuera ";
            this.minuto_fuera.Name = "minuto_fuera";
            this.minuto_fuera.ReadOnly = true;
            // 
            // diferencia
            // 
            this.diferencia.HeaderText = "diferencia";
            this.diferencia.Name = "diferencia";
            this.diferencia.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.nroB_gom);
            this.groupBox3.Controls.Add(this.nroA_gom);
            this.groupBox3.Location = new System.Drawing.Point(456, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Atencion Gomería";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "A";
            // 
            // nroB_gom
            // 
            this.nroB_gom.Location = new System.Drawing.Point(120, 66);
            this.nroB_gom.Name = "nroB_gom";
            this.nroB_gom.Size = new System.Drawing.Size(64, 20);
            this.nroB_gom.TabIndex = 11;
            this.nroB_gom.Text = "26";
            // 
            // nroA_gom
            // 
            this.nroA_gom.Location = new System.Drawing.Point(120, 31);
            this.nroA_gom.Name = "nroA_gom";
            this.nroA_gom.Size = new System.Drawing.Size(64, 20);
            this.nroA_gom.TabIndex = 12;
            this.nroA_gom.Text = "10";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.nroB_acc);
            this.groupBox4.Controls.Add(this.nroA_acc);
            this.groupBox4.Location = new System.Drawing.Point(680, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Venta Accesorios";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "A";
            // 
            // nroB_acc
            // 
            this.nroB_acc.Location = new System.Drawing.Point(120, 66);
            this.nroB_acc.Name = "nroB_acc";
            this.nroB_acc.Size = new System.Drawing.Size(64, 20);
            this.nroB_acc.TabIndex = 11;
            this.nroB_acc.Text = "5";
            // 
            // nroA_acc
            // 
            this.nroA_acc.Location = new System.Drawing.Point(120, 31);
            this.nroA_acc.Name = "nroA_acc";
            this.nroA_acc.Size = new System.Drawing.Size(64, 20);
            this.nroA_acc.TabIndex = 12;
            this.nroA_acc.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 558);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Maximo numero de cola en accesorios";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 529);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Maximo numero de cola en gomeria";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 499);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Maximo numero de cola en combustible";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(929, 469);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Tabla de cliente se fueron del sistema";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(453, 529);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(197, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Tiempo maximo de un cliente en sistema";
            // 
            // max_cliente
            // 
            this.max_cliente.Enabled = false;
            this.max_cliente.Location = new System.Drawing.Point(656, 526);
            this.max_cliente.Name = "max_cliente";
            this.max_cliente.Size = new System.Drawing.Size(100, 20);
            this.max_cliente.TabIndex = 20;
            // 
            // max_accesorios
            // 
            this.max_accesorios.Enabled = false;
            this.max_accesorios.Location = new System.Drawing.Point(232, 555);
            this.max_accesorios.Name = "max_accesorios";
            this.max_accesorios.Size = new System.Drawing.Size(100, 20);
            this.max_accesorios.TabIndex = 21;
            // 
            // max_gomeria
            // 
            this.max_gomeria.Enabled = false;
            this.max_gomeria.Location = new System.Drawing.Point(232, 526);
            this.max_gomeria.Name = "max_gomeria";
            this.max_gomeria.Size = new System.Drawing.Size(100, 20);
            this.max_gomeria.TabIndex = 22;
            // 
            // max_combustible
            // 
            this.max_combustible.Enabled = false;
            this.max_combustible.Location = new System.Drawing.Point(232, 496);
            this.max_combustible.Name = "max_combustible";
            this.max_combustible.Size = new System.Drawing.Size(100, 20);
            this.max_combustible.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cantidad_cliente);
            this.groupBox5.Location = new System.Drawing.Point(914, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(145, 65);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cantidad Clientes a Ver";
            // 
            // cantidad_cliente
            // 
            this.cantidad_cliente.Location = new System.Drawing.Point(25, 31);
            this.cantidad_cliente.Name = "cantidad_cliente";
            this.cantidad_cliente.Size = new System.Drawing.Size(64, 20);
            this.cantidad_cliente.TabIndex = 12;
            this.cantidad_cliente.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 727);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.max_combustible);
            this.Controls.Add(this.max_gomeria);
            this.Controls.Add(this.max_accesorios);
            this.Controls.Add(this.max_cliente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabla_cliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Simular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hasta_min_sim);
            this.Controls.Add(this.desde_min_sim);
            this.Controls.Add(this.minutos_a_simular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla_estacion);
            this.Name = "Form1";
            this.Text = "Final Simulacion 2020";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_estacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cliente)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_estacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minutos_a_simular;
        private System.Windows.Forms.TextBox desde_min_sim;
        private System.Windows.Forms.TextBox hasta_min_sim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Simular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox desv_normal;
        private System.Windows.Forms.TextBox media_normal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nroB_comb;
        private System.Windows.Forms.TextBox nroA_comb;
        private System.Windows.Forms.DataGridView tabla_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuto_fuera;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferencia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nroB_gom;
        private System.Windows.Forms.TextBox nroA_gom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nroB_acc;
        private System.Windows.Forms.TextBox nroA_acc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox max_cliente;
        private System.Windows.Forms.TextBox max_accesorios;
        private System.Windows.Forms.TextBox max_gomeria;
        private System.Windows.Forms.TextBox max_combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn prox_llegada_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn llegada_cliente_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_atencion_combustible_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_at_com1_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_com1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_aten_com2_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_com2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_aten_com3_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_com3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_combustible_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio_posCom_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_aten_gom_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_aten_gom1_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_gom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_aten_gom2_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_gom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_gom_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_aten_acc_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_aten_acc_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_acce;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_accesorios_tabla;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox cantidad_cliente;
    }
}

