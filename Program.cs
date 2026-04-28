using System.Collections.Generic;

namespace ExercicioVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma lista de registros capturados na Amazônia
            var registros = new List<IRegistro>
            {
                new RegistroTemperatura { Local = "Manaus", Valor = 33.5 },
                new RegistroPH { Rio = "Tapajós", Nivel = 6.8 }
            };

            // Criando os formatadores (Visitors)
            var relatorioPdf = new RelatorioPDFVisitor();
            var relatorioJson = new RelatorioJSONVisitor();

            Console.WriteLine("Gerando Relatórios em PDF");
            foreach (var r in registros) r.Aceitar(relatorioPdf);

            Console.WriteLine("\nGerando Relatórios em JSON");
            foreach (var r in registros) r.Aceitar(relatorioJson);
        }
    }
}
