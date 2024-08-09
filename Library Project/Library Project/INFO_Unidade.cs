using Library_Project.controle;
using Library_Project.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class INFO_Unidade : Form
    {
        ModeloUnidade unidade = new ModeloUnidade();
        ModeloLivro livro = new ModeloLivro();
        ControleLivro controle = new ControleLivro();
        int codi = 0;
        String nom = "";
        String nome_livro = "";
        String codi1 = "";

        public INFO_Unidade(ModeloUnidade unidade, ModeloLivro livro)
        {
            codi = unidade.CD_Unidade;
            codi1 = livro.CD_Livro;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void INFO_Unidade_Load(object sender, EventArgs e)
        {
            Conexao cn = new Conexao();
            try
            {
                DataTable dados;
                dados = cn.obterdados("Select * from Table_Unidade where CD_Unidade = '" + codi + "'"); ;
                //livro.Descricao_Livro = dados.Rows[0][7].ToString();

                DataTable dados1;
                dados1 = cn.obterdados("Select * from Table_Livro where CD_Livro = '" + codi1 + "'");


                nom = dados.Rows[0][1].ToString();
                nome_livro = dados1.Rows[0][1].ToString();
                label1.Text = nom;
                label3.Text = nome_livro;

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

