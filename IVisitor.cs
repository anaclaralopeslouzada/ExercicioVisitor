namespace ExercicioVisitor
{
    // A interface Visitor define as operações de formatação para cada tipo de registro
    public interface IVisitor
    {
        void VisitarRegistroTemperatura(RegistroTemperatura temp);
        void VisitarRegistroPH(RegistroPH ph);
    }
}
