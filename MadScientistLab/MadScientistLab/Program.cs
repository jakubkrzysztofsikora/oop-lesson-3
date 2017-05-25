using System;
using System.Collections.Generic;
using System.Linq;
using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Configuration;
using MadScientistLab.Laboratory.LabInventory.Animals;
using MadScientistLab.Laboratory.Validators;

namespace MadScientistLab
{
    class Program
    {
        private static readonly ICommandInterface Cli = new CommandInterface();
        private static readonly Func<List<Animal>, IAnimalValidator> ValidatorFactory = animalList => new AnimalValidator(Cli, animalList);
        private static readonly Laboratory.LabInventory.Laboratory Lab = new Laboratory.LabInventory.Laboratory(Cli, ValidatorFactory);
        private static readonly CommandParser CommandParser = new CommandParser();

        static void Main(string[] args)
        {
            while (true)
            {
                var userInput = Console.ReadLine();
                var userInputSplited = userInput.Split(CommonConstants.Whitespace);
                var command = userInputSplited.First();
                var commandFirstParameter = userInputSplited.Length > 1 ? userInputSplited[1] : String.Empty;
                var commandSecondParameter = userInputSplited.Length > 2 ? userInputSplited[2] : String.Empty;

                switch (command)
                {
                    case CliCommands.CreateCommand:
                        var animalType = CommandParser.GetAnimalTypeFromParameter(commandFirstParameter);
                        Lab.Create(animalType, commandSecondParameter);
                        break;
                    case CliCommands.GoToSleepCommand:
                        Lab.GoToSleep(commandFirstParameter);
                        break;
                    case CliCommands.GoEatCommand:
                        Lab.GoEat(commandFirstParameter);
                        break;
                    case CliCommands.BarkerCommand:
                        Lab.Barker(commandFirstParameter);
                        break;
                    case CliCommands.PurrerCommand:
                        Lab.Purrer(commandFirstParameter);
                        break;
                    case CliCommands.SqueakerCommand:
                        Lab.Squeaker(commandFirstParameter);
                        break;
                    case CliCommands.ListCommand:
                        Lab.ListAnimals();
                        break;
                    case CliCommands.DeleteCommand:
                        Lab.Delete(commandFirstParameter);
                        break;
                    default:
                        Cli.DisplayError("Unknown command");
                        break;
                }
            }
        }
    }
}
