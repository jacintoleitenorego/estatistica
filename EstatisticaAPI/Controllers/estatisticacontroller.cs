
using Microsoft.AspNetCore.Mvc;
using EstatisticaAPI.Models.estatistica;

namespace EstatisticaAPI.Controllers
{
    [Route("[controller]")]
    public class estatisticacontroller : Controller
    {
        estatistica estatistica = new estatistica(); 
    }
}