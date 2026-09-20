namespace repaso_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPunto2 formulario = new FormPunto2();
            formulario.ShowDialog();
        }
    }
}
