using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Enums;
using MadScientistLab.Laboratory.LabInventory.Animals.Interfaces;

namespace MadScientistLab.Laboratory.LabInventory.Animals
{
    public class Lion : Animal, IPurrable
    {
        public Lion(string name) : base(name, AnimalTypeEnum.Lion)
        {
        }

        public void Purr(ICommandInterface cli)
        {
            cli.DisplayPurr(Name);
        }
    }
}
