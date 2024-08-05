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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModeloLivro modeloLivro = new ModeloLivro();
            modeloLivro.CD_Livro = "320C111L2021";
            INFO_Livro info = new INFO_Livro(modeloLivro);
            info.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModeloUnidade modeloUnidade = new ModeloUnidade();
            modeloUnidade.CD_Unidade = 0;
            INFO_Unidade info = new INFO_Unidade();
            info.ShowDialog();
        }
    }
}
