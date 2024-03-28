using ClientHealthWebserviceV3.Models;
using ClientHealthWebserviceV3.Models.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace ClientHealthWebserviceV3.BL.ClientActions
{
    public interface IClientActions
    {
        public Client? GetClient(string name);
        public List<Client> GetClients(string? name = null);
        public ActionResult<Client> SetClient(Client client);
        public ClientConfigDto GetClientConfiguration();
        public ClientConfigDto SetClientConfiguration(ClientConfigDto config);

    }
}