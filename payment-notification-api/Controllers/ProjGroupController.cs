using AutoMapper;
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
        private readonly IMapper _mapper;
        private readonly IRepository<ProjectGroup> _handler;
        public ProjGroupController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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
        public async Task<IActionResult> InsertPrjGroups([FromBody] prjGrpObj PrjGroup)
        {
            try
            {
                ProjectGroup inserted = _mapper.Map<ProjectGroup>(PrjGroup);

                inserted.created_dt = DateTime.Now;
                inserted.updated_dt = DateTime.Now;

                await _handler.Add(inserted);
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
        public async Task<IActionResult> UpdatePrjGroups([FromBody] prjGrpObj PrjGroup)
        {
            try
            {
                ProjectGroup upd = _mapper.Map<ProjectGroup>(PrjGroup);

                upd.updated_dt = DateTime.Now;

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
