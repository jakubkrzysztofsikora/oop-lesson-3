using MadScientistLab.Api.Dto;
using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Enums;
using MadScientistLab.Laboratory.LabInventory.Animals;
using MadScientistLab.Laboratory.Validators;
using Microsoft.AspNetCore.Mvc;

namespace MadScientistLab.Api.Controllers
{
    [Route("api/[controller]")]
    public class LaboratoryController : Controller
    {
        private static readonly ResponseMessages Messages = new ResponseMessages();
        private static readonly Laboratory.LabInventory.Laboratory Laboratory = new Laboratory.LabInventory.Laboratory(Messages, animals => new AnimalValidator(new CommandInterface(), animals));
        private readonly CommandParser _commandParser = new CommandParser();

        [HttpPost("create")]
        public IActionResult CreateAnimal([FromBody] CreateAnimalDto dto)
        {
            AnimalTypeEnum animalType = _commandParser.GetAnimalTypeFromParameter(dto.Type);
            Laboratory.Create(animalType, dto.Name);
            return Ok(Messages.Message);
        }

        [HttpGet("list")]
        public IActionResult ListAnimals()
        {
            return new ObjectResult(Laboratory.ListAnimals());
        }

        [HttpPost("goSleep")]
        public IActionResult GoSleep([FromBody] string name)
        {
            Laboratory.GoToSleep(name);
            return Ok(Messages.Message);
        }

        [HttpPost("goEat")]
        public IActionResult GoEat([FromBody] string name)
        {
            Laboratory.GoEat(name);
            return Ok(Messages.Message);
        }
        [HttpPost("barker")]
        public IActionResult Barker([FromBody] string name)
        {
            Laboratory.Barker(name);
            return Ok(Messages.Message);
        }
        [HttpPost("squeaker")]
        public IActionResult Squeaker([FromBody] string name)
        {
            Laboratory.Squeaker(name);
            return Ok(Messages.Message);
        }
        [HttpPost("purrer")]
        public IActionResult Purrer([FromBody] string name)
        {
            Laboratory.Purrer(name);
            return Ok(Messages.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete([FromBody] string name)
        {
            Laboratory.Delete(name);
            return Ok(Messages.Message);
        }
    }
}
