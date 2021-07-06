﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace Inicio
{
    public partial class Cargo : Form
    {
        CDCargo objCargo = new CDCargo();
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";

        public Cargo()
        {
            InitializeComponent();
            comboCargo.Items.Add("Academico");
            comboCargo.Items.Add("Administrativo");
        }

        private void Cargo_Load(object sender, EventArgs e)
        {
            MostrarCargo();
        }

        private void textCargoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void buttonCargoGuardar_Click(object sender, EventArgs e)
        {
            if (textCargoClave.Text == "" || textCargoNombre.Text  == "" || comboCargo.Text=="")
            {
                MessageBox.Show("Llenar los campos obligatorios");
                
            }
            else
            {
                try
                {
                    objCargo.insertarCargo(
                    textCargoClave.Text,
                    textCargoNombre.Text,
                    textCargoDescripcion.Text,
                    comboCargo.Text
                    );

                    MessageBox.Show("Agregado Correctamente");
                    MostrarCargo();
                }

                catch
                {
                    MessageBox.Show("No se puede repetir la misma Clave ");
                }

                textCargoClave.Clear();
                textCargoNombre.Clear();
                textCargoDescripcion.Clear();
                comboCargo.Text = string.Empty;
            }
        }

        private void MostrarCargo()
        {
            CDCargo objCar = new CDCargo();
            dataGridViewCargo.DataSource = objCar.MostrarCargo();
        }

        private void panelCargoVertical2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void textCargoBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCargoBuscar.Text;
            dataGridViewCargo.DataSource = bindingSource1;
            GetData("select * from Cargo where Clave like '" + filtrado + "%' or Nombre like '" + filtrado + "%';");
            
        }
        

        private void GetData(string sql)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(sql, CadenaConexion);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                // dataGridCEmpleado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción: " + ex);
            }

        }

        private void textCargoBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //filtrado = textCargoBuscar.Text;
            //dataGridViewCargo.DataSource = bindingSource1;
            //GetData("select * from Cargo where Clave like '" + filtrado + "%' or Nombre like '" + filtrado + "%';");
        }

       

        private void buttonCargoCancelar_Click(object sender, EventArgs e)
        {
            textCargoClave.Clear();
            textCargoNombre.Clear();
            textCargoDescripcion.Clear();
            comboCargo.Text = string.Empty;
        }
    }
}
