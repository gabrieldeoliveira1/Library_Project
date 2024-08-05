using Library_Project.controle;
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

        ControleLivro controle = new ControleLivro();
        String codi = "";
        String nom = "";

        public INFO_Unidade()
        {
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
                dados = cn.obterdados("Select * from Table_Unidade where CD_Unidade = '" + codi + "'");
                //livro.Descricao_Livro = dados.Rows[0][7].ToString();

                nom = dados.Rows[1][0].ToString();
                label1.Text = nom;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    }

