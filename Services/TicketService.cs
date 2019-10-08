using System.Collections.Generic;
using System;
using tickets.Models;

namespace tickets.Services
{
  public class TicketService
  {
    public List<string> messages { get; set; }

    public List<Ticket> allTickets = new List<Ticket>();


    public void Write()
    {
      messages.Clear();
      for (int i = 0; i < allTickets.Count; i++)
      {
        string message = allTickets[i].Name;
        messages.Add($"{i + 1}. {message}");
      }
    }

    public void Write(int index)
    {
      messages.Clear();
      if (index > allTickets.Count || index < 1)
      {
        messages.Add("YOU ARE WRONG");
      }
      else
      {
        messages.Add($"{allTickets[index - 1].Name}");
        messages.Add($"{allTickets[index - 1].Desc}");
      }
    }

    public void Delete(int index)
    {
      messages.Clear();
      if (index > allTickets.Count || index < 1)
      {
        messages.Add("YOU ARE WRONG");
      }
      else
      {
        Ticket i = allTickets[index - 1];
        allTickets.Remove(i);
      }
    }

    public void newTicket(string name, string desc)
    {
      allTickets.Add(new Ticket(name, desc));
    }

    public TicketService()
    {
      messages = new List<string>();
    }
  }
}