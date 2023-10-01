namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbPrimerNum.Text = "0";
            tbSegundoNum.Text = "0";


        }

        Calculadora calculadora = new Calculadora();

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbPrimerNum.Text);
            double b = Convert.ToDouble(tbSegundoNum.Text);

            double r = calculadora.Suma(a, b);

            tbResultado.Text = r.ToString(r % 1 == 0 ? "G" : "F6");

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbPrimerNum.Text);
            double b = Convert.ToDouble(tbSegundoNum.Text);

            double r = calculadora.Resta(a, b);

            tbResultado.Text = r.ToString(r % 1 == 0 ? "G" : "F6");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbPrimerNum.Text);
            double b = Convert.ToDouble(tbSegundoNum.Text);

            double r = calculadora.Multiplicacion(a, b);

            tbResultado.Text = r.ToString(r % 1 == 0 ? "G" : "F6");
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbPrimerNum.Text);
            double b = Convert.ToDouble(tbSegundoNum.Text);

            double r = calculadora.Division(a, b);

            tbResultado.Text = r.ToString(r % 1 == 0 ? "G" : "F6");
        }
    }
}