namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }
    private string _nome;
    private string _sobrenome;
    private string _nomeCompleto =>$"{Nome} {Sobrenome}".ToUpper();
    public string Nome { get => _nome; set => _nome = value; }
    public string Sobrenome { get => _sobrenome; set => _sobrenome = value; }
    public string NomeCompleto => _nomeCompleto;
}