using System;
using System.Collections.Generic;
using System.Linq;
using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Commands;
using MadScientistLab.Laboratory.Enums;
using MadScientistLab.Laboratory.LabInventory.Animals;
using MadScientistLab.Laboratory.LabInventory.Machines;
using MadScientistLab.Laboratory.Validators;

namespace MadScientistLab.Laboratory.LabInventory
{
    public class Laboratory
    {
        private readonly List<Animal> _animals;
        private readonly ICommandInterface _cli;
        private readonly IAnimalValidator _validator;
        private readonly BigMachine _bigMachine;

        public Laboratory(ICommandInterface cli, Func<List<Animal>, IAnimalValidator> validatorFactory)
        {
            _cli = cli;
            _animals = new List<Animal>();
            _validator = validatorFactory(_animals);
            _bigMachine = new BigMachine(cli, _validator);
        }

        public void Create(AnimalTypeEnum animalType, string name)
        {
            new CreateAnimalCommand(_animals, animalType, name, _cli).Execute();
        }

        public void GoToSleep(string name)
        {
            var animal = GetAnimalByName(name);
            new GoToSleepCommand(_validator, animal, _cli).Execute();
        }

        public void GoEat(string name)
        {
            var animal = GetAnimalByName(name);
            new GoEatCommand(_validator, animal, _cli).Execute();
        }

        public void Barker(string name)
        {
            var animal = GetAnimalByName(name);
            _bigMachine.MakeNoise(animal);
        }

        public void Purrer(string name)
        {
            var animal = GetAnimalByName(name);
            _bigMachine.MakeNoise(animal);
        }

        public void Squeaker(string name)
        {
            var animal = GetAnimalByName(name);
            _bigMachine.MakeNoise(animal);
        }

        public IEnumerable<Animal> ListAnimals()
        {
            new ListAnimalsCommand(_animals, _cli).Execute();
            return _animals;
        }

        public void Delete(string nameOfAnimal)
        {
            new DeleteAnimalCommand(_animals, GetAnimalByName(nameOfAnimal), _cli).Execute();
        }

        private Animal GetAnimalByName(string name)
        {
            return _animals.SingleOrDefault(GetAnimalByNamePredicate(name));
        }

        private Func<Animal, bool> GetAnimalByNamePredicate(string nameOfAnimal)
        {
            return animal => animal.Name.Equals(nameOfAnimal);
        }
    }
}
