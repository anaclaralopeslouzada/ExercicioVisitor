using System;

namespace ExercicioVisitor
{
    // Visitor que gera saída em PDF
    public class RelatorioPDFVisitor : IVisitor
    {
        public void VisitarRegistroTemperatura(RegistroTemperatura temp) {
            Console.WriteLine($"[PDF] Gerando página de Temperatura: {temp.Local} mediu {temp.Valor}°C");
        }

        public void VisitarRegistroPH(RegistroPH ph) {
            Console.WriteLine($"[PDF] Gerando página de PH: Rio {ph.Rio} com nível {ph.Nivel}");
        }
    }

    // Visitor que gera saída em JSON 
    public class RelatorioJSONVisitor : IVisitor
    {
        public void VisitarRegistroTemperatura(RegistroTemperatura temp) {
            Console.WriteLine($"{{ \"tipo\": \"temp\", \"local\": \"{temp.Local}\", \"valor\": {temp.Valor} }}");
        }

        public void VisitarRegistroPH(RegistroPH ph) {
            Console.WriteLine($"{{ \"tipo\": \"ph\", \"rio\": \"{ph.Rio}\", \"valor\": {ph.Nivel} }}");
        }
    }
}
