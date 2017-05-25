using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.Enums;
using MadScientistLab.Laboratory.LabInventory.Animals.Interfaces;

namespace MadScientistLab.Laboratory.LabInventory.Animals
{
    public class Wolf : Animal, IBarkable
    {
        public Wolf(string name) : base(name, AnimalTypeEnum.Wolf)
        {
        }

        public void Bark(ICommandInterface cli)
        {
            cli.DisplayBark(Name);
        }
    }
}
