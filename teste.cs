using System;
namespace Idk
{
  public class Main1
  {
    static void Main
    {
      string static_string = "This is a simple programm";
      int static_integer = 2;
      decimal static_decimal = 44.3m;
      var static_var = "FTP AS400";
      Random dice = new Random();
      roll_dice = dice.Next(1,6);
      if (static_var.Contains("AS400"))
      {
        Console.WriteLine("static_var was AS400 in.\n");
      } else if (static_var.Contains("FTP")) {
        Console.WriteLine("static_var was FTP in it.\n");
      } else {
        Console.WriteLine("static_var send an unknown response.");
      }
      Console.WriteLine("\u0021\u0022\u0026\0026\u0055 \t Unicode bro");
      Console.WriteLine(static_string + static_var);
    }
  }
}
