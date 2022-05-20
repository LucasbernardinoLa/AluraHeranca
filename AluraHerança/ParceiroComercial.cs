using AluraHeranca.Sistemas;

namespace AluraHeranca
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return senha == senha;
        }
    }
}
