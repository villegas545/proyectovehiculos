using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Vehiculos
    {
        public String color;
        public String Marca;
        public String Modelo;
        public int distancia;
        public Boolean chocado;
        private String llantas;
        private int v_tiempo;

        private int v1;
        private int v2;
        public int suma;

        public Vehiculos()
        {
            distancia = 0;
            chocado = false;
        }
        public Vehiculos(String c_color, String c_Marca, String c_Modelo)
        {
            color = c_color;
            Marca = c_Marca;
            Modelo = c_Modelo;
            distancia = 0;
            chocado = false;
        }
        public int tiempo(int velocidad, int distancia)
        {
            v_tiempo = velocidad * distancia;
            return v_tiempo;
        }

        public void avanzar()
        {
            if (chocado == false)
            {
                distancia = distancia + 1;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ya estabas chocado");
            }
            
        }
        public void mostrardistancia()
        {
            System.Windows.Forms.MessageBox.Show("La distancia es: "+distancia);
         
        }
        public void chocar()
        {

            if (chocado == false)
            {
                chocado = true;
                System.Windows.Forms.MessageBox.Show("Como estas %$#@%^&^%#, acabas de chocar");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ya estabas chocado");

            }

        }
    

    }
}
