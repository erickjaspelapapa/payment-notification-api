using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xData.Objects.Setting;
using xDomain.Settings;
using xRepository._91128;

namespace payment_notification_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getCategories")]
        public async Task<IActionResult> GetCategories()
        {
            IEnumerable<Category> categories = await _unitOfWork.Repository<Category>().addIncludes(x => x.identifications).All();

            return Ok(categories);
        }

        [HttpGet]
        [Route("getIdentification")]
        public async Task<IActionResult> GetIdentification() 
        { 
        
            IEnumerable<Identification> identification = await _unitOfWork.Repository<Identification>().All();
            IEnumerable<identificationObj> response = _mapper.Map<IEnumerable<identificationObj>>(identification);

            return Ok(response);
        }

        [HttpPost]
        [Route("insertCategory")]
        public async Task<IActionResult> InsertCategory([FromBody] categoryObj payload)
        {
            try
            {
                Category mapped = _mapper.Map<Category>(payload);
                await _unitOfWork.Repository<Category>().Add(mapped);
                await _unitOfWork.Commit();

                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("updateCategory")]
        public async Task<IActionResult> UpdateCategory([FromBody] categoryObj payload)
        {
            try
            {
                Category mapped = _mapper.Map<Category>(payload);
                int? id = mapped.id;

                IEnumerable<Identification> forDelete = await _unitOfWork.Repository<Identification>().All();

                forDelete.Where(w => w.catId == mapped.id).ToList().ForEach(fe =>
                {
                    _unitOfWork.Repository<Identification>().Delete(fe);
                });

                _unitOfWork.Repository<Category>().Update(mapped);
                await _unitOfWork.Commit();

                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [Route("deleteCategory")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            Category category = await _unitOfWork.Repository<Category>().GetById(id);
            _unitOfWork.Repository<Category>().Delete(category);

            await _unitOfWork.Commit();

            return Ok();
        }


    }
}
