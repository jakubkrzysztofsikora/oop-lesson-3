using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Enums;
using MadScientistLab.Laboratory.LabInventory.Animals.Interfaces;

namespace MadScientistLab.Laboratory.LabInventory.Animals
{
    public class Dog : Animal, IBarkable
    {
        public Dog(string name) : base(name, AnimalTypeEnum.Dog)
        {
        }

        public void Bark(ICommandInterface cli)
        {
            cli.DisplayBark(Name);
        }
    }
}
