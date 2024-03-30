using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Repository.IRepository;
using WebApplication9.Models.Dto.VentaDto;
using WebApplication9.Models;
namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly ILogger<VentasController> _logger;
        private readonly IVentasRepositorio _ventasRepo;
        private readonly IMapper _mapper;
        protected Response _response;

        public VentasController(ILogger<VentasController> logger, IVentasRepositorio ventasRepo, IMapper mapper, Response response)
        {
            _logger = logger;
            _ventasRepo = ventasRepo;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Response>> GetFactura()
        {
            try
            {
                _logger.LogInformation("Obtener Todas las ventas");
                IEnumerable<Venta> ventaList = await _ventasRepo.ObtenerTodos();
                _response.Resultado = _mapper.Map<IEnumerable<VentaDto>>(ventaList);
                _response.StatusCode = System.Net.HttpStatusCode.OK;
                return Ok(_response);
            }catch (Exception ex)
            {
                _response.isExitoso = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }


    }
}
