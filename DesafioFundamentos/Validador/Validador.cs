// o Validador possui funções utilitárias para validar uma placa
using System.Text;

public class Validador {

  // Essa é a função principal da classe, ela deve ser utilizada para validar placas
  public static bool EhValida(string placa) {
    string placaNormalizada = placa.ToLower();

    if(!Ascii.IsValid(placaNormalizada)) {
      return false;
    }

    List<int> numeros = new(3);
    List<char> chars = new(4);
    
    foreach(char c in placaNormalizada) {
      if(char.IsNumber(c)) {
        numeros.Add(c);
      } else {
        chars.Add(c);
      }
    }

    if(numeros.Count != 3 || chars.Count != 4) {
      return false;
    }

    return true;
  }
}