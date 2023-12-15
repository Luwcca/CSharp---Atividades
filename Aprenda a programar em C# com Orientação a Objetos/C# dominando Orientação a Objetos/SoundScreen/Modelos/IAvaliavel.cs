namespace SoundScreen.Modelos
{
    internal interface IAvaliavel
    {
        void AdicionarNota(Avaliacao nota);//não tem {} pois não tem execução de código
        double Media { get; }

    }
}
