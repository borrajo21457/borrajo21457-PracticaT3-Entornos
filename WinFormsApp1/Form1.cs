namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama_OskarBorr22_23;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste_OskarBorr22_23;

            //Leo el telegrama
            textoTelegrama_OskarBorr22_23 = txtTelegrama.Text;
            // telegrama urgente?
           

            if (cbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else tipoTelegrama = 'o';

            //Obtengo el número de palabras que forma el telegrama
            string[] cortarPalabras = textoTelegrama_OskarBorr22_23.Split(' ');
            numPalabras = cortarPalabras.Length;

            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o' && numPalabras > 0)
                if (numPalabras <= 10)
                    coste_OskarBorr22_23 = 2.5;
                else
                    coste_OskarBorr22_23 = 0.5 * numPalabras;
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste_OskarBorr22_23 = 5;
                else
                    coste_OskarBorr22_23 = 5 + 0.75 * (numPalabras - 10);
            else
                coste_OskarBorr22_23 = 0;
            txtPrecio.Text = coste_OskarBorr22_23.ToString() + " euros";
        }
    }
}