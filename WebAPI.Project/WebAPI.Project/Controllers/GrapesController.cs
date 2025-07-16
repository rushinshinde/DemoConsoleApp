using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebAPI.Project.Model;


namespace WebAPI.Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrapesController : ControllerBase
    {
        [HttpGet]
        [Route("/grapesDeatils")]
        public Grapes GetGrapesData()
        {
            return new Grapes()
            {
                Name = "shenen",
                Color = "purpule",
                Variety = "New"
            };
        }

        [HttpGet]
        [Route("/grapeList")]

        public List<Grapes> GetGrapesList() {
            return new List<Grapes>()
            {
                new Grapes() {
                    Name = "shenen",
                    Color = "purpule",
                    Variety = "New"
                },
                new Grapes() {
                    Name = "shardeno",
                    Color = "white",
                    Variety = "juici"
                },
                new Grapes(){
                    Name = "Ara-15",
                    Color = "black",
                    Variety = "white"
                }

            };
        }
    }
}

