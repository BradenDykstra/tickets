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
          case "quit":
          case "q":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
            break;
          case "new":
          case "n":
            System.Console.WriteLine("Ticket name:");
            string newName = Console.ReadLine();
            Console.WriteLine("Ticket description:");
            string newDesc = Console.ReadLine();
            _ticketService.newTicket(newName, newDesc);
            Console.Clear();
            _ticketService.Write();
            Draw();
            break;
          case "d":
          case "delete":
            System.Console.WriteLine("Delete which ticket?");
            string index = Console.ReadLine();
            if (int.TryParse(index, out int indexInt))
            {
              _ticketService.Delete(indexInt);
            }
            Console.Clear();
            _ticketService.Write();
            Draw();
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
              Console.Clear();
              _ticketService.Write();
              Draw();
            }
            break;
        }
      }
    }
  }
}