using Daewoo_Web_Application.Models.Interfaces;

namespace Daewoo_Web_Application.Models.Repositories
{
    public class TerminalRepository : ITerminalRepo
    {
        public List<Terminal> GetTerminals()
        {
            var DB = new DaewooExpressApplicationContext();                  // Making connection with DataBase Context

            var query = DB.Terminals.Select(terminal => new { terminal.Name, terminal.Address, terminal.Phone, terminal.TerminalImage });

            List<Terminal>? terminals = new List<Terminal>();

            if (query != null)
            {
                foreach (var t in query)
                {
                    Terminal terminal = new Terminal
                    {
                        Name = t.Name,
                        Address = t.Address,
                        Phone = t.Phone,
                        TerminalImage = t.TerminalImage
                    };

                    terminals.Add(terminal);
                }
                return terminals;
            }
            return terminals;
        }
    }
}
