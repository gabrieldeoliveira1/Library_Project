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
        Conexao cn = new Conexao();
        string descricao;
        String codi = "";
        String nom = "";
        String codigo = "";
        string dia = "";
        string mon = "";
        string ano = "";
        string hora = "";
        string minutos = "";
        string seg = "";
        //dia, m�s e ano em int a ser usado na devolu��o.
        int dia1 = 0;
        int mon1 = 0;
        int ano1 = 0;

        public INFO_Livro(ModeloLivro livro, ClUserModelo user)
        {
            user.ID_Aluno = "ALU001";
            codigo = user.ID_Aluno.ToString();
            codi = livro.CD_Livro;
            InitializeComponent();

   

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                DataTable dados;
                dados = cn.obterdados("Select * from Table_Livro where CD_Livro = '" + codi + "'");

                descricao = dados.Rows[0]["Descricao_Livro"].ToString();
                label1.Text = descricao;
                label2.Text = dados.Rows[0]["Nome_Livro"].ToString();

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
            Conexao conexao = new Conexao();
            ModeloReservas re = new ModeloReservas();
            ControleReservas ctr = new ControleReservas();

            DataTable dados;
            dados = cn.obterdados("Select * from Table_Livro where CD_Livro = '" + codi + "'");

            DataTable data_aluno;
            data_aluno = conexao.obterdados("Select * from Table_User where ID_Aluno = '" + codigo + "'");

            dia = DateTime.Now.Day.ToString();
            dia1 = DateTime.Now.Day;
            mon = DateTime.Now.Month.ToString();
            mon1 = DateTime.Now.Month;
            ano = DateTime.Now.Year.ToString();
            ano1 = DateTime.Now.Year;
            hora = DateTime.Now.Hour.ToString();
            minutos = DateTime.Now.Minute.ToString();
            seg = DateTime.Now.Second.ToString();

            int dia_devolucao = dia1 + 28;
            int mon_devolucao = 0;
            int ano_devolucao = 0;
            string data_devolucao = "";

            if (dia_devolucao > 28)
            {
                mon_devolucao = mon1 + 1;
                dia_devolucao = 1 + (dia_devolucao - 27);
                if(mon_devolucao > 12)
                {
                    ano_devolucao = ano1 + 1;
                    mon_devolucao = 1;
                }
                else
                {
                    ano_devolucao = ano1;
                }


            }
            else
            {
                ano_devolucao = ano1;
                mon_devolucao = mon1;
                dia_devolucao = dia1;
            }

            data_devolucao = ano_devolucao.ToString() + "-" + mon_devolucao.ToString() + "-" + dia_devolucao.ToString() + " " + hora + ":" + minutos + ":" + seg;
            string datas = ano + "-" + mon  + "-" + dia + " " + hora + ":" + minutos + ":" + seg;
            //datas2 se refere a data de previs�o de devolu��o.
            string datas2 = ano + "-" + mon  + "-" + dia + " " + hora + ":" + minutos + ":" + seg;

            re.DT_reserva = datas;
            re.DT_previsao_devolucao = data_devolucao;
            re.CFK_Livro = dados.Rows[0]["Order_Livro"].ToString();
            re.CFK_User = data_aluno.Rows[0]["ID_Aluno"].ToString();
            
                if(ctr.registrar_Reserva(re) == true)
            {
                TELA_Reserva_Feita tr = new TELA_Reserva_Feita();
                tr.ShowDialog();
            }
            else
            {
                TELA_ReservaNegada rn = new TELA_ReservaNegada();
                rn.ShowDialog();
            }
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
