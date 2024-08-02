using Library_Project.controle;
using Library_Project.modelo;

namespace Library_Project
{
    public partial class INFO_Livro : Form
    {

        //criar a instancia do objeto usuario
        ModeloLivro modelo = new ModeloLivro();
        ControleLivro controle = new ControleLivro();
        public INFO_Livro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BNT_Reservar_Click(object sender, EventArgs e)
        {
  
        }
    }
}
