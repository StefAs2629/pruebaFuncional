namespace programacionfuncionaltemporal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperacionesFinancieras dato = new OperacionesFinancieras();

            double midescuento =dato.CalcularDescuento(3800);
            MessageBox.Show(midescuento.ToString());



            midescuento = dato.DescuentoFuncional(3800);
            MessageBox.Show(midescuento.ToString());

            double miiva = dato.CalcularIva(3800);
            MessageBox.Show(miiva.ToString());
            
            miiva = dato.IvaFuncional(3800);
            MessageBox.Show(miiva.ToString());
        }
    }
}
