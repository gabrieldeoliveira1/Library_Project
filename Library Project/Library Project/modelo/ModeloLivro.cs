using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project.modelo
{
    internal class ModeloLivro
    {
        
        //declaro as variaveis do sistema com relacao ao banco de dados
        public string CD_Livro;
        public string Nome_Livro;
        public int QTD_estoque;
        public int Numb_Paginas;
        public int Edicao_Livro;
        public string IMG_Livro;
        public string Descricao_Livro;

        public ModeloLivro() {

            //iniciar as variaveis zeradas

            Nome_Livro = null;
            QTD_estoque = 0;
            Numb_Paginas = 0;
            Edicao_Livro = 0;
            IMG_Livro = null;
            Descricao_Livro = null;
        
        
        }
    }
  

}
