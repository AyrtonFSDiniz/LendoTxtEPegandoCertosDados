using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendoTxtEPegandoCertosDados
{
    public static class LerArquivo
    {
        public static List<ArquivoModel> LendoArquivo(string nomeArquivo, string parteDoNomeDesejado)
        {
            var resultado = new List<ArquivoModel>();

            using (var streamReader = new StreamReader(nomeArquivo))
            {
                while (!streamReader.EndOfStream)
                {
                    string? linha = streamReader.ReadLine();

                    var palavra = linha.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (palavra.Count() == 1 && palavra[0].Contains(parteDoNomeDesejado))
                    {
                        resultado.Add(new ArquivoModel
                        {
                            Nome = palavra[0],
                        });
                    }
                }
            }

            return resultado;

        }
    }
}
