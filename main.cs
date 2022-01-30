using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    Encryption encrypt = new Encryption();
    while(true){
    Console.WriteLine("1 Encrypt a message");
    Console.WriteLine("2 Decrypt a message");
    Console.WriteLine("3 Quit");
    Console.WriteLine();
    Console.WriteLine("Enter Choice");
    int choice = Convert.ToInt32(Console.ReadLine());
    if(choice == 1){
      Console.WriteLine();
      Console.WriteLine("Enter a message");
      string phrase = Console.ReadLine();
      Console.WriteLine(encrypt.encrypt_message(phrase));
      Console.WriteLine();
      }
    if(choice == 2){
      Console.WriteLine();
      Console.WriteLine("Enter a message");
      string phrase = Console.ReadLine();
      Console.WriteLine(encrypt.decrypt_message(phrase));
      Console.WriteLine();  
    }
    if(choice == 3){
      System.Environment.Exit(0);
    }
  }
}

class Encryption {
    List<char> symbols = new List<char>(); 
    List<char> alphabets = new List<char>();

public Encryption(){
symbols.Add('!'); symbols.Add('@'); symbols.Add('#'); symbols.Add('$'); symbols.Add('^'); symbols.Add('&'); symbols.Add('*'); symbols.Add('('); symbols.Add(')'); symbols.Add('_'); symbols.Add('-'); symbols.Add('+'); symbols.Add('='); symbols.Add('?'); symbols.Add(','); symbols.Add('{'); symbols.Add('}'); symbols.Add('['); symbols.Add(']'); symbols.Add('/'); symbols.Add('|'); symbols.Add(';'); symbols.Add(':'); symbols.Add('.'); symbols.Add('<'); symbols.Add('>');
for(char letter ='a'; letter<='z'; letter++) {
alphabets.Add(letter); 
      }
    }
  public char return_alphabet(int x){
    return alphabets[x];
    }
  public int return_alphabet_index(char x) {
    return alphabets.IndexOf(x);
    }
  public char return_symbol(int x){
    return symbols[x];
  }
  public int return_symbol_index(char x){
    return symbols.IndexOf(x);
      }
  public char[] encrypt_message(string x){
    x = x.ToLower();
    char[] charArray = x.ToCharArray();
    char[] Encrypted_Message = new char[x.Length];
    char ch;
    int index;
    for(int i = 0; i < charArray.Length; i++){
      ch = charArray[i];
      if(!Char.IsLetter(ch)){
        Console.WriteLine("Error: Invalid Character");
        break;
      }
      index = alphabets.IndexOf(ch);
      Encrypted_Message[i] = symbols[index];
    }
    return Encrypted_Message;
      }
  public char[] decrypt_message(string x){
    char[] SymbolArray = x.ToCharArray();
    char[] Decrypted_Message = new char[x.Length];
    char ch;
    int index;
    for(int i = 0; i < SymbolArray.Length; i++){
      ch = SymbolArray[i];
      if(Char.IsLetter(ch)){
        Console.WriteLine("Error Invalid Symbol");
        break;
      }
      index = symbols.IndexOf(ch);
      Decrypted_Message[i] = alphabets[index];
    }
    return Decrypted_Message;
      }
    }
  }