// 4. Classe Program (Ponto de Entrada):
// ○ Crie instâncias de Biblioteca e Livro.
// ○ Demonstre a adição, busca e remoção de livros.
//  ○ Exiba a DescricaoInterna do livro.

Biblioteca biblioteca= new(); // estancie biblioteca
Livro livro1= new( 1,"golias", "keven");// estanciei o objeto livro 1 
Livro livro2= new(2, "Aventuras de Pi", "gustavo");// estanciei o objeto livro 2 
Livro livro3= new(3,"Exterminador do futuro", "Pedro");// estanciei o objeto livro 3

biblioteca.AdicionarItem(livro1);
biblioteca.AdicionarItem(livro3);
biblioteca.AdicionarItem(livro2);


Console.WriteLine("-------Coleção incial--------");
biblioteca.Listaritens();



ItemBiblioteca livroEncontrado = biblioteca.BuscarItemPorTitulo("Aventuras de Pi"); // buscar livro por nome do livro

        if (livroEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado por título: {livroEncontrado.Titulo}");
        }
        else
        {
            Console.WriteLine("Livro não encontrado por título.");
        }


ItemBiblioteca livroEncontradoporid = biblioteca.BuscarItemPorId(3); // buscar livro por id

    if(livroEncontradoporid != null)
    {
        Console.WriteLine($"Livro encontrado por id: {livroEncontradoporid.Id}");
    }
    else
    {
        Console.WriteLine("Lvro não encotrado por ID");
    }


livro1.ExibirDescricaoInterna(); // descrição do livro 1
livro2.ExibirDescricaoInterna(); // descrição do livro 2
livro3.ExibirDescricaoInterna();//descrição do livro 3


int livroParaRemoverId = 1;// criei um varieal int para remover o livro da posição 1
    biblioteca.RemoverItem(livroParaRemoverId);

    // Listagem final
    Console.WriteLine("---- Coleção Final ----");
    biblioteca.Listaritens();


