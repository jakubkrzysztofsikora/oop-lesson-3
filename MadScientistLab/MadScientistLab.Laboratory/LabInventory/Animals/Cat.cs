using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Enums;
using MadScientistLab.Laboratory.LabInventory.Animals.Interfaces;

namespace MadScientistLab.Laboratory.LabInventory.Animals
{
    //Example of implentation of Liskov substitution principle
    public class Cat : Animal, IPurrable, ISqueakable
    {
        public Cat(string name) : base(name, AnimalTypeEnum.Cat)
        {
        }

        public void Purr(ICommandInterface cli)
        {
            cli.DisplayPurr(Name);
        }

        public void Squeak(ICommandInterface cli)
        {
            cli.DisplaySqueak(Name);
        }
    }
}
