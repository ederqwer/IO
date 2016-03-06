using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rnagrupado.Checked && rdiscretos.Checked && rpoisson.Checked && rcuadrada.Checked)
            {
                table.Columns.Add("x * Fi", "x * Fi");
                table.Columns.Add("p(x)", "p(x)");
                table.Columns.Add("n*P(x) (Fei)", "n*P(x) (Fei)");
                table.Columns.Add("Xo^2", "Xo^2");
                double sumFi = 0;
                double sumx_fi = 0;
                double sumpx = 0;
                double sumFei = 0;
                double sume_prueba = 0;
                double prom;
                int gl;
                gl = table.RowCount - 3;
                for (int i = 0; i < table.RowCount - 1; i++)
                {
                    int xi = int.Parse(table.Rows[i].Cells[0].Value + "");
                    int fi = int.Parse(table.Rows[i].Cells[1].Value + "");
                    sumFi += fi; sumx_fi += xi * fi;
                    table.Rows[i].Cells[2].Value = xi * fi;
                }

                prom = sumx_fi / sumFi;
                for (int i = 0; i < table.RowCount - 1; i++)
                {
                    int xi = int.Parse(table.Rows[i].Cells[0].Value + "");
                    double px = (Math.Pow(prom, xi) * Math.Pow(Math.E, (-1 * prom))) / Factorial(xi);
                    double fei = px * sumFi;
                    table.Rows[i].Cells[3].Value = px;
                    table.Rows[i].Cells[4].Value = fei;
                    sumpx += px;
                    sumFei += fei;
                }
                for (int i = 0; i < table.RowCount - 1; i++)
                {
                    double f_i = double.Parse(table.Rows[i].Cells[1].Value + "");
                    double f_ei = double.Parse(table.Rows[i].Cells[4].Value + "");
                    double e_prueba = Math.Pow((f_i - f_ei), 2) / f_ei;
                    table.Rows[i].Cells[5].Value = e_prueba;
                    sume_prueba += e_prueba;
                }
                label1.Text = "λ =" + Math.Round(prom, 6);
                label2.Text = "gl = " + gl;
                table.Rows.Add("∑", "n=" + sumFi + "", sumx_fi + "", sumpx + "", sumFei + "", sume_prueba + "");

            }
        }
        public static Int64 Factorial(int num)
        {
            Int64 resul = 0;
            if (num == 0)
                resul = 1;
            else
                resul = num * Factorial(num - 1);
            return resul;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
        }
    }
}
