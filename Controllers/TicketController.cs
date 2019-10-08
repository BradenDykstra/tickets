using tickets.Services;
using System;

namespace tickets.Controllers
{
  public class TicketController
  {
    TicketService _ticketService = new TicketService();
    public void Draw()
    {
      foreach (string message in _ticketService.messages)
      {
        Console.WriteLine(message);
      }
    }

    public void UserInput()
    {
      _ticketService.Write();
      Draw();
      while (true)
      {
        string input = Console.ReadLine();
        switch (input)
        {
          case "q":
            Console.Clear();
            Environment.Exit(0);
            break;
          case "n":
            System.Console.WriteLine("Ticket name:");
            break;
          default:
            if (int.TryParse(input, out int inputInt))
            {
              Console.Clear();
              _ticketService.Write(inputInt);
              Draw();
            }
            else
            {
              System.Console.WriteLine("YOU ARE WRONG");
            }
            break;
        }
      }
    }
  }
}