﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeterminante_Click(object sender, EventArgs e)
        {
            Determinantes form_deter = new Determinantes();
            this.Hide();
            form_deter.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            Creditos frm_creditos=new Creditos();
            this.Hide();
            frm_creditos.ShowDialog();
            this.Close ();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult res=MessageBox.Show("¿Está seguro de salir del programa?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cajero frm_cajero=new cajero();
            this.Hide();
            frm_cajero.ShowDialog();
            this.Close();
        }

        private void BtnAngulos_Click(object sender, EventArgs e)
        {
            Angulos frm_angulo=new Angulos();
            this.Hide();
            frm_angulo.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Promedio frm_promedio = new Promedio();
            this.Hide();
            frm_promedio.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ordenamiento frm_ordenamiento = new Ordenamiento();
            this.Hide();
            frm_ordenamiento.ShowDialog();
            this.Close();
        }
    }
}
