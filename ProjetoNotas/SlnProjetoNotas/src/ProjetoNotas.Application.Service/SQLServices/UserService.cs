using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Application.Service.SQLServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository) 
        {
            _repository = repository;
        }
        public async Task<int> Delete(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(user => new UserDTO
                {
                    id = user.Id,
                    name = user.Name,
                    login = user.Login,
                    password = user.Password,
                })
                .ToList();
        }

        public async Task<UserDTO> FindById(int id)
        {
            var dto = new UserDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(UserDTO entity)
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

        public Task<int> Update(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
