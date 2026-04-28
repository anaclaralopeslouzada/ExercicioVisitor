namespace ExercicioVisitor
{
    public class RegistroTemperatura : IRegistro
    {
        public double Valor { get; set; } 
        public string Local { get; set; } 

        public void Aceitar(IVisitor visitor) => visitor.VisitarRegistroTemperatura(this);
    }

    public class RegistroPH : IRegistro
    {
        public double Nivel { get; set; } 
        public string Rio { get; set; } 

        public void Aceitar(IVisitor visitor) => visitor.VisitarRegistroPH(this);
    }
}
