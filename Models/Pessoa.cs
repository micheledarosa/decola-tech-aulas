using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decola_Tech_2024.Models
{
    public class Pessoa  // é recomendado que o  nome do arquivo seja o mesmo da classe
    {
        public string Nome { get; set; } // get = pegando o valor
        public int Idade { get; set; }  // set - atribuindo um valor

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é " +  // pulando a linha para organização
            $"{Nome}, e tenho {Idade} anos.");    
        }
    }
}