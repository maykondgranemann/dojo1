using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    class Menu
    {
        List<Produto> produtos = new List<Produto>();
        List<Categoria> categorias = new List<Categoria>();
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
        public void Voltar()
        {
            Console.WriteLine("Digite qualquer tecla para voltar para o menu principal!");
            Console.ReadLine();
        }
        public void Escolha()
        {
            do
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
                        do
                        {
                            Produto produto = new Produto();
                            produto.CadastroProduto();
                            produtos.Add(produto);
                        } while (Sn(2));
                    

                        break;
                    case 2:
                        //Cadastrar categoria
                        do
                        {
                            Categoria categoria = new Categoria();
                            categoria.Cadastro();
                            categorias.Add(categoria);
                        } while (Sn(2));
                        break;
                    case 3:
                        //Listar Produto
                        foreach (var item in produtos)
                        {
                            Console.WriteLine($"\nID: {item.Id}\nNome: {item.Nome}\n Valor: {item.Valor}");
                        }
                        Voltar();
                        break;
                    case 4:
                        //Listar Categoria
                        foreach (var item in categorias)
                        {
                            Console.WriteLine($"\nID: {item.Id}\nNome: {item.Nome}\n Descrição: {item.Descricao}");
                        }
                        Voltar();
                        break;
                }
                Console.Clear();
            } while (Sn(1));

        }
        public bool Sn(int opcao)
        {
            bool resposta;
            string resp;
            do
            {
                if (opcao == 1)
                {
                    Opcoes();
                    Escolha();
                }
                else
                {
                    Console.WriteLine("Deseja cadastrar um novo item?");
                }
                resp = Console.ReadLine().Trim().ToLower();
                switch (resp)
                {
                    case "s":
                        resposta = true;
                        return resposta;
                    case "n":
                        resposta = false;
                        return resposta;
                    default:
                        Console.WriteLine("Opçao Invalida. Digite Novamente!");
                        break;
                }
            } while (true);
        }
    }
}
