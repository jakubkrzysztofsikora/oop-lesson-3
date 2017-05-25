using MadScientistLab.Laboratory.Cli;
using MadScientistLab.Laboratory.LabInventory.Animals;
using MadScientistLab.Laboratory.LabInventory.Animals.Interfaces;

namespace MadScientistLab.Laboratory.LabInventory.Machines.Strategies
{
    public class BarkStrategy : ISoundStrategy
    {
        private readonly ICommandInterface _cli;

        public BarkStrategy(ICommandInterface cli)
        {
            _cli = cli;
        }

        public void MakeNoise(Animal animal)
        {
            if (animal is IBarkable)
            {
                ((IBarkable) animal).Bark(_cli);
            }
            else
            {
                _cli.DisplayError($"{animal.Name} can't bark.");
            }
        }
    }
}
