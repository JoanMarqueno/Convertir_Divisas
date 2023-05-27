using Microsoft.VisualBasic;
using System.Linq.Expressions;

namespace ConversioDivises
{
    public partial class Form1 : Form
    {
        double[,] valorsc = new double[,]
           {
                {1,1.07,142.76},
                {0.93,1,133.21},
                {0.0070,0.0075,1},
           };
        public Form1()
        {
            InitializeComponent();
            button3.Click += new EventHandler(teclado_click);
            button4.Click += new EventHandler(teclado_click);
            button5.Click += new EventHandler(teclado_click);
            button6.Click += new EventHandler(teclado_click);
            button7.Click += new EventHandler(teclado_click);
            button8.Click += new EventHandler(teclado_click);
            button9.Click += new EventHandler(teclado_click);
            button10.Click += new EventHandler(teclado_click);
            button11.Click += new EventHandler(teclado_click);
            button12.Click += new EventHandler(teclado_click);
            comboBox1.Items.Add("€");
            comboBox1.Items.Add("$");
            comboBox1.Items.Add("¥");
            comboBox2.Items.Add("€");
            comboBox2.Items.Add("$");
            comboBox2.Items.Add("¥");
            




        }

        private void teclado_click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            String texto = boton.Text;
            textBox1.Text += texto;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
           
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

       private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0)
            {

                MessageBox.Show("Escoje una divisa");

            }
            else
            {


                try
                {
                    int x = comboBox1.SelectedIndex;
                    int y = comboBox2.SelectedIndex;
                    if (x == y)
                    {
                        MessageBox.Show("No és pot convertir a la mateixa divisa.");
                        textBox1.Text = "";
                    }
                    else
                    {

                        String valor = textBox1.Text.ToString();
                        Boolean semafor = valor.Contains(".");
                        if (semafor)
                        {
                            MessageBox.Show("Introduce valores numéricos");
                            textBox1.Text = "";
                        }
                        else
                        {


                            valor = valor.Trim();
                            Double valor1 = Convert.ToDouble(valor);

                            Double conversion = valor1 * valorsc[x, y];
                            /*
                            Double euro = 1.07;
                            Double valorfinal = euro * valor1;
                            */
                            conversion = Math.Round(conversion, 2);

                            String elemento = comboBox2.Text.ToString();

                            textBox1.Text = conversion.ToString() + elemento;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Introduce valores numéricos");
                    textBox1.Text = "";
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}