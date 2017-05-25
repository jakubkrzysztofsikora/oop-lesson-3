using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Enums;
using MadScientistLab.Laboratory.LabInventory.Animals.Interfaces;

namespace MadScientistLab.Laboratory.LabInventory.Animals
{
    public class Tiger : Animal, IPurrable
    {
        public Tiger(string name) : base(name, AnimalTypeEnum.Tiger)
        {
        }

        public void Purr(ICommandInterface cli)
        {
            cli.DisplayPurr(Name);
        }
    }
}
