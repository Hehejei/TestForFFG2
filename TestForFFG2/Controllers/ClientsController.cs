using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestForFFG2.Models;

namespace TestForFFG2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly DbCntx _context;

        public ClientsController(DbCntx context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetClients")]
        public async Task<ActionResult<IEnumerable<ClientsView>>> GetClients()
        {
            var clients = await _context.clients.ToListAsync();

            var contacts = await _context.clientContacts.ToListAsync();

            var clientsView = new List<ClientsView>();

            foreach (var client in clients)
            {
                clientsView.Add(new ClientsView 
                { 
                    ClientName = client.ClientName,
                    NumberContact = contacts.Count(u => u.ClientId == client.Id)
                });
            }

            return clientsView;
        }

        [HttpGet]
        [Route("GetClientsMoreTwoContact")]
        public async Task<ActionResult<IEnumerable<Clients>>> GetClientsMoreTwoContact()
        {
            var clients = await _context.clients.ToListAsync();

            var contacts = await _context.clientContacts.ToListAsync();

            var clientList = new List<Clients>();

            foreach (var client in clients)
            {
                if(contacts.Count(u => u.ClientId == client.Id) > 2)
                { 
                    clientList.Add(new Clients
                    {
                        ClientName = client.ClientName,
                        Id =client.Id

                    });
                }
            }

            return clientList;
        }
    }
}
