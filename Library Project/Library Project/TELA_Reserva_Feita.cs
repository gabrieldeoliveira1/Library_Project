using Library_Project.controle;
using Library_Project.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class TELA_Reserva_Feita : Form
    {

        ClUsercontrole user = new ClUsercontrole();
        ModeloLivro ModeloLivro = new ModeloLivro();

        Conexao cn = new Conexao();
        string codi = "";
        public TELA_Reserva_Feita(ClUserModelo user)
        {
            codi = user.ID_Aluno;
            InitializeComponent();
        }

        private void TELA_Reserva_Feita_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable dados_aluno;
                dados_aluno = cn.obterdados("Select * from Table_User where ID_Aluno = '" + codi + "'");

                label1.Text = dados_aluno.Rows[0]["ID_Aluno"].ToString();
                label2.Text = dados_aluno.Rows[0]["NameUser"].ToString();


                //Pegando data atual
                String dia = DateTime.Now.Day.ToString();
                String mon = DateTime.Now.Month.ToString();
                String ano = DateTime.Now.Year.ToString();;
                String hora = DateTime.Now.Hour.ToString();
                String minutos = DateTime.Now.Minute.ToString();
                String seg = DateTime.Now.Second.ToString();

                string data_Hoje = ano + "-" + mon + "-" + dia + " " + hora + ":" + minutos + ":" + seg;

                //obterdados das informações de data da reserva.
                DataTable dados_data;
                dados_data = cn.obterdados($"Select ABS(DATEDIFF('{data_Hoje}', DT_previsao_devolucao)) - 1 AS dias_faltando from Table_Reservas where CD_Reservas = 5");
                label3.Text = dados_data.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
