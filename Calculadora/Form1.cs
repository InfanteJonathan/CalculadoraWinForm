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

        //Crear Metodo de obtencion del button
        public string obtenerBoton(object sender)
        {
            Button bnt = (Button)sender;
            string num1 = bnt.Text;
            return num1;
        }
        
        //Crear metodo para cumplir condicion y retornar numero
        
        public void  agregarNumero(string num)
        {
            if (txbResultado.Text.Equals("0"))
            {
                txbResultado.Text = "";
            }
            txbResultado.Text += num;
        }

        //Creando la funcionalidad de los Buttons

        private void btnUno_Click(object sender, EventArgs e)
        {
            //Se llama al metodo obtenerBoton dentro de var num
            var num = obtenerBoton(sender);
            //se llama al metodo agregar numero y se le asigna la variable
            agregarNumero(num);


        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            
            var num = obtenerBoton(sender);
            agregarNumero(num);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            var num = obtenerBoton(sender);
            agregarNumero(num);

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            var num = obtenerBoton(sender);
            agregarNumero(num);

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            var num = obtenerBoton(sender);
            agregarNumero(num);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            var num = obtenerBoton(sender);
            agregarNumero(num);
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            var num = obtenerBoton(sender);
            agregarNumero(num);
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            var num = obtenerBoton(sender);
            agregarNumero(num);
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            var num = obtenerBoton(sender);
            agregarNumero(num);

        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            var num = obtenerBoton(sender);
            agregarNumero(num);

        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            var num = obtenerBoton(sender);
            agregarNumero(num);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // se crea un string para almacenar la cadena que
            //esta dentro del textbox resultado
            string expresion = txbResultado.Text;
            // se llama al metodo calcularExpresion de la clase
            //calculador y se le asigna la cadena de expresion
            string resultado = Calculadora.CalcularExpresion(expresion);    
            txbCadenaResultado.Text = resultado;
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