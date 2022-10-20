using System;
// static void ln(){
//     string[] letter = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j" , "k" , "l" , "m" , "n"     , "o" , "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
//     Console.WriteLine ("TYPE IN THE LETTER YOU WANT A NUMBER ASSIGNED TO");
//     string why = Console.ReadLine();
//     int num = Array.IndexOf(letter, why);
//     num += 1;
//     Console.WriteLine(num);
//   }
class Program {
  public static void Main (string[] args){ 
     string[] letter = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j" , "k" , "l" , "m" , "n", "o" , "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
    Console.WriteLine ("TYPE IN THE LETTER YOU WANT A NUMBER ASSIGNED TO");
    string why = Console.ReadLine();
    int num = Array.IndexOf(letter, why);
    num += 1;
    Console.WriteLine(num);
    
  
  

  
}
}
