using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    struct Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public void CadastroProduto()
        {
            Console.Write("ID: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Valor: ");
            Valor = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
