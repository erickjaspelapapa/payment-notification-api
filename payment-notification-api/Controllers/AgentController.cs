using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xDomain.Settings;
using xRepository._91128;

namespace payment_notification_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<AgentDetail> _handler;
        public AgentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _handler = _unitOfWork.Repository<AgentDetail>();
        }

        [HttpGet]
        [Route("AgentList")]
        public async Task<IActionResult> GetAgentList()
        {
            try
            {
                IEnumerable<AgentDetail> response = await _handler.All();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("InsertAgent")]
        public async Task<IActionResult> InsertAgents([FromBody] AgentDetail agent)
        {
            try
            {
                await _handler.Add(agent);
                await _unitOfWork.Commit();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("UpdateAgent")]
        public async Task<IActionResult> UpdateAgents([FromBody] AgentDetail agent)
        {
            try
            {
                AgentDetail upd = await _handler.GetById(agent.id);

                upd.agentFirstName = agent.agentFirstName;
                upd.agentLastName = agent.agentLastName;

                _handler.Update(upd);
                await _unitOfWork.Commit();

                return Ok(upd);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }



        [HttpDelete]
        [Route("DeleteAgent")]
        public async Task<IActionResult> DeleteAgents(int AgentId)
        {
            try
            {
                AgentDetail upd = await _handler.GetById(AgentId);
                _handler.Delete(upd);

                await _unitOfWork.Commit();

                return Ok(true);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
