using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{

    public partial class Calculadora : Form
    {
        double First;
        double Second;
        string Operador;
        string Ans;
        Class.Historial Histo = new Class.Historial();
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Boton0_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "0";
        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "1";
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "2";
        }

        private void Boton3_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "3";
        }

        private void Boton4_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "4";
        }

        private void Boton5_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "5";
        }

        private void Boton6_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "6";
        }

        private void Boton7_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "7";
        }

        private void Boton8_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "8";
        }

        private void Boton9_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "9";
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + ",";
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            try
            {
                Operador = "+";
                Histo.historial1 += Screen.Text + " " + Operador+ " ";
                First = double.Parse(Screen.Text);
                Screen.Clear();
            }
            catch (System.FormatException)
            {
                Screen.Text = "Syntax ERROR";
                Histo.historial1 += "\r\n";

            }
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            try
            {
                Operador = "-";
                Histo.historial1 += Screen.Text + " " + Operador + " ";
                First = double.Parse(Screen.Text);
                Screen.Clear();
            }
            catch (System.FormatException)
            {
                Screen.Text = "Syntax ERROR";
                Histo.historial1 += "\r\n";
            }
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                Operador = "*";
                Histo.historial1 += Screen.Text + " " + Operador + " ";
                First = double.Parse(Screen.Text);
                Screen.Clear();
            }
            catch (System.FormatException)
            {
                Screen.Text = "Syntax ERROR";
                Histo.historial1 += "\r\n";
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            try
            {
                Operador = "/";
                Histo.historial1 += Screen.Text + " " + Operador + " ";
                First = double.Parse(Screen.Text);
                Screen.Clear();
            }
            catch (System.FormatException)
            {
                Screen.Text = "Syntax ERROR";
                Histo.historial1 += "\r\n";
            }
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            try
            {
                Second = double.Parse(Screen.Text);
                double Resultado;
                Histo.historial1 += Screen.Text + " = ";
                if (Operador == "+")
                {
                    Resultado = Class.Suma.Sumar(First, Second);
                    Screen.Text = Resultado.ToString();
                    Ans = Resultado.ToString();
                    Histo.historial1 += Resultado.ToString();
                }
                else if (Operador == "-")
                {
                    Resultado = Class.Resta.Restar(First, Second);
                    Screen.Text = Resultado.ToString();
                    Ans = Resultado.ToString();
                    Histo.historial1 += Resultado.ToString();
                }
                else if (Operador == "*")
                {
                    Resultado = Class.Multiplicacion.Multiplicar(First, Second);
                    Screen.Text = Resultado.ToString();
                    Ans = Resultado.ToString();
                    Histo.historial1 += Resultado.ToString();
                }
                else if (Operador == "/")
                {
                    if (Second == 0)
                    {
                        Screen.Text = "Math ERROR";
                        Ans = "0";
                        Histo.historial1 += "Math ERROR";
                    }
                    else
                    {
                        Resultado = Class.Division.Dividir(First, Second);
                        Screen.Text = Resultado.ToString();
                        Ans = Resultado.ToString();
                        Histo.historial1 += Resultado.ToString();
                    }
                }
                Histo.historial1 += "\r\n";
            }
            catch (System.FormatException)
            {
                Screen.Text = "Syntax ERROR";
                Histo.historial1 = "Syntax ERROR";
                Histo.historial1 += "\r\n";
            }
        }

        private void BorrarCaracter_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length == 1)
            {
                Screen.Text = "";
            }
            if (Screen.Text.Length >= 1)
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Count() - 1);
            }

        }

        private void BorrarTodo_Click(object sender, EventArgs e)
        {
            Screen.Clear();
        }

        private void ANS_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + Ans;
        }


        private void Historial_Click(object sender, EventArgs e)
        {
            PanelScreen.Text = Histo.historial1;
            panel1.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void BorrarHistorial_Click(object sender, EventArgs e)
        {
            Histo.historial1 = "";
            PanelScreen.Text = "";
        }
    }
}
