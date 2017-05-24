using MadScientistLab.Cli;
using MadScientistLab.LabInventory.Animals;
using MadScientistLab.LabInventory.Animals.Interfaces;

namespace MadScientistLab.LabInventory.Machines.Strategies
{
    public class PurrStrategy : ISoundStrategy
    {
        private readonly ICommandInterface _cli;

        public PurrStrategy(ICommandInterface cli)
        {
            _cli = cli;
        }

        public void MakeNoise(Animal animal)
        {
            if (animal is IPurrable)
            {
                ((IPurrable)animal).Purr(_cli);
            }
            else
            {
                _cli.DisplayError($"{animal.Name} can't purr.");
            }
        }
    }
}
