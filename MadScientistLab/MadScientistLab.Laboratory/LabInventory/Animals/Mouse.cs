using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Enums;
using MadScientistLab.Laboratory.LabInventory.Animals.Interfaces;

namespace MadScientistLab.Laboratory.LabInventory.Animals
{
    public class Mouse : Animal, ISqueakable
    {
        public Mouse(string name) : base(name, AnimalTypeEnum.Mouse)
        {
        }

        public void Squeak(ICommandInterface cli)
        {
            cli.DisplaySqueak(Name);
        }
    }
}
