namespace AbrirFormulario
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirFormulario_Click(object sender, EventArgs e)
        {
            FormularioSecundario formularioSecundario = new FormularioSecundario();

            formularioSecundario.MdiParent = this;

            formularioSecundario.Show();

        }
    }
}
