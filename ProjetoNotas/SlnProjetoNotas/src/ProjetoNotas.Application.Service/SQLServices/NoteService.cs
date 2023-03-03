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
                    id = note.Id,
                    title = note.Title,
                    description = note.Description,
                    category = note.Category,
                    fixeded = note.Fixed,
                    timeNote = note.TimeNote,
                    user = note.User,
                })
                .ToList();
        }

        public async Task<NoteDTO> FindById(int id)
        {
            var dto = new NoteDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(NoteDTO entity)
        {
            if (entity.id > 0)
            {
                return _repository.Update(entity.mapToEntity());
            }
            else
            {
                return _repository.Save(entity.mapToEntity());
            }
        }

        public Task<int> Update(NoteDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
