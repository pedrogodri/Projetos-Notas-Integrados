using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Interfaces.IService;
using ProjetoNotas.Infra.Data.Repository.Context;
using System.Security.AccessControl;

namespace ProjetoNotas.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<UserDTO> GetUsers()
        {
            return _service.FindAll();
        }

        [HttpGet("{id}")]
        public Task<UserDTO> GetUser(int id) 
        {
            return _service.FindById(id);
        }
    }
}
