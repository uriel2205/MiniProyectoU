using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analizadorLexico
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResLexico.Text = "";
            txtErroresLexico.Text = "";
            textBox1.Text = "";
            txtErroresSemantico.Text = "";
           
            dgvSintactico.Rows.Clear();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MiniCompilador analizador = new MiniCompilador();

                analizador.Analizador(textBox1.Text.ToString());

                txtResLexico.Text = analizador.dameListaToken();
                txtErroresLexico.Text = analizador.dameListaErrores();
                txtErroresSemantico.Text = analizador.dameListaErroresSemanticos();
                mostrarSintactico(analizador.dameListaSintactico(), analizador.dameSalida(), analizador.dameEntrada());
            } else {
                MessageBox.Show("El cuadro de texto está vacío");
            }
        }

        private void mostrarSintactico(List<String> lista, List<String> salida, List<String> entrada)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                dgvSintactico.Rows.Add(lista[i], salida[i], entrada[i]);
            }
        }

        private void txtExpresion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtArbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string publico = textBox1.Text.Replace("public", "publico");
            string mainvar = publico.Replace("main", "mi_main");
            string impresion = mainvar.Replace("imprimir", "MessageBox.Show");
            string entero1 = impresion.Replace("int", "entero");
            string float1 = entero1.Replace("float", "flotante");
            string return1 = float1.Replace("return", "retornar");
            string entero2 = return1.Replace("integer", "int");
            string simb = entero2.Replace("->", "=");
            string cond1 = simb.Replace("if", "si");
            string cond2 = cond1.Replace("while", "mientras");
            string cond3 = cond2.Replace("do", "hacer");
            string cadena1 = cond3.Replace("string", "cadena");
         
            textBox2.Text = cadena1;
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResLexico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
