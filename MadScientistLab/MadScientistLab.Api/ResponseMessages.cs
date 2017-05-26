using System;
using MadScientistLab.Laboratory.Cli;

namespace MadScientistLab.Api
{
    public class ResponseMessages : ICommandInterface
    {
        public string Message { get; set; }

        public void DisplayError(string message)
        {
            Message = message;
        }

        public void DisplayInfo(string message)
        {
            Message = message;
        }

        public void DisplayBark(string name)
        {
            Message = $"{name} woof ";
        }

        public void DisplayPurr(string name)
        {
            Message = $"{name} meow ";
        }

        public void DisplaySqueak(string name)
        {
            Message = $"{name} squeak ";
        }
    }
}
