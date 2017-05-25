namespace MadScientistLab.Laboratory.Cli
{
    public interface ICommandInterface
    {
        void DisplayError(string message);
        void DisplayInfo(string message);
        void DisplayBark(string name);
        void DisplayPurr(string name);
        void DisplaySqueak(string name);
    }
}
