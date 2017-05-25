using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.LabInventory.Animals;
using MadScientistLab.Laboratory.LabInventory.Animals.Interfaces;

namespace MadScientistLab.Laboratory.LabInventory.Machines.Strategies
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
