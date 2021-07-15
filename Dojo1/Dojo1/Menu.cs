using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    class Menu
    {
        public void MontaMenu()
        {
            Cabecalho();
            Opcoes();
            Rodape();
            Escolha();

        }

        public void Cabecalho()
        {
            Console.WriteLine("******************** DOJO LABS ********************");
            Console.WriteLine("******************** Bem-vindo ********************");

        }

        public void Rodape()
        {
            Console.WriteLine("---------------------------------------------------");
        }
        public void Opcoes()
        {
            Console.WriteLine("\n 1 - Cadastrar Produto \n 2 - Cadastro Categoria \n 3 - Listar Produtos \n 4 - Listar Categorias \n 0 - Sair");
        }
        
        public void Escolha()
        {
            Console.Write("Escolha uma opcao: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 0:
                    //Sair

                    break;
                case 1:
                    //Cadastrar produto
                    Produto produto = new Produto();
                    produto.CadastroProduto();
                    break;
                case 2:
                    //Cadastrar categoria
                    break;
                case 3:
                    //Listar Produto
                    break;
                case 4:
                    //Listar Categoria
                    break;
            }

        }
    }
}
