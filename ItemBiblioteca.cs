//1. Classe ItemBiblioteca (Classe Base):
//○ Deve ser uma classe abstrata.
//○ Propriedades: Id (int), Titulo (string).
//○ Propriedade protegida: DescricaoInterna (string).
//○ Construtor que inicializa Id, Titulo e define um valor padrão para
//DescricaoInterna.


abstract class ItemBiblioteca
{
   public int Id { get; set; }

    public string Titulo { get; set; }

   protected string DescricaoInterna;


   public ItemBiblioteca(int id, string Titulo) // criei um construtor
   {
        DescricaoInterna = "descrição padrão";// ja coloquei um valor padrão para descrição interna
        this.Id= id;
        this.Titulo= Titulo;
        

   }
}