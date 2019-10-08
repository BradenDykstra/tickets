using System;
using tickets.Controllers;

namespace tickets
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Clear();
      new TicketController().UserInput();
    }
  }
}
