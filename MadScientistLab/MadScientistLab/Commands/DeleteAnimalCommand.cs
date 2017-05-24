using System.Collections.Generic;
using MadScientistLab.Cli;
using MadScientistLab.LabInventory.Animals;

namespace MadScientistLab.Commands
{
    public class DeleteAnimalCommand : ILaboratoryCommand
    {
        private readonly List<Animal> _animals;
        private readonly Animal _animal;
        private readonly ICommandInterface _cli;

        public DeleteAnimalCommand(List<Animal> animals, Animal animal, ICommandInterface cli)
        {
            _animals = animals;
            _animal = animal;
            _cli = cli;
        }

        public void Execute()
        {
            _animals.Remove(_animal);
            _cli.DisplayInfo($"Removed {_animal.Name} from the lab");
        }
    }
}
