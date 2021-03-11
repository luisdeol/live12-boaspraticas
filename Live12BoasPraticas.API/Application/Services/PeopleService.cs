using Live12BoasPraticas.API.Infrastructure.Integration;
using Live12BoasPraticas.API.Infrastructure.Repositories;

namespace Live12BoasPraticas.API.Application.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly IErpIntegrationService _erpIntegrationService;
        public PeopleService(IPeopleRepository peopleRepository, IErpIntegrationService erpIntegrationService)
        {
            _peopleRepository = peopleRepository;
            _erpIntegrationService = erpIntegrationService;
        }    
    }
}
