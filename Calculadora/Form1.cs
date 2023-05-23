using System.Data;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCadenaResultado_TextChanged(object sender, EventArgs e)
        {

        }

        public string obtenerBoton(object sender)
        {
            Button bnt = (Button)sender;
            string num1 = bnt.Text;
            return num1;
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0"))
            {
                txbResultado.Text = "";
            }

            string num = obtenerBoton(sender);
            txbResultado.Text += num;


        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0"))
            {
                txbResultado.Text = "";
            }
            string num = obtenerBoton(sender);
            txbResultado.Text += num;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0"))
            {
                txbResultado.Text = "";
            }
            string num = obtenerBoton(sender);
            txbResultado.Text += num;

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0"))
            {
                txbResultado.Text = "";
            }
            string num = obtenerBoton(sender);
            txbResultado.Text += num;

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0"))
            {
                txbResultado.Text = "";
            }
            string num = obtenerBoton(sender);
            txbResultado.Text += num;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0"))
            {
                txbResultado.Text = "";
            }
            string num = obtenerBoton(sender);
            txbResultado.Text += num;
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0"))
            {
                txbResultado.Text = "";
            }
            string num = obtenerBoton(sender);
            txbResultado.Text += num;
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0"))
            {
                txbResultado.Text = "";
            }
            string num = obtenerBoton(sender);
            txbResultado.Text += num;
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0"))
            {
                txbResultado.Text = "";
            }

            string num = obtenerBoton(sender);
            txbResultado.Text += num;

        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0")) { txbResultado.Text = ""; }
            string num = obtenerBoton(sender);
            txbResultado.Text += num;

        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Equals("0")) { txbResultado.Text = ""; }
            string num = obtenerBoton(sender);
            txbResultado.Text += num;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string expresion = txbResultado.Text;
            DataTable dt = new DataTable();
            var res = dt.Compute(expresion, "");
            txbCadenaResultado.Text = res.ToString();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "-";
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "*";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "/";
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            txbResultado.Clear();
            txbCadenaResultado.Clear();
        }

        private void btnBorrarUno_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Length > 0)
            {
                txbResultado.Text = txbResultado.Text.Remove(txbResultado.Text.Length - 1);
            }
        }
    }
}