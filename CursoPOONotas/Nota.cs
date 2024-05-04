using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOONotas
{
    public interface INota
    {
        string Descricao { get; set; }
        void Exibir();
    }

    public class Nota : INota
    {
        public string Descricao { get; set; }

        public void Exibir()
        {
            Console.WriteLine(Descricao);
            Console.WriteLine("--------------------------------------");
        }
    }
}