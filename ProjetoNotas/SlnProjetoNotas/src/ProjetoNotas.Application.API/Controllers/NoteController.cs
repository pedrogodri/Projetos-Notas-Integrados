using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteService _service;
        public NoteController(INoteService service)
        {
            this._service = service;
        }
        public JsonResult Index()
        {
            var listNotesUser = _service.FindAll();
            return Json(listNotesUser);
        }
    }
}
