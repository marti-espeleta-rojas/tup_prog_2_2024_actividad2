﻿namespace ActividadEnElAula2
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxAdministracionComisaria = new System.Windows.Forms.GroupBox();
            this.btnListarIncidentes = new System.Windows.Forms.Button();
            this.btnCreacionComisaria = new System.Windows.Forms.Button();
            this.gbxOperacionesAgente = new System.Windows.Forms.GroupBox();
            this.cbxPlacadeAgente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAdministracionIncidentes = new System.Windows.Forms.GroupBox();
            this.btnRegistrarIncidente = new System.Windows.Forms.Button();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.tbPersona = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.cbxTipoIncidente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxAdministracionGuardias = new System.Windows.Forms.GroupBox();
            this.btnAsignaciondeGuardias = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmNroGuardia = new System.Windows.Forms.NumericUpDown();
            this.nmHoraDesde = new System.Windows.Forms.NumericUpDown();
            this.nmMinutoDesde = new System.Windows.Forms.NumericUpDown();
            this.nmDuracion = new System.Windows.Forms.NumericUpDown();
            this.nmHoraHora = new System.Windows.Forms.NumericUpDown();
            this.nmHoraMinuto = new System.Windows.Forms.NumericUpDown();
            this.gbxAdministracionComisaria.SuspendLayout();
            this.gbxOperacionesAgente.SuspendLayout();
            this.gbxAdministracionIncidentes.SuspendLayout();
            this.gbxAdministracionGuardias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNroGuardia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHoraDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinutoDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHoraHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHoraMinuto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(314, 502);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbxAdministracionComisaria
            // 
            this.gbxAdministracionComisaria.Controls.Add(this.btnListarIncidentes);
            this.gbxAdministracionComisaria.Controls.Add(this.btnCreacionComisaria);
            this.gbxAdministracionComisaria.Location = new System.Drawing.Point(68, 32);
            this.gbxAdministracionComisaria.Name = "gbxAdministracionComisaria";
            this.gbxAdministracionComisaria.Size = new System.Drawing.Size(561, 88);
            this.gbxAdministracionComisaria.TabIndex = 1;
            this.gbxAdministracionComisaria.TabStop = false;
            this.gbxAdministracionComisaria.Text = "Administración Comisaría";
            // 
            // btnListarIncidentes
            // 
            this.btnListarIncidentes.Location = new System.Drawing.Point(419, 19);
            this.btnListarIncidentes.Name = "btnListarIncidentes";
            this.btnListarIncidentes.Size = new System.Drawing.Size(87, 45);
            this.btnListarIncidentes.TabIndex = 1;
            this.btnListarIncidentes.Text = "Listar Incidentes";
            this.btnListarIncidentes.UseVisualStyleBackColor = true;
            this.btnListarIncidentes.Click += new System.EventHandler(this.btnListarIncidentes_Click);
            // 
            // btnCreacionComisaria
            // 
            this.btnCreacionComisaria.Location = new System.Drawing.Point(282, 19);
            this.btnCreacionComisaria.Name = "btnCreacionComisaria";
            this.btnCreacionComisaria.Size = new System.Drawing.Size(87, 45);
            this.btnCreacionComisaria.TabIndex = 0;
            this.btnCreacionComisaria.Text = "Creación Comisaria";
            this.btnCreacionComisaria.UseVisualStyleBackColor = true;
            this.btnCreacionComisaria.Click += new System.EventHandler(this.btnCreacionComisaria_Click);
            // 
            // gbxOperacionesAgente
            // 
            this.gbxOperacionesAgente.Controls.Add(this.cbxPlacadeAgente);
            this.gbxOperacionesAgente.Controls.Add(this.label1);
            this.gbxOperacionesAgente.Controls.Add(this.gbxAdministracionIncidentes);
            this.gbxOperacionesAgente.Controls.Add(this.gbxAdministracionGuardias);
            this.gbxOperacionesAgente.Location = new System.Drawing.Point(68, 142);
            this.gbxOperacionesAgente.Name = "gbxOperacionesAgente";
            this.gbxOperacionesAgente.Size = new System.Drawing.Size(561, 354);
            this.gbxOperacionesAgente.TabIndex = 2;
            this.gbxOperacionesAgente.TabStop = false;
            this.gbxOperacionesAgente.Text = "Operaciones sobre el Agente";
            // 
            // cbxPlacadeAgente
            // 
            this.cbxPlacadeAgente.FormattingEnabled = true;
            this.cbxPlacadeAgente.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxPlacadeAgente.Location = new System.Drawing.Point(117, 20);
            this.cbxPlacadeAgente.Name = "cbxPlacadeAgente";
            this.cbxPlacadeAgente.Size = new System.Drawing.Size(121, 21);
            this.cbxPlacadeAgente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placa de Agente";
            // 
            // gbxAdministracionIncidentes
            // 
            this.gbxAdministracionIncidentes.Controls.Add(this.nmHoraMinuto);
            this.gbxAdministracionIncidentes.Controls.Add(this.nmHoraHora);
            this.gbxAdministracionIncidentes.Controls.Add(this.btnRegistrarIncidente);
            this.gbxAdministracionIncidentes.Controls.Add(this.tbMotivo);
            this.gbxAdministracionIncidentes.Controls.Add(this.tbPersona);
            this.gbxAdministracionIncidentes.Controls.Add(this.tbDNI);
            this.gbxAdministracionIncidentes.Controls.Add(this.lbDNI);
            this.gbxAdministracionIncidentes.Controls.Add(this.cbxTipoIncidente);
            this.gbxAdministracionIncidentes.Controls.Add(this.label8);
            this.gbxAdministracionIncidentes.Controls.Add(this.label7);
            this.gbxAdministracionIncidentes.Controls.Add(this.label6);
            this.gbxAdministracionIncidentes.Controls.Add(this.label5);
            this.gbxAdministracionIncidentes.Location = new System.Drawing.Point(27, 172);
            this.gbxAdministracionIncidentes.Name = "gbxAdministracionIncidentes";
            this.gbxAdministracionIncidentes.Size = new System.Drawing.Size(524, 176);
            this.gbxAdministracionIncidentes.TabIndex = 1;
            this.gbxAdministracionIncidentes.TabStop = false;
            this.gbxAdministracionIncidentes.Text = "Administración de Incidentes";
            // 
            // btnRegistrarIncidente
            // 
            this.btnRegistrarIncidente.Location = new System.Drawing.Point(392, 105);
            this.btnRegistrarIncidente.Name = "btnRegistrarIncidente";
            this.btnRegistrarIncidente.Size = new System.Drawing.Size(117, 24);
            this.btnRegistrarIncidente.TabIndex = 11;
            this.btnRegistrarIncidente.Text = "Registrar Incidente";
            this.btnRegistrarIncidente.UseVisualStyleBackColor = true;
            this.btnRegistrarIncidente.Click += new System.EventHandler(this.btnRegistrarIncidente_Click);
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(108, 109);
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(276, 20);
            this.tbMotivo.TabIndex = 10;
            // 
            // tbPersona
            // 
            this.tbPersona.Location = new System.Drawing.Point(108, 82);
            this.tbPersona.Name = "tbPersona";
            this.tbPersona.Size = new System.Drawing.Size(100, 20);
            this.tbPersona.TabIndex = 9;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(284, 78);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 20);
            this.tbDNI.TabIndex = 8;
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(252, 81);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(26, 13);
            this.lbDNI.TabIndex = 7;
            this.lbDNI.Text = "DNI";
            // 
            // cbxTipoIncidente
            // 
            this.cbxTipoIncidente.FormattingEnabled = true;
            this.cbxTipoIncidente.Items.AddRange(new object[] {
            "Denuncia",
            "Arresto"});
            this.cbxTipoIncidente.Location = new System.Drawing.Point(108, 29);
            this.cbxTipoIncidente.Name = "cbxTipoIncidente";
            this.cbxTipoIncidente.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoIncidente.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Motivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Persona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo Incidente";
            // 
            // gbxAdministracionGuardias
            // 
            this.gbxAdministracionGuardias.Controls.Add(this.nmDuracion);
            this.gbxAdministracionGuardias.Controls.Add(this.nmMinutoDesde);
            this.gbxAdministracionGuardias.Controls.Add(this.nmHoraDesde);
            this.gbxAdministracionGuardias.Controls.Add(this.nmNroGuardia);
            this.gbxAdministracionGuardias.Controls.Add(this.btnAsignaciondeGuardias);
            this.gbxAdministracionGuardias.Controls.Add(this.label4);
            this.gbxAdministracionGuardias.Controls.Add(this.label3);
            this.gbxAdministracionGuardias.Controls.Add(this.label2);
            this.gbxAdministracionGuardias.Location = new System.Drawing.Point(27, 47);
            this.gbxAdministracionGuardias.Name = "gbxAdministracionGuardias";
            this.gbxAdministracionGuardias.Size = new System.Drawing.Size(524, 119);
            this.gbxAdministracionGuardias.TabIndex = 0;
            this.gbxAdministracionGuardias.TabStop = false;
            this.gbxAdministracionGuardias.Text = "Administración de Guardias";
            // 
            // btnAsignaciondeGuardias
            // 
            this.btnAsignaciondeGuardias.Location = new System.Drawing.Point(377, 37);
            this.btnAsignaciondeGuardias.Name = "btnAsignaciondeGuardias";
            this.btnAsignaciondeGuardias.Size = new System.Drawing.Size(102, 50);
            this.btnAsignaciondeGuardias.TabIndex = 3;
            this.btnAsignaciondeGuardias.Text = "Asignación de Guardias";
            this.btnAsignaciondeGuardias.UseVisualStyleBackColor = true;
            this.btnAsignaciondeGuardias.Click += new System.EventHandler(this.btnAsignaciondeGuardias_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Duración en M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro Guardia";
            // 
            // nmNroGuardia
            // 
            this.nmNroGuardia.Location = new System.Drawing.Point(109, 20);
            this.nmNroGuardia.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmNroGuardia.Name = "nmNroGuardia";
            this.nmNroGuardia.Size = new System.Drawing.Size(120, 20);
            this.nmNroGuardia.TabIndex = 8;
            // 
            // nmHoraDesde
            // 
            this.nmHoraDesde.Location = new System.Drawing.Point(109, 46);
            this.nmHoraDesde.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmHoraDesde.Name = "nmHoraDesde";
            this.nmHoraDesde.Size = new System.Drawing.Size(59, 20);
            this.nmHoraDesde.TabIndex = 9;
            // 
            // nmMinutoDesde
            // 
            this.nmMinutoDesde.Location = new System.Drawing.Point(175, 45);
            this.nmMinutoDesde.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmMinutoDesde.Name = "nmMinutoDesde";
            this.nmMinutoDesde.Size = new System.Drawing.Size(54, 20);
            this.nmMinutoDesde.TabIndex = 10;
            // 
            // nmDuracion
            // 
            this.nmDuracion.Location = new System.Drawing.Point(108, 74);
            this.nmDuracion.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmDuracion.Name = "nmDuracion";
            this.nmDuracion.Size = new System.Drawing.Size(120, 20);
            this.nmDuracion.TabIndex = 11;
            // 
            // nmHoraHora
            // 
            this.nmHoraHora.Location = new System.Drawing.Point(108, 56);
            this.nmHoraHora.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmHoraHora.Name = "nmHoraHora";
            this.nmHoraHora.Size = new System.Drawing.Size(59, 20);
            this.nmHoraHora.TabIndex = 12;
            // 
            // nmHoraMinuto
            // 
            this.nmHoraMinuto.Location = new System.Drawing.Point(173, 56);
            this.nmHoraMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmHoraMinuto.Name = "nmHoraMinuto";
            this.nmHoraMinuto.Size = new System.Drawing.Size(54, 20);
            this.nmHoraMinuto.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 568);
            this.Controls.Add(this.gbxOperacionesAgente);
            this.Controls.Add(this.gbxAdministracionComisaria);
            this.Controls.Add(this.btnCerrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxAdministracionComisaria.ResumeLayout(false);
            this.gbxOperacionesAgente.ResumeLayout(false);
            this.gbxOperacionesAgente.PerformLayout();
            this.gbxAdministracionIncidentes.ResumeLayout(false);
            this.gbxAdministracionIncidentes.PerformLayout();
            this.gbxAdministracionGuardias.ResumeLayout(false);
            this.gbxAdministracionGuardias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNroGuardia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHoraDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinutoDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHoraHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHoraMinuto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbxAdministracionComisaria;
        private System.Windows.Forms.GroupBox gbxOperacionesAgente;
        private System.Windows.Forms.GroupBox gbxAdministracionIncidentes;
        private System.Windows.Forms.GroupBox gbxAdministracionGuardias;
        private System.Windows.Forms.Button btnListarIncidentes;
        private System.Windows.Forms.Button btnCreacionComisaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPlacadeAgente;
        private System.Windows.Forms.Button btnAsignaciondeGuardias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoIncidente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarIncidente;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.TextBox tbPersona;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.NumericUpDown nmHoraMinuto;
        private System.Windows.Forms.NumericUpDown nmHoraHora;
        private System.Windows.Forms.NumericUpDown nmDuracion;
        private System.Windows.Forms.NumericUpDown nmMinutoDesde;
        private System.Windows.Forms.NumericUpDown nmHoraDesde;
        private System.Windows.Forms.NumericUpDown nmNroGuardia;
    }
}

