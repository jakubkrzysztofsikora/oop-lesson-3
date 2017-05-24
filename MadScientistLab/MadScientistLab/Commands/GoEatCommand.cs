using MadScientistLab.Cli;
using MadScientistLab.Configuration;
using MadScientistLab.LabInventory.Animals;
using MadScientistLab.Validators;

namespace MadScientistLab.Commands
{
    public class GoEatCommand : ILaboratoryCommand
    {
        private readonly IAnimalValidator _validator;
        private readonly ICommandInterface _cli;
        private readonly Animal _animal;

        public GoEatCommand(IAnimalValidator validator, Animal animal, ICommandInterface cli)
        {
            _validator = validator;
            _animal = animal;
            _cli = cli;
        }

        public void Execute()
        {
            _validator.ValidateExistenceOfAnimal(_animal.Name);

            _animal.Eat();
            _cli.DisplayInfo($"{_animal.Name} {CommonConstants.GoEatSuccessMessage}");
        }
    }
}
