using Library_Project.controle;
using Library_Project.modelo;
using MySqlX.XDevAPI;
using System.Data;
using System.Drawing;
using System.Drawing.Text;

namespace Library_Project
{
    public partial class INFO_Livro : Form
    {
        //criar a instancia do objeto usuario
        ControleLivro controle = new ControleLivro();
        string descricao;
        String codi = "";
        String nom = "";

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

                descricao = dados.Rows[0][7].ToString();
                label1.Text = descricao;
                label2.Text = dados.Rows[0][1].ToString();

                //DataTable cadastro;
                //cadastro = cn.cadastrar ("INSERT INTO Table_reservas (CFK_Livro) VALUES ({label2.Text})");

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BNT_Voltar_ao_inicio_Click(object sender, EventArgs e)
        {

        }
    }
}
