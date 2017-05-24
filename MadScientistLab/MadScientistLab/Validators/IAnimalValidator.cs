using MadScientistLab.LabInventory.Animals;

namespace MadScientistLab.Validators
{
    public interface IAnimalValidator
    {
        void ValidateExistenceOfAnimal(string name);
        bool ValidateIfAnimalReadyForMachine(Animal animal);
    }
}
