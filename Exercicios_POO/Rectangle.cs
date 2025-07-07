namespace Exercicios_POO; 
/* Exercício: Criando a Classe "Retangulo"
Objetivo: Criar uma classe chamada "Retangulo" para calcular a área e o perímetro de um retângulo.
Requisitos:
Crie uma classe chamada Retangulo.
A classe Retangulo deve ter os seguintes atributos (campos):
largura (double): A largura do retângulo.
altura (double): A altura do retângulo.
A classe Retangulo deve ter um construtor que receba os valores para a largura e a altura como parâmetros e os inicialize.
Crie um método chamado CalcularArea() que retorne a área do retângulo (largura * altura).
Crie um método chamado CalcularPerimetro() que retorne o perímetro do retângulo (2 * (largura + altura)).
No método Main do seu programa, crie pelo menos dois objetos da classe Retangulo, usando o construtor para inicializá-los com diferentes valores de largura e altura.
Para cada objeto Retangulo criado, chame os métodos CalcularArea() e CalcularPerimetro() e imprima os resultados no console, formatados da seguinte forma:
Área: [valor da área] Perímetro: [valor do perímetro]


Exemplo de Saída Esperada:
Área: 20 Perímetro: 18

Área: 7.5 Perímetro: 11
*/
public class Rectangle {
    public double height, width;
    public Rectangle(double height, double width) {
        this.height = height;
        this.width = width;
    }
    
    public void CalcArea() {
        Console.WriteLine("Área: " + height * width);
    }
    
    public void CalcPerimeter() {
        Console.WriteLine("Perimetro: " + 2*(height + width));
    }
}