using FNS.CRUDService.Interfaces;
using FNS.CRUDService.Model;
using FNS.MinhaApi.Modelos;
using System.Threading.Tasks;

namespace FNS.MinhaApi.Servicos
{
    public class MinhaEntidadeServico : IBaseDomainService<Modelos.MinhaEntidade>
    {
        public Task<ServiceResponse<MinhaEntidade>> Create(MinhaEntidade entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<int>> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<MinhaEntidade>> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<PagingResult>> List(PagingQuery pagingQuery)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<int>> Update(MinhaEntidade entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
