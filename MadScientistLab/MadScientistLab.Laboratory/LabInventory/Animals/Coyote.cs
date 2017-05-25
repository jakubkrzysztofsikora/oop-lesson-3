using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Enums;
using MadScientistLab.Laboratory.LabInventory.Animals.Interfaces;

namespace MadScientistLab.Laboratory.LabInventory.Animals
{
    public class Coyote : Animal, IBarkable
    {
        public Coyote(string name) : base(name, AnimalTypeEnum.Coyote)
        {
        }

        public void Bark(ICommandInterface cli)
        {
            cli.DisplayBark(Name);
        }
    }
}
