using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xDomain.Settings;
using xRepository._91128;

namespace payment_notification_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjGroupController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<ProjectGroup> _handler;
        public ProjGroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _handler = _unitOfWork.Repository<ProjectGroup>();
        }

        [HttpGet]
        [Route("PrjGroupList")]
        public async Task<IActionResult> GetPrjGroupList()
        {
            try
            {
                IEnumerable<ProjectGroup> response = await _handler.All();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("InsertPrjGroup")]
        public async Task<IActionResult> InsertPrjGroups([FromBody] ProjectGroup PrjGroup)
        {
            try
            {
                await _handler.Add(PrjGroup);
                await _unitOfWork.Commit();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("UpdatePrjGroup")]
        public async Task<IActionResult> UpdatePrjGroups([FromBody] ProjectGroup PrjGroup)
        {
            try
            {
                ProjectGroup upd = await _handler.GetById(PrjGroup.id);

                upd.projGrpDescription = PrjGroup.projGrpDescription;

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
        [Route("DeletePrjGroup")]
        public async Task<IActionResult> DeletePrjGroups(int PrjGroupId)
        {
            try
            {
                ProjectGroup upd = await _handler.GetById(PrjGroupId);
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
