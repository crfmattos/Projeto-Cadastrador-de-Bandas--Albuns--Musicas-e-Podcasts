// Uma classe no C# é uma estrutura que define o comportamento e as propriedades de um objeto
class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set;} // O nome disso em c# é propriedades e começa com pascal case
    public string DescricaoResumida 
    { 
        get
        {
            return $"A música {Nome} pertence à banda {Artista}";
        }
    }



    // Método deifine o comportamento de uma classe
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}