﻿namespace Inicio
{
    partial class Horario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelHorarioTitulo = new System.Windows.Forms.Label();
            this.panelHorarioVertical = new System.Windows.Forms.Panel();
            this.textHorarioBuscar = new System.Windows.Forms.TextBox();
            this.labelHorarioBuscar = new System.Windows.Forms.Label();
            this.dataGridHorario = new System.Windows.Forms.DataGridView();
            this.labelHorarioLista = new System.Windows.Forms.Label();
            this.panelHorarioVertical2 = new System.Windows.Forms.Panel();
            this.FechaFinBitacora = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboHorarioAula = new System.Windows.Forms.ComboBox();
            this.comboHorarioCarrera = new System.Windows.Forms.ComboBox();
            this.comboHorarioAsignatura = new System.Windows.Forms.ComboBox();
            this.comboHorarioDocente = new System.Windows.Forms.ComboBox();
            this.BitacoraFechaSemestre = new System.Windows.Forms.Label();
            this.FechaBitacora = new System.Windows.Forms.DateTimePicker();
            this.lblArchivoC = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.comboHorarioHoraF = new System.Windows.Forms.ComboBox();
            this.comboHorarioHoraI = new System.Windows.Forms.ComboBox();
            this.buttonHorarioExaminar = new System.Windows.Forms.Button();
            this.radioHorarioHoja = new System.Windows.Forms.RadioButton();
            this.radioHorarioManual = new System.Windows.Forms.RadioButton();
            this.comboHorarioDia = new System.Windows.Forms.ComboBox();
            this.labelHorarioDia = new System.Windows.Forms.Label();
            this.labelHorarioDe = new System.Windows.Forms.Label();
            this.labelHorarioHorario = new System.Windows.Forms.Label();
            this.labelHorarioA = new System.Windows.Forms.Label();
            this.labelHorarioCarrera = new System.Windows.Forms.Label();
            this.buttonHorarioCancelar = new System.Windows.Forms.Button();
            this.buttonHorarioGuardar = new System.Windows.Forms.Button();
            this.labelHorarioAula = new System.Windows.Forms.Label();
            this.labelHorarioAsignatura = new System.Windows.Forms.Label();
            this.labelHorarioDocente = new System.Windows.Forms.Label();
            this.labelHorarioRegistro = new System.Windows.Forms.Label();
            this.panelHorarioHorizontal = new System.Windows.Forms.Panel();
            this.panelHorarioVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHorario)).BeginInit();
            this.panelHorarioVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHorarioTitulo
            // 
            this.labelHorarioTitulo.AutoSize = true;
            this.labelHorarioTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHorarioTitulo.Location = new System.Drawing.Point(410, 0);
            this.labelHorarioTitulo.Name = "labelHorarioTitulo";
            this.labelHorarioTitulo.Size = new System.Drawing.Size(257, 78);
            this.labelHorarioTitulo.TabIndex = 1;
            this.labelHorarioTitulo.Text = "Horario";
            // 
            // panelHorarioVertical
            // 
            this.panelHorarioVertical.BackColor = System.Drawing.Color.White;
            this.panelHorarioVertical.Controls.Add(this.textHorarioBuscar);
            this.panelHorarioVertical.Controls.Add(this.labelHorarioBuscar);
            this.panelHorarioVertical.Controls.Add(this.dataGridHorario);
            this.panelHorarioVertical.Controls.Add(this.labelHorarioLista);
            this.panelHorarioVertical.Location = new System.Drawing.Point(8, 99);
            this.panelHorarioVertical.Name = "panelHorarioVertical";
            this.panelHorarioVertical.Size = new System.Drawing.Size(670, 453);
            this.panelHorarioVertical.TabIndex = 3;
            // 
            // textHorarioBuscar
            // 
            this.textHorarioBuscar.Location = new System.Drawing.Point(375, 37);
            this.textHorarioBuscar.Name = "textHorarioBuscar";
            this.textHorarioBuscar.Size = new System.Drawing.Size(173, 20);
            this.textHorarioBuscar.TabIndex = 23;
            this.textHorarioBuscar.TextChanged += new System.EventHandler(this.textHorarioBuscar_TextChanged);
            // 
            // labelHorarioBuscar
            // 
            this.labelHorarioBuscar.AutoSize = true;
            this.labelHorarioBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelHorarioBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelHorarioBuscar.Location = new System.Drawing.Point(321, 37);
            this.labelHorarioBuscar.Name = "labelHorarioBuscar";
            this.labelHorarioBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelHorarioBuscar.TabIndex = 21;
            this.labelHorarioBuscar.Text = "Buscar";
            // 
            // dataGridHorario
            // 
            this.dataGridHorario.AllowUserToAddRows = false;
            this.dataGridHorario.AllowUserToDeleteRows = false;
            this.dataGridHorario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGridHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridHorario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridHorario.Location = new System.Drawing.Point(8, 69);
            this.dataGridHorario.Name = "dataGridHorario";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridHorario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridHorario.Size = new System.Drawing.Size(653, 340);
            this.dataGridHorario.TabIndex = 1;
            this.dataGridHorario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHorario_CellContentClick);
            // 
            // labelHorarioLista
            // 
            this.labelHorarioLista.AutoSize = true;
            this.labelHorarioLista.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelHorarioLista.Location = new System.Drawing.Point(6, 19);
            this.labelHorarioLista.Name = "labelHorarioLista";
            this.labelHorarioLista.Size = new System.Drawing.Size(132, 19);
            this.labelHorarioLista.TabIndex = 0;
            this.labelHorarioLista.Text = "Lista de horario";
            // 
            // panelHorarioVertical2
            // 
            this.panelHorarioVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelHorarioVertical2.Controls.Add(this.FechaFinBitacora);
            this.panelHorarioVertical2.Controls.Add(this.label1);
            this.panelHorarioVertical2.Controls.Add(this.comboHorarioAula);
            this.panelHorarioVertical2.Controls.Add(this.comboHorarioCarrera);
            this.panelHorarioVertical2.Controls.Add(this.comboHorarioAsignatura);
            this.panelHorarioVertical2.Controls.Add(this.comboHorarioDocente);
            this.panelHorarioVertical2.Controls.Add(this.BitacoraFechaSemestre);
            this.panelHorarioVertical2.Controls.Add(this.FechaBitacora);
            this.panelHorarioVertical2.Controls.Add(this.lblArchivoC);
            this.panelHorarioVertical2.Controls.Add(this.lblArchivo);
            this.panelHorarioVertical2.Controls.Add(this.comboHorarioHoraF);
            this.panelHorarioVertical2.Controls.Add(this.comboHorarioHoraI);
            this.panelHorarioVertical2.Controls.Add(this.buttonHorarioExaminar);
            this.panelHorarioVertical2.Controls.Add(this.radioHorarioHoja);
            this.panelHorarioVertical2.Controls.Add(this.radioHorarioManual);
            this.panelHorarioVertical2.Controls.Add(this.comboHorarioDia);
            this.panelHorarioVertical2.Controls.Add(this.labelHorarioDia);
            this.panelHorarioVertical2.Controls.Add(this.labelHorarioDe);
            this.panelHorarioVertical2.Controls.Add(this.labelHorarioHorario);
            this.panelHorarioVertical2.Controls.Add(this.labelHorarioA);
            this.panelHorarioVertical2.Controls.Add(this.labelHorarioCarrera);
            this.panelHorarioVertical2.Controls.Add(this.buttonHorarioCancelar);
            this.panelHorarioVertical2.Controls.Add(this.buttonHorarioGuardar);
            this.panelHorarioVertical2.Controls.Add(this.labelHorarioAula);
            this.panelHorarioVertical2.Controls.Add(this.labelHorarioAsignatura);
            this.panelHorarioVertical2.Controls.Add(this.labelHorarioDocente);
            this.panelHorarioVertical2.Controls.Add(this.labelHorarioRegistro);
            this.panelHorarioVertical2.Location = new System.Drawing.Point(686, 40);
            this.panelHorarioVertical2.Name = "panelHorarioVertical2";
            this.panelHorarioVertical2.Size = new System.Drawing.Size(386, 512);
            this.panelHorarioVertical2.TabIndex = 4;
            // 
            // FechaFinBitacora
            // 
            this.FechaFinBitacora.Location = new System.Drawing.Point(192, 244);
            this.FechaFinBitacora.Name = "FechaFinBitacora";
            this.FechaFinBitacora.Size = new System.Drawing.Size(171, 20);
            this.FechaFinBitacora.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Fin de semestre";
            // 
            // comboHorarioAula
            // 
            this.comboHorarioAula.FormattingEnabled = true;
            this.comboHorarioAula.Location = new System.Drawing.Point(93, 377);
            this.comboHorarioAula.Name = "comboHorarioAula";
            this.comboHorarioAula.Size = new System.Drawing.Size(273, 21);
            this.comboHorarioAula.TabIndex = 62;
            // 
            // comboHorarioCarrera
            // 
            this.comboHorarioCarrera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboHorarioCarrera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboHorarioCarrera.FormattingEnabled = true;
            this.comboHorarioCarrera.Location = new System.Drawing.Point(93, 346);
            this.comboHorarioCarrera.Name = "comboHorarioCarrera";
            this.comboHorarioCarrera.Size = new System.Drawing.Size(273, 21);
            this.comboHorarioCarrera.TabIndex = 61;
            // 
            // comboHorarioAsignatura
            // 
            this.comboHorarioAsignatura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboHorarioAsignatura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboHorarioAsignatura.FormattingEnabled = true;
            this.comboHorarioAsignatura.Location = new System.Drawing.Point(93, 315);
            this.comboHorarioAsignatura.Name = "comboHorarioAsignatura";
            this.comboHorarioAsignatura.Size = new System.Drawing.Size(273, 21);
            this.comboHorarioAsignatura.TabIndex = 60;
            // 
            // comboHorarioDocente
            // 
            this.comboHorarioDocente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboHorarioDocente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboHorarioDocente.FormattingEnabled = true;
            this.comboHorarioDocente.Location = new System.Drawing.Point(93, 282);
            this.comboHorarioDocente.Name = "comboHorarioDocente";
            this.comboHorarioDocente.Size = new System.Drawing.Size(273, 21);
            this.comboHorarioDocente.TabIndex = 59;
            // 
            // BitacoraFechaSemestre
            // 
            this.BitacoraFechaSemestre.AutoSize = true;
            this.BitacoraFechaSemestre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitacoraFechaSemestre.ForeColor = System.Drawing.Color.White;
            this.BitacoraFechaSemestre.Location = new System.Drawing.Point(50, 173);
            this.BitacoraFechaSemestre.Name = "BitacoraFechaSemestre";
            this.BitacoraFechaSemestre.Size = new System.Drawing.Size(142, 20);
            this.BitacoraFechaSemestre.TabIndex = 58;
            this.BitacoraFechaSemestre.Text = "Inicio de semestre";
            this.BitacoraFechaSemestre.Click += new System.EventHandler(this.BitacoraFechaSemestre_Click);
            // 
            // FechaBitacora
            // 
            this.FechaBitacora.Location = new System.Drawing.Point(33, 196);
            this.FechaBitacora.Name = "FechaBitacora";
            this.FechaBitacora.Size = new System.Drawing.Size(175, 20);
            this.FechaBitacora.TabIndex = 57;
            // 
            // lblArchivoC
            // 
            this.lblArchivoC.AutoSize = true;
            this.lblArchivoC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoC.ForeColor = System.Drawing.Color.White;
            this.lblArchivoC.Location = new System.Drawing.Point(145, 137);
            this.lblArchivoC.Name = "lblArchivoC";
            this.lblArchivoC.Size = new System.Drawing.Size(140, 20);
            this.lblArchivoC.TabIndex = 56;
            this.lblArchivoC.Text = "Archivo cargado:";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.ForeColor = System.Drawing.Color.White;
            this.lblArchivo.Location = new System.Drawing.Point(10, 137);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(140, 20);
            this.lblArchivo.TabIndex = 55;
            this.lblArchivo.Text = "Archivo cargado:";
            // 
            // comboHorarioHoraF
            // 
            this.comboHorarioHoraF.FormattingEnabled = true;
            this.comboHorarioHoraF.Location = new System.Drawing.Point(283, 444);
            this.comboHorarioHoraF.Name = "comboHorarioHoraF";
            this.comboHorarioHoraF.Size = new System.Drawing.Size(67, 21);
            this.comboHorarioHoraF.TabIndex = 54;
            // 
            // comboHorarioHoraI
            // 
            this.comboHorarioHoraI.FormattingEnabled = true;
            this.comboHorarioHoraI.Location = new System.Drawing.Point(166, 446);
            this.comboHorarioHoraI.Name = "comboHorarioHoraI";
            this.comboHorarioHoraI.Size = new System.Drawing.Size(65, 21);
            this.comboHorarioHoraI.TabIndex = 53;
            // 
            // buttonHorarioExaminar
            // 
            this.buttonHorarioExaminar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonHorarioExaminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHorarioExaminar.FlatAppearance.BorderSize = 0;
            this.buttonHorarioExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.buttonHorarioExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonHorarioExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHorarioExaminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHorarioExaminar.ForeColor = System.Drawing.Color.White;
            this.buttonHorarioExaminar.Location = new System.Drawing.Point(134, 96);
            this.buttonHorarioExaminar.Name = "buttonHorarioExaminar";
            this.buttonHorarioExaminar.Size = new System.Drawing.Size(102, 28);
            this.buttonHorarioExaminar.TabIndex = 52;
            this.buttonHorarioExaminar.Text = "Examinar";
            this.buttonHorarioExaminar.UseVisualStyleBackColor = false;
            this.buttonHorarioExaminar.Click += new System.EventHandler(this.buttonHorarioExaminar_Click);
            // 
            // radioHorarioHoja
            // 
            this.radioHorarioHoja.AutoSize = true;
            this.radioHorarioHoja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHorarioHoja.ForeColor = System.Drawing.Color.White;
            this.radioHorarioHoja.Location = new System.Drawing.Point(209, 57);
            this.radioHorarioHoja.Name = "radioHorarioHoja";
            this.radioHorarioHoja.Size = new System.Drawing.Size(133, 25);
            this.radioHorarioHoja.TabIndex = 51;
            this.radioHorarioHoja.TabStop = true;
            this.radioHorarioHoja.Text = "Hoja de excel";
            this.radioHorarioHoja.UseVisualStyleBackColor = true;
            this.radioHorarioHoja.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioHorarioHoja_MouseClick);
            // 
            // radioHorarioManual
            // 
            this.radioHorarioManual.AutoSize = true;
            this.radioHorarioManual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHorarioManual.ForeColor = System.Drawing.Color.White;
            this.radioHorarioManual.Location = new System.Drawing.Point(76, 57);
            this.radioHorarioManual.Name = "radioHorarioManual";
            this.radioHorarioManual.Size = new System.Drawing.Size(88, 25);
            this.radioHorarioManual.TabIndex = 50;
            this.radioHorarioManual.TabStop = true;
            this.radioHorarioManual.Text = "Manual";
            this.radioHorarioManual.UseVisualStyleBackColor = true;
            this.radioHorarioManual.CheckedChanged += new System.EventHandler(this.radioHorarioManual_CheckedChanged);
            this.radioHorarioManual.Click += new System.EventHandler(this.radioHorarioManual_Click);
            // 
            // comboHorarioDia
            // 
            this.comboHorarioDia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboHorarioDia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboHorarioDia.FormattingEnabled = true;
            this.comboHorarioDia.Location = new System.Drawing.Point(93, 409);
            this.comboHorarioDia.Name = "comboHorarioDia";
            this.comboHorarioDia.Size = new System.Drawing.Size(273, 21);
            this.comboHorarioDia.TabIndex = 33;
            // 
            // labelHorarioDia
            // 
            this.labelHorarioDia.AutoSize = true;
            this.labelHorarioDia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioDia.ForeColor = System.Drawing.Color.White;
            this.labelHorarioDia.Location = new System.Drawing.Point(8, 408);
            this.labelHorarioDia.Name = "labelHorarioDia";
            this.labelHorarioDia.Size = new System.Drawing.Size(33, 20);
            this.labelHorarioDia.TabIndex = 32;
            this.labelHorarioDia.Text = "Dia";
            // 
            // labelHorarioDe
            // 
            this.labelHorarioDe.AutoSize = true;
            this.labelHorarioDe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioDe.ForeColor = System.Drawing.Color.White;
            this.labelHorarioDe.Location = new System.Drawing.Point(130, 444);
            this.labelHorarioDe.Name = "labelHorarioDe";
            this.labelHorarioDe.Size = new System.Drawing.Size(30, 20);
            this.labelHorarioDe.TabIndex = 25;
            this.labelHorarioDe.Text = "De";
            // 
            // labelHorarioHorario
            // 
            this.labelHorarioHorario.AutoSize = true;
            this.labelHorarioHorario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioHorario.ForeColor = System.Drawing.Color.White;
            this.labelHorarioHorario.Location = new System.Drawing.Point(7, 443);
            this.labelHorarioHorario.Name = "labelHorarioHorario";
            this.labelHorarioHorario.Size = new System.Drawing.Size(62, 20);
            this.labelHorarioHorario.TabIndex = 7;
            this.labelHorarioHorario.Text = "Horario";
            // 
            // labelHorarioA
            // 
            this.labelHorarioA.AutoSize = true;
            this.labelHorarioA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioA.ForeColor = System.Drawing.Color.White;
            this.labelHorarioA.Location = new System.Drawing.Point(258, 444);
            this.labelHorarioA.Name = "labelHorarioA";
            this.labelHorarioA.Size = new System.Drawing.Size(19, 20);
            this.labelHorarioA.TabIndex = 24;
            this.labelHorarioA.Text = "a";
            // 
            // labelHorarioCarrera
            // 
            this.labelHorarioCarrera.AutoSize = true;
            this.labelHorarioCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioCarrera.ForeColor = System.Drawing.Color.White;
            this.labelHorarioCarrera.Location = new System.Drawing.Point(7, 344);
            this.labelHorarioCarrera.Name = "labelHorarioCarrera";
            this.labelHorarioCarrera.Size = new System.Drawing.Size(66, 20);
            this.labelHorarioCarrera.TabIndex = 21;
            this.labelHorarioCarrera.Text = "Carrera";
            // 
            // buttonHorarioCancelar
            // 
            this.buttonHorarioCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonHorarioCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHorarioCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonHorarioCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonHorarioCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHorarioCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHorarioCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonHorarioCancelar.Location = new System.Drawing.Point(231, 475);
            this.buttonHorarioCancelar.Name = "buttonHorarioCancelar";
            this.buttonHorarioCancelar.Size = new System.Drawing.Size(83, 28);
            this.buttonHorarioCancelar.TabIndex = 20;
            this.buttonHorarioCancelar.Text = "Cancelar";
            this.buttonHorarioCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonHorarioGuardar
            // 
            this.buttonHorarioGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonHorarioGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHorarioGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonHorarioGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonHorarioGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHorarioGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHorarioGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonHorarioGuardar.Location = new System.Drawing.Point(83, 475);
            this.buttonHorarioGuardar.Name = "buttonHorarioGuardar";
            this.buttonHorarioGuardar.Size = new System.Drawing.Size(80, 28);
            this.buttonHorarioGuardar.TabIndex = 19;
            this.buttonHorarioGuardar.Text = "Guardar";
            this.buttonHorarioGuardar.UseVisualStyleBackColor = false;
            this.buttonHorarioGuardar.Click += new System.EventHandler(this.buttonAsignaturaGuardar_Click);
            // 
            // labelHorarioAula
            // 
            this.labelHorarioAula.AutoSize = true;
            this.labelHorarioAula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioAula.ForeColor = System.Drawing.Color.White;
            this.labelHorarioAula.Location = new System.Drawing.Point(7, 378);
            this.labelHorarioAula.Name = "labelHorarioAula";
            this.labelHorarioAula.Size = new System.Drawing.Size(42, 20);
            this.labelHorarioAula.TabIndex = 12;
            this.labelHorarioAula.Text = "Aula";
            // 
            // labelHorarioAsignatura
            // 
            this.labelHorarioAsignatura.AutoSize = true;
            this.labelHorarioAsignatura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioAsignatura.ForeColor = System.Drawing.Color.White;
            this.labelHorarioAsignatura.Location = new System.Drawing.Point(6, 313);
            this.labelHorarioAsignatura.Name = "labelHorarioAsignatura";
            this.labelHorarioAsignatura.Size = new System.Drawing.Size(87, 20);
            this.labelHorarioAsignatura.TabIndex = 3;
            this.labelHorarioAsignatura.Text = "Asignatura";
            // 
            // labelHorarioDocente
            // 
            this.labelHorarioDocente.AutoSize = true;
            this.labelHorarioDocente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioDocente.ForeColor = System.Drawing.Color.White;
            this.labelHorarioDocente.Location = new System.Drawing.Point(6, 283);
            this.labelHorarioDocente.Name = "labelHorarioDocente";
            this.labelHorarioDocente.Size = new System.Drawing.Size(74, 20);
            this.labelHorarioDocente.TabIndex = 1;
            this.labelHorarioDocente.Text = "Docente";
            // 
            // labelHorarioRegistro
            // 
            this.labelHorarioRegistro.AutoSize = true;
            this.labelHorarioRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioRegistro.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelHorarioRegistro.Location = new System.Drawing.Point(7, 19);
            this.labelHorarioRegistro.Name = "labelHorarioRegistro";
            this.labelHorarioRegistro.Size = new System.Drawing.Size(247, 19);
            this.labelHorarioRegistro.TabIndex = 0;
            this.labelHorarioRegistro.Text = "Registro de asignación  horario";
            // 
            // panelHorarioHorizontal
            // 
            this.panelHorarioHorizontal.BackColor = System.Drawing.Color.PaleGreen;
            this.panelHorarioHorizontal.ForeColor = System.Drawing.Color.PaleGreen;
            this.panelHorarioHorizontal.Location = new System.Drawing.Point(0, 569);
            this.panelHorarioHorizontal.Name = "panelHorarioHorizontal";
            this.panelHorarioHorizontal.Size = new System.Drawing.Size(1081, 30);
            this.panelHorarioHorizontal.TabIndex = 25;
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1078, 615);
            this.Controls.Add(this.panelHorarioHorizontal);
            this.Controls.Add(this.panelHorarioVertical2);
            this.Controls.Add(this.panelHorarioVertical);
            this.Controls.Add(this.labelHorarioTitulo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Horario";
            this.Opacity = 0.96D;
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.Horario_Load);
            this.panelHorarioVertical.ResumeLayout(false);
            this.panelHorarioVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHorario)).EndInit();
            this.panelHorarioVertical2.ResumeLayout(false);
            this.panelHorarioVertical2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHorarioTitulo;
        private System.Windows.Forms.Panel panelHorarioVertical;
        private System.Windows.Forms.TextBox textHorarioBuscar;
        private System.Windows.Forms.Label labelHorarioBuscar;
        private System.Windows.Forms.DataGridView dataGridHorario;
        private System.Windows.Forms.Label labelHorarioLista;
        private System.Windows.Forms.Panel panelHorarioVertical2;
        private System.Windows.Forms.Button buttonHorarioCancelar;
        private System.Windows.Forms.Button buttonHorarioGuardar;
        private System.Windows.Forms.Label labelHorarioAula;
        private System.Windows.Forms.Label labelHorarioHorario;
        private System.Windows.Forms.Label labelHorarioAsignatura;
        private System.Windows.Forms.Label labelHorarioDocente;
        private System.Windows.Forms.Label labelHorarioRegistro;
        private System.Windows.Forms.Label labelHorarioDe;
        private System.Windows.Forms.Label labelHorarioA;
        private System.Windows.Forms.Label labelHorarioCarrera;
        private System.Windows.Forms.ComboBox comboHorarioDia;
        private System.Windows.Forms.Label labelHorarioDia;
        private System.Windows.Forms.Panel panelHorarioHorizontal;
        private System.Windows.Forms.Button buttonHorarioExaminar;
        private System.Windows.Forms.RadioButton radioHorarioHoja;
        private System.Windows.Forms.RadioButton radioHorarioManual;
        private System.Windows.Forms.ComboBox comboHorarioHoraF;
        private System.Windows.Forms.ComboBox comboHorarioHoraI;
        private System.Windows.Forms.Label lblArchivoC;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Label BitacoraFechaSemestre;
        private System.Windows.Forms.DateTimePicker FechaBitacora;
        private System.Windows.Forms.ComboBox comboHorarioAula;
        private System.Windows.Forms.ComboBox comboHorarioCarrera;
        private System.Windows.Forms.ComboBox comboHorarioAsignatura;
        private System.Windows.Forms.ComboBox comboHorarioDocente;
        private System.Windows.Forms.DateTimePicker FechaFinBitacora;
        private System.Windows.Forms.Label label1;
    }
}