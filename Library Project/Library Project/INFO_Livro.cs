using Library_Project.controle;
using Library_Project.modelo;
using MySqlX.XDevAPI;
using System.Data;

namespace Library_Project
{
    public partial class INFO_Livro : Form
    {
        //criar a instancia do objeto usuario
        ControleLivro controle = new ControleLivro();
        string descricao;
        string codi = "";
        public INFO_Livro(ModeloLivro livro)
        {

            codi = livro.CD_Livro;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao cn = new Conexao();
            try
            {
                DataTable dados;
                dados = cn.obterdados("Select * from Table_Livro where CD_Livro = '" + codi + "'");
                //livro.Descricao_Livro = dados.Rows[0][7].ToString();

                descricao = dados.Rows[0][7].ToString();
                label1.Text = descricao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BNT_Reservar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
