﻿namespace Inicio
{
    partial class Empleado
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
            this.panelEmpleadoVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textEmpleadoBuscar = new System.Windows.Forms.TextBox();
            this.labelEmpleadoBuscar = new System.Windows.Forms.Label();
            this.dataGridEmpleado = new System.Windows.Forms.DataGridView();
            this.labelEmpleadoLista = new System.Windows.Forms.Label();
            this.panelEmpleadoVertical2 = new System.Windows.Forms.Panel();
            this.textEmpleadoHuella = new System.Windows.Forms.TextBox();
            this.buttonEmpleadoHuella = new System.Windows.Forms.Button();
            this.buttonEmpleadoCancelar = new System.Windows.Forms.Button();
            this.buttonEmpleadoGuardar = new System.Windows.Forms.Button();
            this.comboEmpleadoSexo = new System.Windows.Forms.ComboBox();
            this.labelEmpleadoSex = new System.Windows.Forms.Label();
            this.comboEmpleadoCargo = new System.Windows.Forms.ComboBox();
            this.textEmpleadoApellidoM = new System.Windows.Forms.TextBox();
            this.labelEmpleadoApellidoM = new System.Windows.Forms.Label();
            this.textEmpleadoApellidosP = new System.Windows.Forms.TextBox();
            this.labelEmpleadoApellidoP = new System.Windows.Forms.Label();
            this.labelEmpleadoNPersonal = new System.Windows.Forms.Label();
            this.textEmpleadoNPersonal = new System.Windows.Forms.TextBox();
            this.textEmpleadoEmail = new System.Windows.Forms.TextBox();
            this.textEmpleadoDireccion = new System.Windows.Forms.TextBox();
            this.labelEmpleadoEmail = new System.Windows.Forms.Label();
            this.labelEmpleadoCargo = new System.Windows.Forms.Label();
            this.labelEmpleadoDireccion = new System.Windows.Forms.Label();
            this.textEmpleadoTelefono = new System.Windows.Forms.TextBox();
            this.labelEmpleadoTelefono = new System.Windows.Forms.Label();
            this.textEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.labelEmpleadoNombre = new System.Windows.Forms.Label();
            this.labeEmpleadoRegistro = new System.Windows.Forms.Label();
            this.panelEmpleadoVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleado)).BeginInit();
            this.panelEmpleadoVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmpleadoVertical
            // 
            this.panelEmpleadoVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelEmpleadoVertical.Controls.Add(this.label1);
            this.panelEmpleadoVertical.Controls.Add(this.textEmpleadoBuscar);
            this.panelEmpleadoVertical.Controls.Add(this.labelEmpleadoBuscar);
            this.panelEmpleadoVertical.Controls.Add(this.dataGridEmpleado);
            this.panelEmpleadoVertical.Controls.Add(this.labelEmpleadoLista);
            this.panelEmpleadoVertical.Location = new System.Drawing.Point(0, 0);
            this.panelEmpleadoVertical.Name = "panelEmpleadoVertical";
            this.panelEmpleadoVertical.Size = new System.Drawing.Size(575, 439);
            this.panelEmpleadoVertical.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(4, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "*Solo para consultas";
            // 
            // textEmpleadoBuscar
            // 
            this.textEmpleadoBuscar.Location = new System.Drawing.Point(317, 41);
            this.textEmpleadoBuscar.Name = "textEmpleadoBuscar";
            this.textEmpleadoBuscar.Size = new System.Drawing.Size(173, 20);
            this.textEmpleadoBuscar.TabIndex = 23;
            this.textEmpleadoBuscar.TextChanged += new System.EventHandler(this.textEmpleadoBuscar_TextChanged);
            // 
            // labelEmpleadoBuscar
            // 
            this.labelEmpleadoBuscar.AutoSize = true;
            this.labelEmpleadoBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelEmpleadoBuscar.Location = new System.Drawing.Point(254, 40);
            this.labelEmpleadoBuscar.Name = "labelEmpleadoBuscar";
            this.labelEmpleadoBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelEmpleadoBuscar.TabIndex = 21;
            this.labelEmpleadoBuscar.Text = "Buscar";
            // 
            // dataGridEmpleado
            // 
            this.dataGridEmpleado.AllowDrop = true;
            this.dataGridEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.dataGridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpleado.Location = new System.Drawing.Point(9, 73);
            this.dataGridEmpleado.Name = "dataGridEmpleado";
            this.dataGridEmpleado.Size = new System.Drawing.Size(558, 330);
            this.dataGridEmpleado.TabIndex = 1;
            // 
            // labelEmpleadoLista
            // 
            this.labelEmpleadoLista.AutoSize = true;
            this.labelEmpleadoLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelEmpleadoLista.Location = new System.Drawing.Point(4, 19);
            this.labelEmpleadoLista.Name = "labelEmpleadoLista";
            this.labelEmpleadoLista.Size = new System.Drawing.Size(154, 21);
            this.labelEmpleadoLista.TabIndex = 0;
            this.labelEmpleadoLista.Text = "Lista de empleado";
            // 
            // panelEmpleadoVertical2
            // 
            this.panelEmpleadoVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelEmpleadoVertical2.Controls.Add(this.textEmpleadoHuella);
            this.panelEmpleadoVertical2.Controls.Add(this.buttonEmpleadoHuella);
            this.panelEmpleadoVertical2.Controls.Add(this.buttonEmpleadoCancelar);
            this.panelEmpleadoVertical2.Controls.Add(this.buttonEmpleadoGuardar);
            this.panelEmpleadoVertical2.Controls.Add(this.comboEmpleadoSexo);
            this.panelEmpleadoVertical2.Controls.Add(this.labelEmpleadoSex);
            this.panelEmpleadoVertical2.Controls.Add(this.comboEmpleadoCargo);
            this.panelEmpleadoVertical2.Controls.Add(this.textEmpleadoApellidoM);
            this.panelEmpleadoVertical2.Controls.Add(this.labelEmpleadoApellidoM);
            this.panelEmpleadoVertical2.Controls.Add(this.textEmpleadoApellidosP);
            this.panelEmpleadoVertical2.Controls.Add(this.labelEmpleadoApellidoP);
            this.panelEmpleadoVertical2.Controls.Add(this.labelEmpleadoNPersonal);
            this.panelEmpleadoVertical2.Controls.Add(this.textEmpleadoNPersonal);
            this.panelEmpleadoVertical2.Controls.Add(this.textEmpleadoEmail);
            this.panelEmpleadoVertical2.Controls.Add(this.textEmpleadoDireccion);
            this.panelEmpleadoVertical2.Controls.Add(this.labelEmpleadoEmail);
            this.panelEmpleadoVertical2.Controls.Add(this.labelEmpleadoCargo);
            this.panelEmpleadoVertical2.Controls.Add(this.labelEmpleadoDireccion);
            this.panelEmpleadoVertical2.Controls.Add(this.textEmpleadoTelefono);
            this.panelEmpleadoVertical2.Controls.Add(this.labelEmpleadoTelefono);
            this.panelEmpleadoVertical2.Controls.Add(this.textEmpleadoNombre);
            this.panelEmpleadoVertical2.Controls.Add(this.labelEmpleadoNombre);
            this.panelEmpleadoVertical2.Controls.Add(this.labeEmpleadoRegistro);
            this.panelEmpleadoVertical2.Location = new System.Drawing.Point(573, 0);
            this.panelEmpleadoVertical2.Name = "panelEmpleadoVertical2";
            this.panelEmpleadoVertical2.Size = new System.Drawing.Size(333, 439);
            this.panelEmpleadoVertical2.TabIndex = 2;
            // 
            // textEmpleadoHuella
            // 
            this.textEmpleadoHuella.Location = new System.Drawing.Point(239, 334);
            this.textEmpleadoHuella.Name = "textEmpleadoHuella";
            this.textEmpleadoHuella.Size = new System.Drawing.Size(12, 20);
            this.textEmpleadoHuella.TabIndex = 26;
            // 
            // buttonEmpleadoHuella
            // 
            this.buttonEmpleadoHuella.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonEmpleadoHuella.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmpleadoHuella.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.buttonEmpleadoHuella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleadoHuella.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleadoHuella.ForeColor = System.Drawing.Color.White;
            this.buttonEmpleadoHuella.Location = new System.Drawing.Point(113, 330);
            this.buttonEmpleadoHuella.Name = "buttonEmpleadoHuella";
            this.buttonEmpleadoHuella.Size = new System.Drawing.Size(125, 28);
            this.buttonEmpleadoHuella.TabIndex = 30;
            this.buttonEmpleadoHuella.Text = "Agregar huella";
            this.buttonEmpleadoHuella.UseVisualStyleBackColor = false;
            // 
            // buttonEmpleadoCancelar
            // 
            this.buttonEmpleadoCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonEmpleadoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleadoCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleadoCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonEmpleadoCancelar.Location = new System.Drawing.Point(185, 387);
            this.buttonEmpleadoCancelar.Name = "buttonEmpleadoCancelar";
            this.buttonEmpleadoCancelar.Size = new System.Drawing.Size(101, 34);
            this.buttonEmpleadoCancelar.TabIndex = 22;
            this.buttonEmpleadoCancelar.Text = "Cancelar";
            this.buttonEmpleadoCancelar.UseVisualStyleBackColor = false;
            this.buttonEmpleadoCancelar.Click += new System.EventHandler(this.buttonEmpleadoCancelar_Click);
            // 
            // buttonEmpleadoGuardar
            // 
            this.buttonEmpleadoGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonEmpleadoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleadoGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleadoGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonEmpleadoGuardar.Location = new System.Drawing.Point(47, 387);
            this.buttonEmpleadoGuardar.Name = "buttonEmpleadoGuardar";
            this.buttonEmpleadoGuardar.Size = new System.Drawing.Size(98, 34);
            this.buttonEmpleadoGuardar.TabIndex = 21;
            this.buttonEmpleadoGuardar.Text = "Guardar";
            this.buttonEmpleadoGuardar.UseVisualStyleBackColor = false;
            this.buttonEmpleadoGuardar.Click += new System.EventHandler(this.buttonEmpleadoGuardar_Click);
            // 
            // comboEmpleadoSexo
            // 
            this.comboEmpleadoSexo.FormattingEnabled = true;
            this.comboEmpleadoSexo.Location = new System.Drawing.Point(95, 204);
            this.comboEmpleadoSexo.Name = "comboEmpleadoSexo";
            this.comboEmpleadoSexo.Size = new System.Drawing.Size(219, 21);
            this.comboEmpleadoSexo.TabIndex = 29;
            this.comboEmpleadoSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEmpleadoSexo_KeyPress);
            // 
            // labelEmpleadoSex
            // 
            this.labelEmpleadoSex.AutoSize = true;
            this.labelEmpleadoSex.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoSex.ForeColor = System.Drawing.Color.White;
            this.labelEmpleadoSex.Location = new System.Drawing.Point(9, 205);
            this.labelEmpleadoSex.Name = "labelEmpleadoSex";
            this.labelEmpleadoSex.Size = new System.Drawing.Size(49, 20);
            this.labelEmpleadoSex.TabIndex = 28;
            this.labelEmpleadoSex.Text = "Sexo*";
            // 
            // comboEmpleadoCargo
            // 
            this.comboEmpleadoCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEmpleadoCargo.FormattingEnabled = true;
            this.comboEmpleadoCargo.Location = new System.Drawing.Point(95, 259);
            this.comboEmpleadoCargo.Name = "comboEmpleadoCargo";
            this.comboEmpleadoCargo.Size = new System.Drawing.Size(219, 21);
            this.comboEmpleadoCargo.TabIndex = 27;
            this.comboEmpleadoCargo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboEmpleadoCargo_MouseClick);
            // 
            // textEmpleadoApellidoM
            // 
            this.textEmpleadoApellidoM.Location = new System.Drawing.Point(145, 149);
            this.textEmpleadoApellidoM.Name = "textEmpleadoApellidoM";
            this.textEmpleadoApellidoM.Size = new System.Drawing.Size(169, 20);
            this.textEmpleadoApellidoM.TabIndex = 26;
            this.textEmpleadoApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmpleadoApellidoM_KeyPress);
            // 
            // labelEmpleadoApellidoM
            // 
            this.labelEmpleadoApellidoM.AutoSize = true;
            this.labelEmpleadoApellidoM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoApellidoM.ForeColor = System.Drawing.Color.White;
            this.labelEmpleadoApellidoM.Location = new System.Drawing.Point(9, 147);
            this.labelEmpleadoApellidoM.Name = "labelEmpleadoApellidoM";
            this.labelEmpleadoApellidoM.Size = new System.Drawing.Size(143, 20);
            this.labelEmpleadoApellidoM.TabIndex = 25;
            this.labelEmpleadoApellidoM.Text = "Apellido Materno*";
            // 
            // textEmpleadoApellidosP
            // 
            this.textEmpleadoApellidosP.Location = new System.Drawing.Point(145, 117);
            this.textEmpleadoApellidosP.Name = "textEmpleadoApellidosP";
            this.textEmpleadoApellidosP.Size = new System.Drawing.Size(169, 20);
            this.textEmpleadoApellidosP.TabIndex = 24;
            this.textEmpleadoApellidosP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmpleadoApellidosP_KeyPress);
            // 
            // labelEmpleadoApellidoP
            // 
            this.labelEmpleadoApellidoP.AutoSize = true;
            this.labelEmpleadoApellidoP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoApellidoP.ForeColor = System.Drawing.Color.White;
            this.labelEmpleadoApellidoP.Location = new System.Drawing.Point(8, 117);
            this.labelEmpleadoApellidoP.Name = "labelEmpleadoApellidoP";
            this.labelEmpleadoApellidoP.Size = new System.Drawing.Size(137, 20);
            this.labelEmpleadoApellidoP.TabIndex = 23;
            this.labelEmpleadoApellidoP.Text = "Apellido Paterno*";
            // 
            // labelEmpleadoNPersonal
            // 
            this.labelEmpleadoNPersonal.AutoSize = true;
            this.labelEmpleadoNPersonal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoNPersonal.ForeColor = System.Drawing.Color.White;
            this.labelEmpleadoNPersonal.Location = new System.Drawing.Point(9, 60);
            this.labelEmpleadoNPersonal.Name = "labelEmpleadoNPersonal";
            this.labelEmpleadoNPersonal.Size = new System.Drawing.Size(98, 20);
            this.labelEmpleadoNPersonal.TabIndex = 5;
            this.labelEmpleadoNPersonal.Text = "Nº Personal*";
            // 
            // textEmpleadoNPersonal
            // 
            this.textEmpleadoNPersonal.Location = new System.Drawing.Point(113, 61);
            this.textEmpleadoNPersonal.Name = "textEmpleadoNPersonal";
            this.textEmpleadoNPersonal.Size = new System.Drawing.Size(201, 20);
            this.textEmpleadoNPersonal.TabIndex = 6;
            // 
            // textEmpleadoEmail
            // 
            this.textEmpleadoEmail.Location = new System.Drawing.Point(95, 288);
            this.textEmpleadoEmail.Name = "textEmpleadoEmail";
            this.textEmpleadoEmail.Size = new System.Drawing.Size(219, 20);
            this.textEmpleadoEmail.TabIndex = 17;
            // 
            // textEmpleadoDireccion
            // 
            this.textEmpleadoDireccion.Location = new System.Drawing.Point(95, 232);
            this.textEmpleadoDireccion.Name = "textEmpleadoDireccion";
            this.textEmpleadoDireccion.Size = new System.Drawing.Size(219, 20);
            this.textEmpleadoDireccion.TabIndex = 16;
            // 
            // labelEmpleadoEmail
            // 
            this.labelEmpleadoEmail.AutoSize = true;
            this.labelEmpleadoEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmpleadoEmail.Location = new System.Drawing.Point(9, 288);
            this.labelEmpleadoEmail.Name = "labelEmpleadoEmail";
            this.labelEmpleadoEmail.Size = new System.Drawing.Size(46, 20);
            this.labelEmpleadoEmail.TabIndex = 12;
            this.labelEmpleadoEmail.Text = "Email";
            // 
            // labelEmpleadoCargo
            // 
            this.labelEmpleadoCargo.AutoSize = true;
            this.labelEmpleadoCargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoCargo.ForeColor = System.Drawing.Color.White;
            this.labelEmpleadoCargo.Location = new System.Drawing.Point(9, 257);
            this.labelEmpleadoCargo.Name = "labelEmpleadoCargo";
            this.labelEmpleadoCargo.Size = new System.Drawing.Size(62, 20);
            this.labelEmpleadoCargo.TabIndex = 11;
            this.labelEmpleadoCargo.Text = "Cargo*";
            // 
            // labelEmpleadoDireccion
            // 
            this.labelEmpleadoDireccion.AutoSize = true;
            this.labelEmpleadoDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoDireccion.ForeColor = System.Drawing.Color.White;
            this.labelEmpleadoDireccion.Location = new System.Drawing.Point(9, 232);
            this.labelEmpleadoDireccion.Name = "labelEmpleadoDireccion";
            this.labelEmpleadoDireccion.Size = new System.Drawing.Size(80, 20);
            this.labelEmpleadoDireccion.TabIndex = 10;
            this.labelEmpleadoDireccion.Text = "Dirección";
            // 
            // textEmpleadoTelefono
            // 
            this.textEmpleadoTelefono.Location = new System.Drawing.Point(81, 178);
            this.textEmpleadoTelefono.Name = "textEmpleadoTelefono";
            this.textEmpleadoTelefono.Size = new System.Drawing.Size(233, 20);
            this.textEmpleadoTelefono.TabIndex = 8;
            this.textEmpleadoTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmpleadoTelefono_KeyPress);
            // 
            // labelEmpleadoTelefono
            // 
            this.labelEmpleadoTelefono.AutoSize = true;
            this.labelEmpleadoTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoTelefono.ForeColor = System.Drawing.Color.White;
            this.labelEmpleadoTelefono.Location = new System.Drawing.Point(9, 177);
            this.labelEmpleadoTelefono.Name = "labelEmpleadoTelefono";
            this.labelEmpleadoTelefono.Size = new System.Drawing.Size(77, 20);
            this.labelEmpleadoTelefono.TabIndex = 7;
            this.labelEmpleadoTelefono.Text = "Teléfono*";
            // 
            // textEmpleadoNombre
            // 
            this.textEmpleadoNombre.Location = new System.Drawing.Point(81, 88);
            this.textEmpleadoNombre.Name = "textEmpleadoNombre";
            this.textEmpleadoNombre.Size = new System.Drawing.Size(233, 20);
            this.textEmpleadoNombre.TabIndex = 2;
            this.textEmpleadoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmpleadoNombre_KeyPress);
            // 
            // labelEmpleadoNombre
            // 
            this.labelEmpleadoNombre.AutoSize = true;
            this.labelEmpleadoNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleadoNombre.ForeColor = System.Drawing.Color.White;
            this.labelEmpleadoNombre.Location = new System.Drawing.Point(8, 88);
            this.labelEmpleadoNombre.Name = "labelEmpleadoNombre";
            this.labelEmpleadoNombre.Size = new System.Drawing.Size(74, 20);
            this.labelEmpleadoNombre.TabIndex = 1;
            this.labelEmpleadoNombre.Text = "Nombre*";
            // 
            // labeEmpleadoRegistro
            // 
            this.labeEmpleadoRegistro.AutoSize = true;
            this.labeEmpleadoRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeEmpleadoRegistro.ForeColor = System.Drawing.Color.PaleGreen;
            this.labeEmpleadoRegistro.Location = new System.Drawing.Point(3, 19);
            this.labeEmpleadoRegistro.Name = "labeEmpleadoRegistro";
            this.labeEmpleadoRegistro.Size = new System.Drawing.Size(162, 21);
            this.labeEmpleadoRegistro.TabIndex = 0;
            this.labeEmpleadoRegistro.Text = "Registrar Empleado";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 436);
            this.Controls.Add(this.panelEmpleadoVertical2);
            this.Controls.Add(this.panelEmpleadoVertical);
            this.Name = "Empleado";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.panelEmpleadoVertical.ResumeLayout(false);
            this.panelEmpleadoVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleado)).EndInit();
            this.panelEmpleadoVertical2.ResumeLayout(false);
            this.panelEmpleadoVertical2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmpleadoVertical;
        private System.Windows.Forms.TextBox textEmpleadoBuscar;
        private System.Windows.Forms.Label labelEmpleadoBuscar;
        private System.Windows.Forms.DataGridView dataGridEmpleado;
        private System.Windows.Forms.Label labelEmpleadoLista;
        private System.Windows.Forms.Panel panelEmpleadoVertical2;
        private System.Windows.Forms.TextBox textEmpleadoEmail;
        private System.Windows.Forms.TextBox textEmpleadoDireccion;
        private System.Windows.Forms.Label labelEmpleadoEmail;
        private System.Windows.Forms.Label labelEmpleadoCargo;
        private System.Windows.Forms.Label labelEmpleadoDireccion;
        private System.Windows.Forms.TextBox textEmpleadoTelefono;
        private System.Windows.Forms.Label labelEmpleadoTelefono;
        private System.Windows.Forms.TextBox textEmpleadoNPersonal;
        private System.Windows.Forms.Label labelEmpleadoNPersonal;
        private System.Windows.Forms.TextBox textEmpleadoNombre;
        private System.Windows.Forms.Label labelEmpleadoNombre;
        private System.Windows.Forms.Label labeEmpleadoRegistro;
        private System.Windows.Forms.TextBox textEmpleadoApellidoM;
        private System.Windows.Forms.Label labelEmpleadoApellidoM;
        private System.Windows.Forms.TextBox textEmpleadoApellidosP;
        private System.Windows.Forms.Label labelEmpleadoApellidoP;
        private System.Windows.Forms.Button buttonEmpleadoCancelar;
        private System.Windows.Forms.Button buttonEmpleadoGuardar;
        private System.Windows.Forms.ComboBox comboEmpleadoCargo;
        private System.Windows.Forms.ComboBox comboEmpleadoSexo;
        private System.Windows.Forms.Label labelEmpleadoSex;
        private System.Windows.Forms.Label label1;
        //private Inicio.SiceeDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonEmpleadoHuella;
        private System.Windows.Forms.TextBox textEmpleadoHuella;
    }
}