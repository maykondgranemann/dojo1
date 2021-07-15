using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    struct Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public void Cadastro()
        {
            Console.WriteLine("Digite o ID da categoria");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do categoria");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a descrição da categoria");
            Descricao = Console.ReadLine();
        }
      
    }

}
