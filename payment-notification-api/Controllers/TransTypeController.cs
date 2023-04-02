using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xDomain.Settings;
using xRepository._91128;

namespace payment_notification_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransTypeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRepository<TransferType> _handler;
        public TransTypeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _handler = _unitOfWork.Repository<TransferType>();
        }

        [HttpGet]
        [Route("TransTypeList")]
        public async Task<IActionResult> GetTransTypeList()
        {
            try
            {
                IEnumerable<TransferType> response = await _handler.All();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("InsertTransType")]
        public async Task<IActionResult> InsertTransTypes([FromBody] transTypeObj TransType)
        {
            try
            {
                TransferType inserted = _mapper.Map<TransferType>(TransType);

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
        [Route("UpdateTransType")]
        public async Task<IActionResult> UpdateTransTypes([FromBody] transTypeObj TransType)
        {
            try
            {
                TransferType upd = _mapper.Map<TransferType>(TransType);
                
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
        [Route("DeleteTransType")]
        public async Task<IActionResult> DeleteTransTypes(int TransTypeId)
        {
            try
            {
                TransferType upd = await _handler.GetById(TransTypeId);
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
