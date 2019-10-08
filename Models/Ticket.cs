using tickets.Interfaces;

namespace tickets.Models
{
  public class Ticket : ITicket
  {

    public string Name { get; set; }
    public string Desc { get; set; }
    public Ticket(string name, string desc)
    {
      Name = name;
      Desc = desc;
    }
    public string getTemplate()
    {
      string template = $@"
{Name}
{Desc}
      ";

      return template;
    }
  }
}