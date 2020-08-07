using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Vehiculos Ferrari = new Vehiculos("Rojo","Ferrari","2020");
        Vehiculos Mustang = new Vehiculos("Azul","Mustang","1950");
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ferrari.avanzar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mustang.avanzar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ferrari.mostrardistancia();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mustang.mostrardistancia();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ferrari.chocar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mustang.chocar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+ Ferrari.Marca + Ferrari.Modelo + Ferrari.color);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + Mustang.Marca + Mustang.Modelo + Mustang.color);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int capturar = Ferrari.tiempo(int.Parse(Txt_velocidad.Text),int.Parse(txt_Distancia.Text));
            MessageBox.Show(""+capturar);
        }
    }
}
