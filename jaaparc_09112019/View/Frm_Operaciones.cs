using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Frm_Operaciones : Form
    {
        public Frm_Operaciones()
        {
            InitializeComponent();
        }

        private void btnfibonacci_Click(object sender, EventArgs e)
        {
            int a, b, c, i, num;
            a = 0;
            b = 1;
            listresultado.Items.Add(a);
            listresultado.Items.Add(b);
            num = Convert.ToInt32(txtnumero.Text);
            for (i = 3; i <= num; i++)
            {
                c = a + b;
                listresultado.Items.Add(c);
                a = b;
                b = c;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            listresultado.Items.Clear();
        }

        private void btnfactorial_Click(object sender, EventArgs e)
        {

            int cantidad, resultado = 1;

            cantidad = Convert.ToInt32(txtnumero.Text);
            for (int i = 1; i <= cantidad; i++)
            {
                resultado = i * resultado;


            }
            listresultado.Items.Add(resultado);
            //int x, s = 1; //Se declaran dos variables.
            //x = Convert.ToInt32(txtnumero.Text); //Se realiza la conversion a tipo entero.
            //if (x == 0)
            //{
            //    //textBox2.Text = s.ToString();
            //    listresultado.Items.Add(s);
            //}
            //else
            //{
            //    for (int i = 1; i <= x; i++)
            //    {
            //        s = s * i;

            //        listresultado.Items.Add(s);
            //        // textBox2.Text = s.ToString();
            //        // textBox3.Text = textBox1.Text;
            //    }
            //}
        }

        private void btnpares_Click(object sender, EventArgs e)
        {
            int sumaP = 0, sumaI = 0, num;
            num = Convert.ToInt32(txtnumero.Text);
            if (num >= 100)
            {
                for (int i = 2; i <= num; i += 2)
                {

                    sumaP = i + sumaP;

                }
                for (int i = 1; i <= num; i += 2)
                {
                    sumaI = i + sumaI;
                }

                listresultado.Items.Add("Suma de Pares: " + sumaP);
                listresultado.Items.Add("Suma de Impares: " + sumaI);
            }
            else
            {
                MessageBox.Show("el numero debe ser igual o mayor que 100");
            }
        }

        private void btnpascal_Click(object sender, EventArgs e)
        {
            int i = 0;
            int Count = 0;
            int Cantidad = 0;
            int Columna = 0;
            int Fila = 0;


            Cantidad = Convert.ToInt32(txtnumero.Text);
           // Cantidad = int.Parse(Console.ReadLine());

            int[,] MAT = new int[Cantidad + 1, Cantidad + 1];

            // PROCESO
            for (i = 1; i <= Cantidad; i++)
            {
                for (Count = 1; Count <= Cantidad; Count++)
                {
                    if ((Count == 1) | (i == Count))
                    {
                        MAT[i, Count] = 1;
                    }
                    else
                    {
                        MAT[i, Count] = MAT[i - 1, Count] + MAT[i - 1, Count - 1];
                    }
                }
            }

            // SALIDA
            Fila = 2;
            for (i = 1; i <= Cantidad; i++)
            {
                Columna = 40 - (i * 2);
                for (Count = 1; Count <= Cantidad; Count++)
                {
                    if (MAT[i, Count] != 0)
                    {
                       //Console.SetCursorPosition(Columna, Fila);

                       // listresultado.Items.AddRange(Columna, Fila);
                        Console.Write(MAT[i, Count]);
                        listresultado.Items.Add(MAT[i, Count]);
                        Columna = Columna + 4;
                    }
                }
                Fila = Fila + 1;
                Console.WriteLine();
            }

        
    }

        private void btnprimo_Click(object sender, EventArgs e)
        {

        }
    }
}
