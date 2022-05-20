using AluraHeranca.Funcionarios;

namespace AluraHeranca.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
