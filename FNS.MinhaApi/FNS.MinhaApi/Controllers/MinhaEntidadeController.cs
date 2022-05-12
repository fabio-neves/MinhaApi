using CRUDService.AspNetCore.Controllers;
using FNS.CRUDService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FNS.MinhaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MinhaEntidadeController : CRUDController<Modelos.MinhaEntidade>
    {
        public MinhaEntidadeController(IBaseDomainService<Modelos.MinhaEntidade> baseDomainService) : base(baseDomainService)
        {

        }
    }
}
