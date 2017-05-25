using MadScientistLab.Laboratory.LabInventory.Animals;

namespace MadScientistLab.Laboratory.Validators
{
    public interface IAnimalValidator
    {
        void ValidateExistenceOfAnimal(string name);
        bool ValidateIfAnimalReadyForMachine(Animal animal);
    }
}
