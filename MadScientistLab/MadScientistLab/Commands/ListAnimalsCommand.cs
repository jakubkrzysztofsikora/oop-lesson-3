using System.Collections.Generic;
using MadScientistLab.Cli;
using MadScientistLab.LabInventory.Animals;

namespace MadScientistLab.Commands
{
    public class ListAnimalsCommand : ILaboratoryCommand
    {
        private readonly List<Animal> _animals;
        private readonly ICommandInterface _cli;

        public ListAnimalsCommand(List<Animal> animals, ICommandInterface cli)
        {
            _animals = animals;
            _cli = cli;
        }

        public void Execute()
        {
            foreach (var animal in _animals)
            {
                _cli.DisplayInfo($"{animal.Type} - {animal.Name}");
            }
        }
    }
}
