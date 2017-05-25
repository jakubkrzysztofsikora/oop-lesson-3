using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.LabInventory.Animals.Interfaces;
using MadScientistLab.Laboratory.LabInventory.Animals;
using MadScientistLab.Laboratory.Enums;

namespace MadScientistLab.LabInventory.Animals.Interfaces
{
    public class Hamster : Animal, ISqueakable
    {
        public Hamster(string name) : base(name, AnimalTypeEnum.Hamster)
        {
        }

        public void Squeak(ICommandInterface cli)
        {
            cli.DisplaySqueak(Name);
        }
    }
}
