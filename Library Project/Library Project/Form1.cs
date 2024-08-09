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
    public partial class Form1 : Form
    {
        ModeloLivro modeloLivro = new ModeloLivro();
        ModeloUnidade unidade = new ModeloUnidade();

        public Form1()


        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //passou o valor selecionado fixo
            modeloLivro.CD_Livro = comboBox1.Text;
           // modeloLivro.CD_Livro = "320C111L2021";
            INFO_Livro info = new INFO_Livro(modeloLivro);
            info.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // isso é apenas para teste 
            modeloLivro.Index_Unidade = 1;
            //continuação
            unidade.CD_Unidade = modeloLivro.Index_Unidade;
            INFO_Unidade info = new INFO_Unidade(unidade);
            info.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao cn = new Conexao();
            try
            {
                comboBox1.DataSource = cn.obterdados("Select CD_Livro, Nome_Livro from Table_Livro");
                //livro.Descricao_Livro = dados.Rows[0][7].ToString();
                comboBox1.DisplayMember = "CD_Livro";
                comboBox1.ValueMember = "Nome_Livro";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
