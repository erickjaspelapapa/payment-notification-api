using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xData.Objects.Client;
using xDomain.Clients;
using xRepository._91128;

namespace payment_notification_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRepository<clientsModel> _handler;
        public ClientController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _handler = _unitOfWork.Repository<clientsModel>();
        }

        [HttpGet]
        [Route("ClientList")]
        public async Task<IActionResult> GetClientAll()
        {
            try
            {
                IEnumerable<clientsModel> response = await _handler
                    .addIncludes(a => a.Agent)
                    .addIncludes(a => a.ProjGroup)
                    .addIncludes(a => a.TransType)
                    .All();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("ClientById")]
        public async Task<IActionResult> GetClientId(string clientId)
        {
            try
            {
                clientsModel response = await _handler
                    .addIncludes(a => a.Agent)
                    .addIncludes(a => a.ProjGroup)
                    .addIncludes(a => a.TransType)
                    .where(w => w.clientId == clientId)
                    .FirstOrDefaultAsync();
                
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("InsertClient")]
        public async Task<IActionResult> InsertClient([FromBody] clientObj client)
        {
            try
            {
                clientsModel inserted = _mapper.Map<clientsModel>(client);

                inserted.created_dt = DateTime.Now;
                inserted.updated_dt = DateTime.Now;

                await _handler.Add(inserted);
                await _unitOfWork.Commit();
                return await GetClientId(inserted.clientId); ;
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("UpdateClient")]
        public async Task<IActionResult> UpdateClient([FromBody] clientObj client)
        {
            try
            {
                clientsModel upd = _mapper.Map<clientsModel>(client);
                upd.updated_dt = DateTime.Now;

                _handler.Update(upd);
                await _unitOfWork.Commit();

                return await GetClientId(upd.clientId);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [Route("DeleteClient")]
        public async Task<IActionResult> DeleteClient(int ClientId)
        {
            try
            {

                clientsModel upd = await _handler.GetById(ClientId);
                _handler.Delete(upd);

                await _unitOfWork.Commit();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
