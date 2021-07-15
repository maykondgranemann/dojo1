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
    }
}
