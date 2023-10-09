using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RobotDreams.API.Model;

namespace RobotDreams.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OppController : ControllerBase
    {
        [HttpGet]
        [Route("oop1")]
        public IActionResult Oop1()
        {
            Shoe _shoe = new()
            {
               // Brand = "Adidas"
            };

            string serializedShoe = JsonConvert.SerializeObject(_shoe);

                return Ok(serializedShoe);
        }

        [HttpGet]
        [Route("oop2")]
        public IActionResult Oop2()
        {
            Car _car = new();

            string carSerialized = JsonConvert.SerializeObject(_car);

            return Ok(carSerialized);
        }

        //Dışarıdan elle değer verdik.
        [HttpGet]
        [Route("oop3")]
        public IActionResult Oop3(int enginepower)
        {
            Ferrari ferrariObject= new(); //CTRL+. ile altında 2 nokta olanların farklı kullanım şekillerini görebiliyoruz.
           ferrariObject.EnginePowerCc = enginepower; 
           ferrariObject.Model = "F50";

           ferrariObject.Hatchback = ferrariObject.IsHatchback(ferrariObject.Brand);

           string ferrariSerialized = JsonConvert.SerializeObject(ferrariObject);

            return Ok(ferrariSerialized);

        }

        //Model olarak dışarıdan elle değer verdik.
        //[HttpPost] 
        //[Route("oop3")]
        //public IActionResult Oop3(Car model) //(Car model) (int enginepower) da olabilir. Böyle yaparsak alttaki model.EnginePowerCc yi de enginePower olarak değiştirmemiz gerekir.
        //{
        //    Ferrari ferrariObject = new(); //CTRL+. ile altında 2 nokta olanların farklı kullanım şekillerini görebiliyoruz.
        //    ferrariObject.EnginePowerCc = model.EnginePowerCc;
        //    ferrariObject.Model = "F50";

        //    ferrariObject.Hatchback = ferrariObject.IsHatchback(ferrariObject.Brand);

        //    string ferrariSerialized = JsonConvert.SerializeObject(ferrariObject);

        //    return Ok(ferrariSerialized);

        //}
    }
}
