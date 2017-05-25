using System;
using System.Linq;
using MadScientistLab.Laboratory.Enums;

namespace MadScientistLab.Laboratory.Cli
{
    public class CommandParser
    {
        public AnimalTypeEnum GetAnimalTypeFromParameter(string type)
        {
            return ParseAnimalTypeStringToEnum(type);
        }

        private AnimalTypeEnum ParseAnimalTypeStringToEnum(string type)
        {
            var enumValues = Enum.GetValues(typeof(AnimalTypeEnum)).Cast<AnimalTypeEnum>().ToList();
            Func<AnimalTypeEnum, bool> animalTypeInEnumPredicate =
                animalType => type.Equals(animalType.ToString(), StringComparison.OrdinalIgnoreCase);
            bool typeExistsInEnum = enumValues.Any(animalTypeInEnumPredicate);

            if (!typeExistsInEnum)
            {
                throw new ArgumentOutOfRangeException();
            }

            return enumValues.Single(animalTypeInEnumPredicate);
        }
    }
}
