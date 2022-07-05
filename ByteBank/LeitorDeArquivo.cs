using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ByteBank
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {

            Arquivo = arquivo;
            int divisor = 0;
            int resultado = 10 / divisor;

            throw new FileNotFoundException();

            Console.WriteLine($"Abrindo arquivo: {arquivo}");

        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");

            throw new IOException();

            return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }

    }
}
