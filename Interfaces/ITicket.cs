namespace tickets.Interfaces
{
  public interface ITicket
  {
    string Name { get; set; }
    string Desc { get; set; }
    string getTemplate();
  }
}