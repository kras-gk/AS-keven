// 3. Classe Biblioteca:
// ○ Gerencia uma coleção de ItemBiblioteca.
// ○ Métodos: AdicionarItem, RemoverItem.
// ○ Métodos com sobrecarga: BuscarItemPorTitulo e BuscarItemPorId.



class Biblioteca
{
    public List<ItemBiblioteca> colecao; 

    public Biblioteca()
    {
        colecao=new List<ItemBiblioteca>(); // criei uma lista de itembiblioteca
    }


    public void AdicionarItem(ItemBiblioteca item) // criei um metodo para adicionar item
    {
        colecao.Add(item);
    }


    public void RemoverItem(int itemid) // criei um metodo para remover item
    {
          
        ItemBiblioteca itemParaRemover = colecao.Find(i => i.Id == itemid);
        if (itemParaRemover != null)
        {
            colecao.Remove(itemParaRemover);
            Console.WriteLine($"Item removido: {itemParaRemover.Titulo}");
        }
        else
        {
            Console.WriteLine("Item não encontrado.");
        }
    }



    public void Listaritens() // criei um metodo para listar os item da lista 
    {
        foreach(var item in colecao)
        {
           
            Console.WriteLine( $"{item.Titulo}    {item.Id}");
        }
    }
       public ItemBiblioteca  BuscarItemPorTitulo(string titulo) // metodo para buscar livro por titulo
    {
        return colecao.Find(item => item.Titulo == titulo);
    }


      
   

    public ItemBiblioteca BuscarItemPorId(int id) // metdodo para buscar livro por id
    {
        return colecao.Find(item=> item.Id == id);
    }
    
}