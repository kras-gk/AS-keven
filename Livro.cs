// Classe Livro (Classe Derivada de ItemBiblioteca):
// ○ Deve herdar de ItemBiblioteca.
// ○ Propriedade adicional: Autor (string).
// ○ Construtor que recebe id, título e autor, e inicializa a DescricaoInterna.
// ○ Método ExibirDescricaoInterna para imprimir a DescricaoInterna.


class Livro : ItemBiblioteca // fiz uma herança aqui
{
    public string Autor;

    public Livro (int id, string Titulo, string autor) : base(id,Titulo)
    {
        this.Autor = autor;
    }

    public void ExibirDescricaoInterna() // criei um metodo para exibir a descrição interna do livro
    {
        Console.WriteLine($"Descrição Interna do Livro '{Titulo}': {DescricaoInterna}");
    }
   
}