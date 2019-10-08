using tickets.Services;
using System;

namespace tickets.Controllers
{
  public class TicketController
  {
    TicketService _ticketService = new TicketService();
    public void Draw()
    {
      _ticketService.Write();
      foreach (string message in _ticketService.messages)
      {
        Console.WriteLine(message);
      }
    }

    public void UserInput()
    {
      Draw();
      string input = Console.ReadLine();
      switch (input)
      {
        case "q":
          Console.Clear();
          Environment.Exit(0);
          break;
        default:
          if (int.TryParse(input, out int inputInt))
          {
            System.Console.WriteLine("You have chosen " + input);
          }
          break;
      }
    }
  }
}