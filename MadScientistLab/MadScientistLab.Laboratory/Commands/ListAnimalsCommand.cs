using System.Collections.Generic;
using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.LabInventory.Animals;

namespace MadScientistLab.Laboratory.Commands
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
