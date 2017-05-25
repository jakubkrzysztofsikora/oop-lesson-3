using MadScientistLab.Api.Dto;
using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Enums;
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
    }
}
