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
    public class TransactionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TransactionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork  = unitOfWork;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("getTransactions")]
        public async Task<IActionResult> GetTransactionList()
        {
            try
            {
                IEnumerable<transaction> response = await _unitOfWork.Repository<transaction>()
                                                                     .addIncludes(a => a.category)
                                                                     .addIncludes(a => a.identification)
                                                                     .All();

                IEnumerable<transactionListObj> result = _mapper.Map<IEnumerable<transactionListObj>>(response);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        [HttpGet]
        [Route("getDailySummary")]
        public IActionResult GetDailySummary(DateTime FromDate, DateTime ToDate)
        {
            try
            {
                var response = _unitOfWork.Repository<tvfDailySummary>().StoredInterpolated($"spGetDailySummary @fromDate={FromDate}, @toDate={ToDate}");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("InsertTransaction")]
        public async Task<IActionResult> InsertTransactions([FromBody]transactionObj payload)
        {
            try
            {
                transaction inserted = _mapper.Map<transaction>(payload);

                inserted.created_dt = DateTime.Now;
                inserted.updated_dt = DateTime.Now;

                await _unitOfWork.Repository<transaction>().Add(inserted);
                await _unitOfWork.Commit();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("UpdateTransaction")]
        public async Task<IActionResult> UpdateTransactions([FromBody] transactionObj payload)
        {
            try
            {
                transaction upd = _mapper.Map<transaction>(payload);

                upd.updated_dt = DateTime.Now;

                _unitOfWork.Repository<transaction>().Update(upd);
                await _unitOfWork.Commit();

                return Ok(upd);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [Route("DeleteTransaction")]
        public async Task<IActionResult> DeleteTransactions(int TransId)
        {
            try
            {
                transaction upd = await _unitOfWork.Repository<transaction>().GetById(TransId);
                _unitOfWork.Repository<transaction>().Delete(upd);

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
