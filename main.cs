using System;

class Program {
  public static void Main (string[] args) {
    string nome, entrada;
    double n1, n2, n3, medexcer, media, A;
  
    Console.WriteLine ("Digite o nome do aluno: ");

    nome = Console.ReadLine();

    Console.WriteLine ("Digite a média dos excercicios: ");

    entrada = Console.ReadLine();

    medexcer = Double.Parse(entrada);

    Console.WriteLine ("Digite a primeira nota ");
    
    entrada = Console.ReadLine();

    //Função para converter texto em decimal, pois toda entrada possui o formato em texto por padrão.

    n1 = Double.Parse(entrada);

    Console.WriteLine ("Digite a segunda nota ");
    
    entrada = Console.ReadLine();
    
    n2 = Double.Parse(entrada);

    Console.WriteLine ("Digite a terceira nota ");
    
    entrada = Console.ReadLine();
    
    n3 = Double.Parse(entrada);
    
    media = (n1 + n2 *2 + n3 * 3 + medexcer) / 7;

    if (media >= 9.0);
    {
      A = (media);
      Console.WriteLine (" O Aluno(a) " + nome + "Foi teve sua mèdia" + A);
    
    else
      if ((media >= 7.5) && (media < 9.0));
    {
      A = (media);
      Console.WriteLine (" O Aluno(a) " + nome + "Foi teve sua mèdia" + A);

      
      }
    Console.WriteLine ("A média da nota do aluno(a) " + nome + " é de " + media);
  }
}