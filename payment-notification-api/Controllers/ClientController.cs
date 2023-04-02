using Microsoft.AspNetCore.Mvc;
using xDomain.Clients;
using xRepository._91128;

namespace payment_notification_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<clientsModel> _handler;
        public ClientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _handler = _unitOfWork.Repository<clientsModel>();
        }

        [HttpGet]
        [Route("ClientList")]
        public async Task<IActionResult> GetClientAll()
        {
            try
            {
                IEnumerable<clientsModel> response = await _handler.All();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("ClientById")]
        public async Task<IActionResult> GetClientId(int clientId)
        {
            try
            {
                clientsModel response = await _handler.GetById(clientId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
