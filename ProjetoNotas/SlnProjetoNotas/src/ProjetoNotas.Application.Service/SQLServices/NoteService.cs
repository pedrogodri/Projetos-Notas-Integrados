using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Application.Service.SQLServices
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _repository;
        public NoteService(INoteRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Delete(NoteDTO entity)
        {
            throw new NotImplementedException();
        }

        public List<NoteDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(note => new NoteDTO
                {
                    Id = note.Id,
                    Title = note.Title,
                    Description = note.Description,
                    Category = note.Category,
                    Fixed = note.Fixed,
                    TimeNote = note.TimeNote,
                    User = note.User,
                })
                .ToList();
        }

        public Task<NoteDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(NoteDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(NoteDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
