using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _service;

        public NoteController(INoteService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<NoteDTO> GetUsers()
        {
            return _service.FindAll();
        }

        [HttpGet("{id}")]
        public Task<NoteDTO> GetUser(int id)
        {
            return _service.FindById(id);
        }
    }
}
