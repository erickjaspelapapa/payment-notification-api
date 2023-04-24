using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xData.Objects.Transaction;
using xDomain.Transactions;
using xRepository._91128;

namespace payment_notification_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PaymentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getTransactionList")]
        public IActionResult GetTransactionList(int clientId)
        {
            try
            {
                var response = _unitOfWork.Repository<tvfPaymentList>().StoredInterpolated($"spGetPaymentList @clientId={clientId}");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("getPaymentRecords")]
        public IActionResult getPaymentRecords()
        {
            try
            {
                var response = _unitOfWork.Repository<tvfPaymentRecords>().StoredInterpolated($"spGetPaymentRecords");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("getProjected")]
        public IActionResult getProjected(string id)
        {
            try
            {
                var response = _unitOfWork.Repository<tvfProjectedPayment>().StoredInterpolated($"spGetProjectedPayment @id={id}");
                return Ok(response);
            }   
            catch (Exception ex)
            {
                return BadRequest(ex);  
            }
        }

        [HttpGet]
        [Route("getTransaction")]
        public async Task<IActionResult> GetTransaction(int transId)
        {
            try
            {
                payment response = await _unitOfWork.Repository<payment>().GetById(transId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("insertTransaction")]
        public async Task<IActionResult> InsertNewTransaction([FromBody] paymentObj payload)
        {
            try
            {
                payment mapped = _mapper.Map<payment>(payload);
                await _unitOfWork.Repository<payment>().Add(mapped);
                await _unitOfWork.Commit();

                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("updateTransaction")]
        public async Task<IActionResult> UpdateTransaction([FromBody] paymentObj payload)
        {
            try
            {
                payment mapped = _mapper.Map<payment>(payload);
                int? clientId = mapped.clientId;

                IEnumerable<paymentLines> forDelete = await _unitOfWork.Repository<paymentLines>().All();

                forDelete.Where(w => w.transId == mapped.id).ToList().ForEach(fe =>
                {
                    _unitOfWork.Repository<paymentLines>().Delete(fe);
                });

                _unitOfWork.Repository<payment>().Update(mapped);
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
