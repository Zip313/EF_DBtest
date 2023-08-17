using BusinessLogic.Contracts;
using BusinessLogic.Services.Mappers;
using DataAccess.Entities;
using DataAccess.Repositories.Abstarctions;
using System.Numerics;

namespace BusinessLogic.Services
{
    public class ClientService
    {
        private IClientRepository clientRepository;
        public ClientService(IClientRepository repository)
        {
            this.clientRepository = repository;
        }

        public void CreateClient(ClientDto clientDto)
        {
            clientRepository.Create(Mapper.DtoToClient(clientDto));
        }

        public IEnumerable<ClientDto> GetAllClients()
        {
            IEnumerable<Client> clients = clientRepository.Get();

            return clients.Select(c => Mapper.ClientToDto(c));
        }

        public IEnumerable<ClientDto> GetClientsByLastName(string partLastName)
        {
            

            IEnumerable<Client> clients = clientRepository.Get(p=>p.LastName==partLastName);

            return clients.Select(c => Mapper.ClientToDto(c));
                
        }
    }
}