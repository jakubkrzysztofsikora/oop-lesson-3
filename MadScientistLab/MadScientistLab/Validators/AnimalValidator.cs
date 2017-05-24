using System.Collections.Generic;
using System.Linq;
using MadScientistLab.Cli;
using MadScientistLab.Configuration;
using MadScientistLab.LabInventory.Animals;

namespace MadScientistLab.Validators
{
    public class AnimalValidator : IAnimalValidator
    {
        private readonly ICommandInterface _cli;
        private readonly List<Animal> _animals;

        public AnimalValidator(ICommandInterface cli, List<Animal> animals)
        {
            _cli = cli;
            _animals = animals;
        }

        public void ValidateExistenceOfAnimal(string name)
        {
            if (!_animals.Any(animal => animal.Name.Equals(name)))
            {
                _cli.DisplayError($"{name} {CommonConstants.AnimalDoesntExistsMessage}");
            }
        }

        public bool ValidateIfAnimalReadyForMachine(Animal animal)
        {
            if (animal.Fed && animal.Rested)
            {
                return true;
            }

            _cli.DisplayError($"{animal.Name} {CommonConstants.AnimalCantDoItMessage}");
            return false;
        }
    }
}
