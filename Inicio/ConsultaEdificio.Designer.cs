﻿namespace Inicio
{
    partial class ConsultaEdificio
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
            this.panelCEdificioVertical = new System.Windows.Forms.Panel();
            this.textCEdificioBuscar = new System.Windows.Forms.TextBox();
            this.labelCEdificioBuscar = new System.Windows.Forms.Label();
            this.buttonCEdificioEliminar = new System.Windows.Forms.Button();
            this.buttonCEdificioEditar = new System.Windows.Forms.Button();
            this.dataGridCEdificio = new System.Windows.Forms.DataGridView();
            this.labelCEdificioLista = new System.Windows.Forms.Label();
            this.panelCEdificioVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCEdificio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCEdificioVertical
            // 
            this.panelCEdificioVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCEdificioVertical.Controls.Add(this.textCEdificioBuscar);
            this.panelCEdificioVertical.Controls.Add(this.labelCEdificioBuscar);
            this.panelCEdificioVertical.Controls.Add(this.buttonCEdificioEliminar);
            this.panelCEdificioVertical.Controls.Add(this.buttonCEdificioEditar);
            this.panelCEdificioVertical.Controls.Add(this.dataGridCEdificio);
            this.panelCEdificioVertical.Controls.Add(this.labelCEdificioLista);
            this.panelCEdificioVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCEdificioVertical.Location = new System.Drawing.Point(0, 0);
            this.panelCEdificioVertical.Name = "panelCEdificioVertical";
            this.panelCEdificioVertical.Size = new System.Drawing.Size(518, 303);
            this.panelCEdificioVertical.TabIndex = 7;
            // 
            // textCEdificioBuscar
            // 
            this.textCEdificioBuscar.Location = new System.Drawing.Point(266, 41);
            this.textCEdificioBuscar.Name = "textCEdificioBuscar";
            this.textCEdificioBuscar.Size = new System.Drawing.Size(137, 20);
            this.textCEdificioBuscar.TabIndex = 23;
            this.textCEdificioBuscar.TextChanged += new System.EventHandler(this.textCEdificioBuscar_TextChanged);
            // 
            // labelCEdificioBuscar
            // 
            this.labelCEdificioBuscar.AutoSize = true;
            this.labelCEdificioBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEdificioBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelCEdificioBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCEdificioBuscar.Location = new System.Drawing.Point(193, 40);
            this.labelCEdificioBuscar.Name = "labelCEdificioBuscar";
            this.labelCEdificioBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelCEdificioBuscar.TabIndex = 21;
            this.labelCEdificioBuscar.Text = "Buscar";
            // 
            // buttonCEdificioEliminar
            // 
            this.buttonCEdificioEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCEdificioEliminar.FlatAppearance.BorderSize = 0;
            this.buttonCEdificioEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCEdificioEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCEdificioEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonCEdificioEliminar.Location = new System.Drawing.Point(330, 263);
            this.buttonCEdificioEliminar.Name = "buttonCEdificioEliminar";
            this.buttonCEdificioEliminar.Size = new System.Drawing.Size(85, 24);
            this.buttonCEdificioEliminar.TabIndex = 22;
            this.buttonCEdificioEliminar.Text = "Eliminar";
            this.buttonCEdificioEliminar.UseVisualStyleBackColor = false;
            this.buttonCEdificioEliminar.Click += new System.EventHandler(this.buttonCEdificioEliminar_Click);
            // 
            // buttonCEdificioEditar
            // 
            this.buttonCEdificioEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCEdificioEditar.FlatAppearance.BorderSize = 0;
            this.buttonCEdificioEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCEdificioEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCEdificioEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCEdificioEditar.Location = new System.Drawing.Point(227, 264);
            this.buttonCEdificioEditar.Name = "buttonCEdificioEditar";
            this.buttonCEdificioEditar.Size = new System.Drawing.Size(75, 24);
            this.buttonCEdificioEditar.TabIndex = 21;
            this.buttonCEdificioEditar.Text = "Editar";
            this.buttonCEdificioEditar.UseVisualStyleBackColor = false;
            this.buttonCEdificioEditar.Click += new System.EventHandler(this.buttonCEdificioEditar_Click);
            // 
            // dataGridCEdificio
            // 
            this.dataGridCEdificio.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCEdificio.Location = new System.Drawing.Point(7, 87);
            this.dataGridCEdificio.Name = "dataGridCEdificio";
            this.dataGridCEdificio.Size = new System.Drawing.Size(456, 170);
            this.dataGridCEdificio.TabIndex = 1;
            // 
            // labelCEdificioLista
            // 
            this.labelCEdificioLista.AutoSize = true;
            this.labelCEdificioLista.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEdificioLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCEdificioLista.Location = new System.Drawing.Point(12, 11);
            this.labelCEdificioLista.Name = "labelCEdificioLista";
            this.labelCEdificioLista.Size = new System.Drawing.Size(172, 24);
            this.labelCEdificioLista.TabIndex = 0;
            this.labelCEdificioLista.Text = "Lista de edificios";
            // 
            // ConsultaEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 303);
            this.Controls.Add(this.panelCEdificioVertical);
            this.Name = "ConsultaEdificio";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaEdificio";
            this.Load += new System.EventHandler(this.ConsultaEdificio_Load);
            this.panelCEdificioVertical.ResumeLayout(false);
            this.panelCEdificioVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCEdificio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCEdificioVertical;
        private System.Windows.Forms.TextBox textCEdificioBuscar;
        private System.Windows.Forms.Label labelCEdificioBuscar;
        private System.Windows.Forms.Button buttonCEdificioEliminar;
        private System.Windows.Forms.Button buttonCEdificioEditar;
        private System.Windows.Forms.DataGridView dataGridCEdificio;
        private System.Windows.Forms.Label labelCEdificioLista;
    }
}