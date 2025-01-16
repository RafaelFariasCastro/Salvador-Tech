using EstagioProject.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EstagioProject.Controllers
{
    public class VagasController
    {
        public VagasController(ApplicationDbContext context) 
        {
                    this.context = context;
        }
        public IApplicationResult Index()
        {
            var estagio = context.Vagas.ToList
            return View(estagio);
        }
        
    }
}
