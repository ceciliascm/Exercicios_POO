// See https://aka.ms/new-console-template for more information
/*
Exercício: Criando a Classe "Livro"

Objetivo: Criar uma classe chamada "Livro" para representar informações sobre livros.

Requisitos:

Crie uma classe chamada Livro.

A classe Livro deve ter os seguintes atributos (campos):

titulo (string): O título do livro.
autor (string): O nome do autor do livro.
numeroPaginas (int): O número de páginas do livro.

A classe Livro deve ter um construtor que receba os valores para todos os atributos como parâmetros e os inicialize.

Crie um método chamado ExibirInformacoes() que imprima no console as informações do livro no seguinte formato:

Título: [titulo do livro]
Autor: [nome do autor]
Número de Páginas: [número de páginas]

No método Main do seu programa, crie pelo menos dois objetos da classe Livro, usando o construtor para inicializá-los com dados diferentes.

Chame o método ExibirInformacoes() para cada um dos objetos Livro que você criou.

Exemplo de Saída Esperada:

Título: Dom Quixote
Autor: Miguel de Cervantes
Número de Páginas: 863

Título: Cem Anos de Solidão
Autor: Gabriel García Márquez
Número de Páginas: 417

Dicas:

Lembre-se de usar os tipos de dados corretos para cada atributo.
O construtor deve ter o mesmo nome da classe.
Use Console.WriteLine() para imprimir as informações no método ExibirInformacoes().
 */
namespace Exercicios_POO;
class Ex1 {
    private static void Main(string[] args) {
        Book[] book = new Book[2];
    
        book[0] = new Book("Dom Quixote", "Miguel de Cervantes", 893);
        book[1] = new Book("Cem Anos de Solidão", " Gabriel García Márquez",  417);
    
    
        for (int i = 0; i < book.Length; i++)
        {
            book[i].ShowInfo();
        }
    }
}

class Book {
    public String title;
    public String writer;
    public int numberPages;
    
    
    public Book(String title, String writer, int numberPages)
    {
        this.title = title;
        this.writer = writer;
        this.numberPages = numberPages;
    }
	
    public void ShowInfo(){
        Console.WriteLine($"Título: {title}");
        Console.WriteLine($"Autor: {writer}");
        Console.WriteLine($"Número de páginas: {numberPages}\n");
    }
}