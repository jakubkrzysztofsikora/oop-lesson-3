using MadScientistLab.Cli;
using MadScientistLab.LabInventory.Animals;
using MadScientistLab.LabInventory.Animals.Interfaces;

namespace MadScientistLab.LabInventory.Machines.Strategies
{
    public class SqueakStrategy : ISoundStrategy
    {
        private readonly ICommandInterface _cli;

        public SqueakStrategy(ICommandInterface cli)
        {
            _cli = cli;
        }

        public void MakeNoise(Animal animal)
        {
            if (animal is ISqueakable)
            {
                ((ISqueakable)animal).Squeak(_cli);
            }
            else
            {
                _cli.DisplayError($"{animal.Name} can't squeak.");
            }
        }
    }
}
