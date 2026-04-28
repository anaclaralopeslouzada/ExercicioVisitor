namespace ExercicioVisitor
{
    public interface IRegistro
    {
        // O método Accept é a porta de entrada para o Visitor
        void Aceitar(IVisitor visitor);
    }
}
