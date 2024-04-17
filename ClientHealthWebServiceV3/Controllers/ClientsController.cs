using Microsoft.AspNetCore.Mvc;
using ClientHealthWebserviceV3.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ClientHealthWebserviceV3.BL.Auth;
using ClientHealthWebserviceV3.BL.ClientActions;
using ClientHealthWebserviceV3.Models.Configuration;

namespace ClientHealthWebserviceV3.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientActions _clientActions;
        private readonly ILogger<ClientsController> _logger;
        public ClientsController(IClientActions clientActions, ILogger<ClientsController> logger)
        {
            _clientActions = clientActions;
            _logger = logger;
        }
        [ApiKeyAuthorization("ClientApiKeys")]
        [HttpGet]
        [Route("api/[controller]/Client")]
        public ActionResult<Client> GetClient([Required]string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _logger.LogDebug("Trying to get client of name {name}", name);
            try
            {
                var clientResult = _clientActions.GetClient(name);
                if (clientResult == null)
                {
                    return NotFound("Client not found");
                }
                return clientResult;
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [ApiKeyAuthorization("ClientApiKeys")]
        [HttpPut]
        [Route("api/[controller]/Client")]
        public ActionResult<Client> SetClient([FromBody] ClientDto clientDto)
        {
            if (clientDto == null)
            {
                _logger.LogWarning("Failed to parse received client data.");
                return BadRequest("Failed to parse received client data.");
            }
            try
            {
                var client = clientDto.ConvertClientDtoToClient();
                return _clientActions.SetClient(client);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to set client data from client: [{clientDto.Hostname}] {ex.Message}");
                return BadRequest(ex);
            }
        }

        [ApiKeyAuthorization("ClientApiKeys")]
        [HttpGet]
        [Route("api/[controller]/ClientConfiguration")]
        public ActionResult<ClientConfigDto> GetClientConfiguration()
        {
            try
            {
                return _clientActions.GetClientConfiguration();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve client configuration: {ex.Message}");
                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Update or set the cleint configuration in the database
        /// </summary>
        /// <param name="config">The config is the full JSON configuration file for the client.</param>
        /// <param name="ApiKey" in="header"></param>
        /// <returns></returns>
        [ApiKeyAuthorization("ConfigurationApiKeys")]
        [HttpPut]
        [Route("api/[controller]/ClientConfiguration")]
        public ActionResult<ClientConfigDto> SetClientConfiguration([FromBody] ClientConfigDto config)
        {
            try
            {
                return _clientActions.SetClientConfiguration(config);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
